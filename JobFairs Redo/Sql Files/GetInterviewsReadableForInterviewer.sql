

DROP TABLE IF EXISTS #TableLocationNames;

CREATE TABLE #TableLocationNames
(
	TableID int,
	JobFairID int,
	LocationName varchar(50)
);

INSERT INTO #TableLocationNames

SELECT t.ID,
	t.JobFairID,
	l.Name
FROM [JobFair].[dbo].[Tables] AS t
	INNER JOIN [JobFair].[dbo].[Locations] AS l
	ON t.LocationID = l.ID;
;

DROP TABLE IF EXISTS #InterviewerNames;

CREATE TABLE #InterviewerNames
(
	InterviewerPersonID int,
	InterviewerFirst varchar(50),
	InterviewerLast varchar(50)
)

INSERT INTO #InterviewerNames

SELECT i.PersonID AS InterviewerPersonID,
	p.First AS InterviewerFirst,
	p.Last AS InterviewerLast	
FROM [JobFair].[dbo].[Interviewers] AS i
	INNER JOIN [JobFair].[dbo].[People] AS p
	ON p.ID = i.PersonID;
;


DROP TABLE IF EXISTS #InterviewsReadable;

CREATE TABLE #InterviewsReadable
(
	InterviewID int,
	CandidateFirst varchar(50),
	CandidateLast varchar(50),
	StartTime time,
	EndTime time,
	TableID int,
	InterviewDate date,
	CompanyName varchar(50),
	LocationName varchar(50),
	EmploymentTypeName varchar(50),
	SpecialtyName varchar(50),
	InterviewerFirst varchar(50),
	InterviewerLast varchar(50)
);

INSERT INTO #InterviewsReadable

SELECT i.ID AS InterviewID, 
	p.First AS CandidateFirst,
	p.Last AS CandidateLast, 
	ts.StartTime AS StartTime, 
	ts.EndTime AS EndTime, 
	i.TableID AS TableID, 
	jfd.[Date] AS InterviewDate,
	c.[Name] AS CompanyName,
	tln.LocationName AS LocationName,
	et.[Name] AS EmploymentTypeName,
	s.[Name] AS SpecialtyName,
	#InterviewerNames.InterviewerFirst AS InterviewerFirst,
	#InterviewerNames.InterviewerLast AS InterviewerLast
FROM [JobFair].[dbo].[Interviews] AS i
	INNER JOIN [JobFair].[dbo].[People] AS p
		ON i.CandidateID = p.ID
	INNER JOIN [JobFair].[dbo].[TimeSlots] AS ts
		ON i.TimeSlotID = ts.ID
	INNER JOIN [JobFair].[dbo].[JobFairDays] AS jfd
		ON ts.DayID = jfd.ID
	INNER JOIN #TableLocationNames AS tln
		ON tln.TableID = i.TableID
	INNER JOIN [JobFair].[dbo].[Companies] AS c
		ON c.ID = i.CompanyID
	INNER JOIN [JobFair].[dbo].[EmploymentTypes] AS et
		ON et.ID = i.EmploymentTypeID
	INNER JOIN [JobFair].[dbo].[Specialties] AS s
		ON i.SpecialtyID = s.ID
, [JobFair].[dbo].[InterviewInterviewers] AS ii
	INNER JOIN #InterviewerNames
	ON #InterviewerNames.InterviewerPersonID = ii.InterviewerID
	WHERE ii.InterviewID = i.ID;
;

SELECT * FROM #InterviewsReadable ORDER BY InterviewerFirst, InterviewerLast, InterviewDate, StartTime;