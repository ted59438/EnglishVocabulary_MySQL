USE [master]
GO
/****** Object:  Database [IThome2019_EnglishVocabulary]    Script Date: 2019/10/10 下午 04:32:30 ******/
CREATE DATABASE [IThome2019_EnglishVocabulary]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IThome2019_EnglishVocabulary', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\IThome2019_EnglishVocabulary.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'IThome2019_EnglishVocabulary_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\IThome2019_EnglishVocabulary_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IThome2019_EnglishVocabulary].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET ARITHABORT OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET  DISABLE_BROKER 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET  MULTI_USER 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET DB_CHAINING OFF 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [IThome2019_EnglishVocabulary]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 2019/10/10 下午 04:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [nvarchar](100) NOT NULL,
	[CategoryName] [nvarchar](20) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exam_Detail]    Script Date: 2019/10/10 下午 04:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam_Detail](
	[Exam_DetailID] [nvarchar](100) NOT NULL,
	[ExamID] [nvarchar](100) NULL,
	[OrderNumber] [int] NULL,
	[VocabularyID] [nvarchar](100) NULL,
	[IsCorrect] [bit] NULL,
 CONSTRAINT [PK_Exam_Detail] PRIMARY KEY CLUSTERED 
(
	[Exam_DetailID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Exam_Master]    Script Date: 2019/10/10 下午 04:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exam_Master](
	[ExamID] [nvarchar](100) NOT NULL,
	[StartDateTime] [datetime] NULL,
	[EndDateTime] [datetime] NULL,
	[CategoryID] [nvarchar](100) NULL,
	[StudentID] [nvarchar](100) NULL,
	[CorrectNumber] [int] NULL,
	[WrongNumber] [int] NULL,
	[Rate] [decimal](10, 2) NULL,
 CONSTRAINT [PK_Exam_Master] PRIMARY KEY CLUSTERED 
(
	[ExamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Student]    Script Date: 2019/10/10 下午 04:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[StudentID] [nvarchar](100) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[RealName] [nvarchar](20) NULL,
	[Birthdate] [datetime] NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Vocabulary]    Script Date: 2019/10/10 下午 04:32:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vocabulary](
	[VocabularyID] [nvarchar](100) NOT NULL,
	[CategoryID] [nvarchar](100) NULL,
	[English] [nvarchar](100) NULL,
	[Chinese] [nvarchar](20) NULL,
	[PartOfSpeech] [nvarchar](20) NULL,
 CONSTRAINT [PK_Vocabulary_List] PRIMARY KEY CLUSTERED 
(
	[VocabularyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Student] ([StudentID], [Username], [Password], [RealName], [Birthdate]) VALUES (N'9882826a-e475-44e2-909d-c9c5a9952499', N'admin', N'1234', N'泰D', CAST(N'2001-12-10 00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([StudentID], [Username], [Password], [RealName], [Birthdate]) VALUES (N'BE0B38DF-470B-4B60-92B8-016E40E967DE', N'test', N'1234', N'安安', CAST(N'2001-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([StudentID], [Username], [Password], [RealName], [Birthdate]) VALUES (N'EA20A8E1-1AAE-4D0A-B6B6-4B7299A1A8CC', N'test', N'1234', N'安安', CAST(N'2001-01-01 00:00:00.000' AS DateTime))
INSERT [dbo].[Student] ([StudentID], [Username], [Password], [RealName], [Birthdate]) VALUES (N'FAA088A6-D105-4EB1-A5DB-C65DA5F7A013', N'test', N'1234', N'安安', CAST(N'2001-01-01 00:00:00.000' AS DateTime))
USE [master]
GO
ALTER DATABASE [IThome2019_EnglishVocabulary] SET  READ_WRITE 
GO
