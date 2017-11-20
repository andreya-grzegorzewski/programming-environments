/* Get all the candidates and their specialties */

DELETE FROM [JobFair].[dbo].[InterviewInterviewers];
DELETE FROM [JobFair].[dbo].[Interviews];

DROP TABLE IF EXISTS #TheseCandidates

CREATE TABLE #TheseCandidates
(
	JobFairID int,
	PersonID int,
	SpecialtyID int,
	EmploymentTypeID int
);

INSERT INTO #TheseCandidates

SELECT jfp.JobFairID, 
	jfp.PersonID, 
	cs.SpecialtyID,
	c.EmploymentTypeID
	FROM [JobFair].[dbo].[JobFairPeople] AS jfp
	INNER JOIN [JobFair].[dbo].[Candidates] AS c
	ON jfp.PersonID = c.PersonID
	INNER JOIN [JobFair].[dbo].[CandidateSpecialties] AS cs
	ON c.ID = cs.CandidateID;
;

/* Get all the interviewers and their specialties */

DROP TABLE IF EXISTS #TheseInterviewers

CREATE TABLE #TheseInterviewers
(
	JobFairID int,
	PersonID int,
	SpecialtyID int,
	CompanyID int,
	EmploymentTypeID int
);

INSERT INTO #TheseInterviewers

SELECT jfp.JobFairID, jfp.PersonID, iSpec.SpecialtyID, i.CompanyID, cet.EmploymentTypeID
	FROM [JobFair].[dbo].[JobFairPeople] AS jfp
	INNER JOIN [JobFair].[dbo].[Interviewers] AS i
	ON jfp.PersonID = i.PersonID
	INNER JOIN [JobFair].[dbo].[InterviewerSpecialties] AS iSpec
	ON i.ID = iSpec.InterviewerID
	INNER JOIN [JobFair].[dbo].[CompanyEmploymentTypes] AS cet
	ON cet.CompanyID = i.CompanyID;	
;

/* Create pairings of candidates/interviewers where their specialties overlap */

DROP TABLE IF EXISTS #Pairs

CREATE TABLE #Pairs
(
	InterviewerPersonID int,
	CandidatePersonID int,
	CompanyID int,
	SpecialtyID int,
	EmploymentTypeID int
);

INSERT INTO #Pairs

SELECT ti.PersonID AS InterviewerPersonID,
	tc.PersonID AS CandidatePersonID,
	ti.CompanyID,
	ti.SpecialtyID,
	ti.EmploymentTypeID
	FROM #TheseInterviewers AS ti
	INNER JOIN #TheseCandidates AS tc
	ON (ti.SpecialtyID = tc.SpecialtyID AND ti.EmploymentTypeID = tc.EmploymentTypeID)
	ORDER BY CompanyID;
;

/* Generate time slot/table pairs */

DROP TABLE IF EXISTS #Environments

CREATE TABLE #Environments 
(
	TimeSlotID int,
	JobFairID int,
	DayID int,
	JobFairDate date,
	StartTime time(0),
	EndTime time(0),
	LocationID int,
	TableID int
)

INSERT INTO #Environments

	SELECT ts.ID,
		ts.JobFairID,
		ts.DayID,
		jfd.Date,
		ts.StartTime,
		ts.EndTime,
		t.LocationID,
		t.ID
	FROM [JobFair].[dbo].[TimeSlots] AS ts
		INNER JOIN [JobFair].[dbo].[JobFairDays] AS jfd
		ON ts.DayID = jfd.ID AND ts.JobFairID = jfd.JobFairID
		INNER JOIN [JobFair].[dbo].[Tables] AS t
		ON t.JobFairID = ts.JobFairID;	
;

/* Match Pairs with Environments to fill up the [JobFair].[dbo].[Interviews] table */
/* To do: Allow for multiple interviewers with one interview. */

DROP TABLE IF EXISTS #PersonTimes

CREATE TABLE #PersonTimes (
	PersonID int,
	StartTime time
)

SELECT * FROM #Pairs;
SELECT * FROM #Environments;

/* #Pairs data */
DECLARE @InterviewerPersonID int;
DECLARE @CandidatePersonID int;
DECLARE @CompanyID int;
DECLARE @SpecialtyID int;
DECLARE @EmploymentTypeID int;

/* #Environments data */
DECLARE @TimeSlotID int;
DECLARE @JobFairID int;
DECLARE @JobFairDate date;
DECLARE @StartTime time(0);
DECLARE @EndTime time(0);
DECLARE @LocationID int;
DECLARE @TableID int;
DECLARE @InterviewID int;

DECLARE @Index int;
/*DECLARE @RowNum int;*/

WHILE EXISTS (SELECT DISTINCT * FROM #Pairs)
BEGIN

	SELECT TOP 1
		@InterviewerPersonID = InterviewerPersonID,
		@CandidatePersonID = CandidatePersonID,
		@CompanyID = CompanyID,
		@SpecialtyID = SpecialtyID,
		@EmploymentTypeID = EmploymentTypeID
	FROM #Pairs
	ORDER BY CompanyID, InterviewerPersonID ASC
	
	SET @Index = 1;

	WHILE EXISTS (SELECT * FROM #Environments)
	BEGIN

	WITH ThisEnvironment AS 
	(
		SELECT RowNum = row_number() OVER (ORDER BY JobFairDate, StartTime), *
		FROM #Environments
	)
		SELECT 
			@TimeSlotID = ThisEnvironment.TimeSlotID,
			@JobFairID = ThisEnvironment.JobFairID,
			@JobFairDate = ThisEnvironment.JobFairDate,
			@StartTime = ThisEnvironment.StartTime,
			@EndTime = ThisEnvironment.EndTime,
			@LocationID = ThisEnvironment.LocationID,
			@TableID = ThisEnvironment.TableID
		FROM ThisEnvironment
		WHERE RowNum = @Index;

		IF NOT EXISTS(SELECT * FROM #PersonTimes
			WHERE (#PersonTimes.PersonID = @InterviewerPersonID
			OR #PersonTimes.PersonID = @CandidatePersonID)
			AND #PersonTimes.StartTime = @StartTime)
		BEGIN
			SET @Index = @Index - 1;
			INSERT INTO #PersonTimes 
				(PersonID, StartTime)
				VALUES (@InterviewerPersonID, @StartTime);
			INSERT INTO #PersonTimes
				(PersonID, StartTime)
				VALUES (@CandidatePersonID, @StartTime);
			INSERT INTO [JobFair].[dbo].[Interviews]
				(JobFairID, CandidateID, TimeSlotID, TableID,
				 CompanyID, EmploymentTypeID, SpecialtyID)
				VALUES (@JobFairID, @CandidatePersonID, @TimeSlotID,
					    @TableID, @CompanyID, @EmploymentTypeID, @SpecialtyID);

			SET @InterviewID = @@IDENTITY;

			INSERT INTO [JobFair].[dbo].[InterviewInterviewers]
				(InterviewID, InterviewerID)
				VALUES (@InterviewID, @InterviewerPersonID);

			DELETE FROM #Environments 
			WHERE #Environments.TimeSlotID = @TimeSlotID
				AND #Environments.LocationID = @LocationID
				AND #Environments.TableID = @TableID
			
			DELETE FROM #Pairs
			WHERE #Pairs.InterviewerPersonID = @InterviewerPersonID
			  AND #Pairs.CandidatePersonID = @CandidatePersonID
			  AND #Pairs.CompanyID = @CompanyID
			  AND #Pairs.SpecialtyID = @SpecialtyID
			  AND #Pairs.EmploymentTypeID = @EmploymentTypeID
			
			BREAK;
		END	
		SET @Index = @Index + 1;
	END
END