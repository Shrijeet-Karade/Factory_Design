USE [master]
GO
/****** Object:  Database [Shrijeet'sDB]    Script Date: 9/9/2018 9:41:00 PM ******/
CREATE DATABASE [Shrijeet'sDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Shrijeet''sDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Shrijeet''sDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Shrijeet''sDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\Shrijeet''sDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Shrijeet'sDB] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Shrijeet'sDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Shrijeet'sDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Shrijeet'sDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Shrijeet'sDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Shrijeet'sDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Shrijeet'sDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Shrijeet'sDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Shrijeet'sDB] SET  MULTI_USER 
GO
ALTER DATABASE [Shrijeet'sDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Shrijeet'sDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Shrijeet'sDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Shrijeet'sDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [Shrijeet'sDB]
GO
/****** Object:  Table [dbo].[Activity]    Script Date: 9/9/2018 9:41:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Activity](
	[ProductID] [int] NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Price] [int] NOT NULL,
	[isSaved] [bit] NULL,
	[isBooked] [bit] NULL,
	[Location] [nchar](10) NULL,
	[Time] [time](7) NULL,
	[Duration] [nchar](10) NULL,
 CONSTRAINT [PK_Activity] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Air]    Script Date: 9/9/2018 9:41:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Air](
	[ProductID] [int] NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Price] [int] NOT NULL,
	[isSaved] [bit] NULL,
	[isBooked] [bit] NULL,
	[From] [nchar](10) NULL,
	[To] [nchar](10) NULL,
	[DepartureDate] [date] NULL,
	[ArrivalDate] [date] NULL,
 CONSTRAINT [PK_Air] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Car]    Script Date: 9/9/2018 9:41:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[ProductID] [int] NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Price] [int] NOT NULL,
	[isSaved] [bit] NULL,
	[isBooked] [bit] NULL,
	[From] [nchar](10) NULL,
	[To] [nchar](10) NULL,
	[DepartureDate] [date] NULL,
	[ArrivalDate] [date] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Hotel]    Script Date: 9/9/2018 9:41:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hotel](
	[ProductID] [int] NOT NULL,
	[Name] [nchar](10) NOT NULL,
	[Price] [int] NOT NULL,
	[isSaved] [bit] NULL,
	[isBooked] [bit] NULL,
	[Location] [nchar](10) NULL,
	[From] [date] NULL,
	[To] [date] NULL,
 CONSTRAINT [PK_Hotel] PRIMARY KEY CLUSTERED 
(
	[ProductID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
USE [master]
GO
ALTER DATABASE [Shrijeet'sDB] SET  READ_WRITE 
GO
