/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2016 (13.0.4001)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2017
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/

USE [master]
GO
/****** Object:  Database [JobFair]    Script Date: 9/13/2017 11:33:13 AM ******/
CREATE DATABASE [JobFair]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JobFair', FILENAME = N'C:\Users\Dave\JobFair.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'JobFair_log', FILENAME = N'C:\Users\Dave\JobFair_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [JobFair] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JobFair].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JobFair] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JobFair] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JobFair] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JobFair] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JobFair] SET ARITHABORT OFF 
GO
ALTER DATABASE [JobFair] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JobFair] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JobFair] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JobFair] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JobFair] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JobFair] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JobFair] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JobFair] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JobFair] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JobFair] SET  DISABLE_BROKER 
GO
ALTER DATABASE [JobFair] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JobFair] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JobFair] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JobFair] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JobFair] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JobFair] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JobFair] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JobFair] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [JobFair] SET  MULTI_USER 
GO
ALTER DATABASE [JobFair] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JobFair] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JobFair] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JobFair] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [JobFair] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [JobFair] SET QUERY_STORE = OFF
GO
USE [JobFair]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [JobFair]
GO
/****** Object:  Table [dbo].[Candidates]    Script Date: 9/13/2017 11:33:13 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Candidates](
	[ID] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Candidates_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interviewers]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interviewers](
	[ID] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
 CONSTRAINT [PK_Interviewers_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interviews]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interviews](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JobFairID] [int] NOT NULL,
	[CandidateID] [int] NOT NULL,
	[TimeSlotID] [int] NOT NULL,
	[TableID] [int] NOT NULL,
 CONSTRAINT [PK_Interviews] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobFairDays]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobFairDays](
	[ID] [int] NOT NULL,
	[JobFairID] [int] NOT NULL,
 CONSTRAINT [PK_JobFairDays] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobFairInterviewers]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobFairInterviewers](
	[JobFairID] [int] NOT NULL,
	[InterviewerID] [int] NOT NULL,
	[InterviewID] [int] NOT NULL,
 CONSTRAINT [PK_JobFairInterviewers] PRIMARY KEY CLUSTERED 
(
	[JobFairID] ASC,
	[InterviewerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobFairs]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobFairs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](50) NOT NULL,
	[Description] [varchar](255) NULL,
	[StartDate] [date] NULL,
	[EndDate] [nchar](10) NULL,
	[VenueID] [int] NULL,
	[Website] [varchar](75) NULL,
	[Phone] [varchar](13) NULL,
	[ContactPersonID] [int] NULL,
 CONSTRAINT [PK_JobFairs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JobFairVenues]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JobFairVenues](
	[JobFairID] [int] NOT NULL,
	[VenueID] [int] NOT NULL,
 CONSTRAINT [PK_JobFairVenues] PRIMARY KEY CLUSTERED 
(
	[JobFairID] ASC,
	[VenueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Locations]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Locations](
	[ID] [int] NOT NULL,
	[JobFairID] [int] NULL,
	[Name] [varchar](10) NOT NULL,
	[Description] [varchar](255) NULL,
 CONSTRAINT [PK_Locations] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[People]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[First] [varchar](15) NOT NULL,
	[MI] [char](1) NULL,
	[Last] [varchar](20) NOT NULL,
	[Title] [int] NULL,
	[Address1] [varchar](25) NULL,
	[Address2] [varchar](25) NULL,
	[City] [varchar](20) NULL,
	[State] [varchar](2) NULL,
	[Zip] [varchar](10) NULL,
	[EMail] [varchar](35) NULL,
	[Phone] [varchar](13) NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tables]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tables](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JobFairID] [int] NOT NULL,
	[LocationID] [int] NOT NULL,
	[Accessible] [bit] NULL,
	[HasPower] [bit] NULL,
 CONSTRAINT [PK_Tables] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TimeSlots]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TimeSlots](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JobFairID] [int] NOT NULL,
	[DayID] [int] NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
 CONSTRAINT [PK_TimeSlots_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venues]    Script Date: 9/13/2017 11:33:14 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venues](
	[ID] [int] NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[JobFairID] [int] NOT NULL,
	[Short Description] [varchar](255) NULL,
	[Long Description] [varchar](max) NULL,
 CONSTRAINT [PK_Venues] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Candidates]  WITH CHECK ADD  CONSTRAINT [FK_Candidates_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[Candidates] CHECK CONSTRAINT [FK_Candidates_People]
GO
ALTER TABLE [dbo].[Interviewers]  WITH CHECK ADD  CONSTRAINT [FK_Interviewers_People] FOREIGN KEY([PersonID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[Interviewers] CHECK CONSTRAINT [FK_Interviewers_People]
GO
ALTER TABLE [dbo].[Interviews]  WITH CHECK ADD  CONSTRAINT [FK_Interviews_Candidates] FOREIGN KEY([CandidateID])
REFERENCES [dbo].[Candidates] ([ID])
GO
ALTER TABLE [dbo].[Interviews] CHECK CONSTRAINT [FK_Interviews_Candidates]
GO
ALTER TABLE [dbo].[Interviews]  WITH CHECK ADD  CONSTRAINT [FK_Interviews_JobFairs] FOREIGN KEY([JobFairID])
REFERENCES [dbo].[JobFairs] ([ID])
GO
ALTER TABLE [dbo].[Interviews] CHECK CONSTRAINT [FK_Interviews_JobFairs]
GO
ALTER TABLE [dbo].[Interviews]  WITH CHECK ADD  CONSTRAINT [FK_Interviews_Tables] FOREIGN KEY([TableID])
REFERENCES [dbo].[Tables] ([ID])
GO
ALTER TABLE [dbo].[Interviews] CHECK CONSTRAINT [FK_Interviews_Tables]
GO
ALTER TABLE [dbo].[Interviews]  WITH CHECK ADD  CONSTRAINT [FK_Interviews_TimeSlots] FOREIGN KEY([TimeSlotID])
REFERENCES [dbo].[TimeSlots] ([ID])
GO
ALTER TABLE [dbo].[Interviews] CHECK CONSTRAINT [FK_Interviews_TimeSlots]
GO
ALTER TABLE [dbo].[JobFairDays]  WITH CHECK ADD  CONSTRAINT [FK_JobFairDays_JobFairs] FOREIGN KEY([JobFairID])
REFERENCES [dbo].[JobFairs] ([ID])
GO
ALTER TABLE [dbo].[JobFairDays] CHECK CONSTRAINT [FK_JobFairDays_JobFairs]
GO
ALTER TABLE [dbo].[JobFairInterviewers]  WITH CHECK ADD  CONSTRAINT [FK_JobFairInterviewers_Interviewers] FOREIGN KEY([InterviewerID])
REFERENCES [dbo].[Interviewers] ([ID])
GO
ALTER TABLE [dbo].[JobFairInterviewers] CHECK CONSTRAINT [FK_JobFairInterviewers_Interviewers]
GO
ALTER TABLE [dbo].[JobFairInterviewers]  WITH CHECK ADD  CONSTRAINT [FK_JobFairInterviewers_Interviews] FOREIGN KEY([InterviewID])
REFERENCES [dbo].[Interviews] ([ID])
GO
ALTER TABLE [dbo].[JobFairInterviewers] CHECK CONSTRAINT [FK_JobFairInterviewers_Interviews]
GO
ALTER TABLE [dbo].[JobFairInterviewers]  WITH CHECK ADD  CONSTRAINT [FK_JobFairInterviewers_JobFairs] FOREIGN KEY([JobFairID])
REFERENCES [dbo].[JobFairs] ([ID])
GO
ALTER TABLE [dbo].[JobFairInterviewers] CHECK CONSTRAINT [FK_JobFairInterviewers_JobFairs]
GO
ALTER TABLE [dbo].[JobFairs]  WITH CHECK ADD  CONSTRAINT [FK_JobFairs_People] FOREIGN KEY([ContactPersonID])
REFERENCES [dbo].[People] ([ID])
GO
ALTER TABLE [dbo].[JobFairs] CHECK CONSTRAINT [FK_JobFairs_People]
GO
ALTER TABLE [dbo].[JobFairs]  WITH CHECK ADD  CONSTRAINT [FK_JobFairs_Venues] FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venues] ([ID])
GO
ALTER TABLE [dbo].[JobFairs] CHECK CONSTRAINT [FK_JobFairs_Venues]
GO
ALTER TABLE [dbo].[JobFairVenues]  WITH CHECK ADD  CONSTRAINT [FK_JobFairVenues_JobFairs] FOREIGN KEY([JobFairID])
REFERENCES [dbo].[JobFairs] ([ID])
GO
ALTER TABLE [dbo].[JobFairVenues] CHECK CONSTRAINT [FK_JobFairVenues_JobFairs]
GO
ALTER TABLE [dbo].[JobFairVenues]  WITH CHECK ADD  CONSTRAINT [FK_JobFairVenues_Venues] FOREIGN KEY([VenueID])
REFERENCES [dbo].[Venues] ([ID])
GO
ALTER TABLE [dbo].[JobFairVenues] CHECK CONSTRAINT [FK_JobFairVenues_Venues]
GO
ALTER TABLE [dbo].[Locations]  WITH CHECK ADD  CONSTRAINT [FK_Locations_JobFairs] FOREIGN KEY([JobFairID])
REFERENCES [dbo].[JobFairs] ([ID])
GO
ALTER TABLE [dbo].[Locations] CHECK CONSTRAINT [FK_Locations_JobFairs]
GO
ALTER TABLE [dbo].[Tables]  WITH CHECK ADD  CONSTRAINT [FK_Tables_JobFairs] FOREIGN KEY([JobFairID])
REFERENCES [dbo].[JobFairs] ([ID])
GO
ALTER TABLE [dbo].[Tables] CHECK CONSTRAINT [FK_Tables_JobFairs]
GO
ALTER TABLE [dbo].[Tables]  WITH CHECK ADD  CONSTRAINT [FK_Tables_Locations] FOREIGN KEY([LocationID])
REFERENCES [dbo].[Locations] ([ID])
GO
ALTER TABLE [dbo].[Tables] CHECK CONSTRAINT [FK_Tables_Locations]
GO
ALTER TABLE [dbo].[TimeSlots]  WITH CHECK ADD  CONSTRAINT [FK_TimeSlots_JobFairDays] FOREIGN KEY([DayID])
REFERENCES [dbo].[JobFairDays] ([ID])
GO
ALTER TABLE [dbo].[TimeSlots] CHECK CONSTRAINT [FK_TimeSlots_JobFairDays]
GO
ALTER TABLE [dbo].[TimeSlots]  WITH CHECK ADD  CONSTRAINT [FK_TimeSlots_JobFairs] FOREIGN KEY([JobFairID])
REFERENCES [dbo].[JobFairs] ([ID])
GO
ALTER TABLE [dbo].[TimeSlots] CHECK CONSTRAINT [FK_TimeSlots_JobFairs]
GO
ALTER TABLE [dbo].[Venues]  WITH CHECK ADD  CONSTRAINT [FK_Venues_JobFairs] FOREIGN KEY([JobFairID])
REFERENCES [dbo].[JobFairs] ([ID])
GO
ALTER TABLE [dbo].[Venues] CHECK CONSTRAINT [FK_Venues_JobFairs]
GO
USE [master]
GO
ALTER DATABASE [JobFair] SET  READ_WRITE 
GO
