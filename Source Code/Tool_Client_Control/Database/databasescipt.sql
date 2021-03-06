/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2014
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [MenuGameDB]    Script Date: 02/05/2018 9:38:39 CH ******/
CREATE DATABASE [MenuGameDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MenuGameDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MenuGameDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MenuGameDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MenuGameDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MenuGameDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MenuGameDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MenuGameDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MenuGameDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MenuGameDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MenuGameDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [MenuGameDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MenuGameDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MenuGameDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MenuGameDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MenuGameDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MenuGameDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MenuGameDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MenuGameDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MenuGameDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MenuGameDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MenuGameDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MenuGameDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MenuGameDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MenuGameDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MenuGameDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MenuGameDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MenuGameDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MenuGameDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MenuGameDB] SET  MULTI_USER 
GO
ALTER DATABASE [MenuGameDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MenuGameDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MenuGameDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MenuGameDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MenuGameDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [MenuGameDB]
GO
/****** Object:  User [admin]    Script Date: 02/05/2018 9:38:39 CH ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[GameItem]    Script Date: 02/05/2018 9:38:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GameItem](
	[Id] [nvarchar](50) NOT NULL,
	[NameGame] [nvarchar](200) NULL,
	[URLExecute] [nvarchar](50) NULL,
	[IconUrL] [nvarchar](500) NULL,
	[IcoUrL] [nvarchar](500) NULL,
	[IconImage] [binary](50) NULL,
	[DateScan] [date] NULL,
	[Size] [real] NULL,
	[Description] [nvarchar](500) NULL,
	[Version] [nvarchar](500) NULL,
	[IsGameOnline] [bit] NOT NULL,
	[IsGameHot] [bit] NOT NULL,
	[IsGameChienThuat] [bit] NOT NULL,
 CONSTRAINT [PK_GameItem] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 02/05/2018 9:38:39 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[Email] [nvarchar](228) NOT NULL,
	[Password] [nvarchar](228) NULL,
	[FirstName] [nvarchar](228) NULL,
	[LastName] [nvarchar](228) NULL,
	[LogoUrl] [nvarchar](228) NULL,
	[Remember] [bit] NULL,
	[Address] [nvarchar](228) NULL,
	[NumberPhone] [nvarchar](20) NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[GameItem] ADD  CONSTRAINT [DF_GameItem_DateScan]  DEFAULT (getdate()) FOR [DateScan]
GO
ALTER TABLE [dbo].[GameItem] ADD  CONSTRAINT [DF_GameItem_Size]  DEFAULT ((0)) FOR [Size]
GO
ALTER TABLE [dbo].[GameItem] ADD  CONSTRAINT [DF_GameItem_Version]  DEFAULT ((1.0)) FOR [Version]
GO
ALTER TABLE [dbo].[GameItem] ADD  CONSTRAINT [DF_GameItem_IsGameOnline]  DEFAULT ((0)) FOR [IsGameOnline]
GO
ALTER TABLE [dbo].[GameItem] ADD  CONSTRAINT [DF_GameItem_IsGameHot]  DEFAULT ((0)) FOR [IsGameHot]
GO
ALTER TABLE [dbo].[GameItem] ADD  CONSTRAINT [DF_GameItem_IsGameChienThuat]  DEFAULT ((0)) FOR [IsGameChienThuat]
GO
USE [master]
GO
ALTER DATABASE [MenuGameDB] SET  READ_WRITE 
GO
