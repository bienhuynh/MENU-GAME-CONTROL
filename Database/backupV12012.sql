/*    ==Scripting Parameters==

    Source Server Version : SQL Server 2017 (14.0.1000)
    Source Database Engine Edition : Microsoft SQL Server Express Edition
    Source Database Engine Type : Standalone SQL Server

    Target Server Version : SQL Server 2012
    Target Database Engine Edition : Microsoft SQL Server Standard Edition
    Target Database Engine Type : Standalone SQL Server
*/
USE [master]
GO
/****** Object:  Database [GAME_MENU_CONTROL]    Script Date: 30/05/2018 5:49:08 CH ******/
CREATE DATABASE [GAME_MENU_CONTROL]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GAMEMENUCONTROL', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\GAMEMENUCONTROL.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GAMEMENUCONTROL_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\GAMEMENUCONTROL_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GAME_MENU_CONTROL].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET ARITHABORT OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET  MULTI_USER 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
USE [GAME_MENU_CONTROL]
GO
/****** Object:  User [admin]    Script Date: 30/05/2018 5:49:09 CH ******/
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
	[Date] [date] NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComputerMasterClient]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComputerMasterClient](
	[MAC] [nvarchar](50) NOT NULL,
	[UserId] [nvarchar](128) NULL,
	[NameComputer] [nvarchar](128) NULL,
	[IP] [nvarchar](20) NULL,
	[IsDelete] [bit] NULL,
	[IsDisable] [bit] NULL,
	[DateJoin] [date] NULL,
	[SystemOperator] [nvarchar](20) NULL,
 CONSTRAINT [PK_ComputerMasterClient] PRIMARY KEY CLUSTERED 
(
	[MAC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ComputerSubClient]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ComputerSubClient](
	[MAC] [nchar](50) NOT NULL,
	[MacIdMaster] [nvarchar](50) NULL,
	[NameComputer] [nvarchar](128) NULL,
	[IP] [nvarchar](128) NULL,
	[DateJoin] [date] NULL,
	[IsDelete] [bit] NULL,
	[IsDisable] [bit] NULL,
 CONSTRAINT [PK_ComputerSubClient] PRIMARY KEY CLUSTERED 
(
	[MAC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HistoryLoginSession]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HistoryLoginSession](
	[UserId] [nvarchar](128) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TimeStartLogin] [datetime] NULL,
	[IPAddress] [nvarchar](128) NULL,
	[MacAddress] [nvarchar](128) NULL,
	[NameMachine] [nvarchar](128) NULL,
 CONSTRAINT [PK_HistoryLoginSession] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Licence]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Licence](
	[Id] [nvarchar](128) NOT NULL,
	[LicenceKey] [nvarchar](30) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[NumberDevicesLiveActive] [int] NOT NULL,
	[MaxNumberDevices] [int] NOT NULL,
	[Price] [money] NOT NULL,
	[DateCreate] [date] NULL,
	[UserIdCreate] [nvarchar](128) NULL,
 CONSTRAINT [PK_Licence] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[List_Game_Disk]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[List_Game_Disk](
	[Id] [nvarchar](128) NOT NULL,
	[NameGame] [nvarchar](256) NOT NULL,
	[URLExecute] [nvarchar](556) NULL,
	[IconUrL] [nvarchar](256) NULL,
	[IcoUrl] [nvarchar](256) NULL,
	[IconImage] [image] NULL,
	[DateScan] [date] NULL,
	[Size] [float] NULL,
	[Description] [nvarchar](1000) NULL,
	[Version] [nchar](10) NULL,
	[IsDelete] [bit] NULL,
	[CategoryGames] [nvarchar](1000) NULL,
 CONSTRAINT [PK_List_Game_Disk] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu_Type]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu_Type](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Menu_Type] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Control_Menu]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Control_Menu](
	[UserId] [nvarchar](128) NOT NULL,
	[GameId] [nvarchar](128) NOT NULL,
	[MenuId] [int] NOT NULL,
	[IsHidden] [bit] NULL,
 CONSTRAINT [PK_User_Control_Menu] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[GameId] ASC,
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Game_Owner]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Game_Owner](
	[UserId] [nvarchar](128) NOT NULL,
	[GameId] [nvarchar](128) NOT NULL,
	[IsShowOnMenu] [bit] NOT NULL,
	[IsRemoveOnDisk] [bit] NOT NULL,
	[IsGameHot] [bit] NULL,
	[URLDiskGame] [nvarchar](256) NULL,
	[IconUrlCustom] [nvarchar](256) NULL,
	[IcoUrlCustom] [nvarchar](256) NULL,
	[SumNumberPlay] [int] NULL,
	[NumberPlayInDay] [int] NULL,
 CONSTRAINT [PK_User_Game_Owner] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[GameId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User_Licence]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User_Licence](
	[Userid] [nvarchar](128) NOT NULL,
	[LicenceId] [nvarchar](128) NOT NULL,
	[DateStart] [date] NOT NULL,
	[DateEnd] [date] NOT NULL,
	[IsActive] [bit] NOT NULL,
	[IsLive] [bit] NULL,
	[DateInput] [date] NULL,
	[MACMasterId] [nvarchar](50) NULL,
 CONSTRAINT [PK_User_Licence] PRIMARY KEY CLUSTERED 
(
	[Userid] ASC,
	[LicenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserId] [nvarchar](128) NOT NULL,
	[FirstName] [nvarchar](128) NULL,
	[LastName] [nvarchar](128) NULL,
	[NetName] [nvarchar](128) NULL,
	[Address] [nvarchar](228) NULL,
	[NumberPhone] [nvarchar](20) NULL,
	[DateCreate] [date] NULL,
	[IsDelete] [bit] NULL,
	[IsDisable] [bit] NULL,
	[LogoUrl] [nvarchar](228) NULL,
 CONSTRAINT [PK_UserProfile] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VersionHistory]    Script Date: 30/05/2018 5:49:10 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VersionHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Version] [nvarchar](10) NULL,
	[IsUpdateAvailable] [bit] NULL,
	[Mandatory] [bit] NULL,
	[InstallerArgs] [nvarchar](50) NULL,
	[Checksum] [nvarchar](500) NULL,
	[HashingAlgorithm] [nvarchar](10) NULL,
	[SoftName] [nvarchar](20) NULL,
	[DateChange] [date] NULL,
	[ChangeLog] [nvarchar](500) NULL,
 CONSTRAINT [PK_VersionHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201803110555421_InitialCreate', N'LKACSOFT.UI.Models.ApplicationDbContext', 0x1F8B0800000000000400DD5C5B6FE3B6127E2F70FE83A0A7738AD4CAA5BBD813D85BA44E7C4ED0DCB04E16E76D414BB423AC44A912954D50F497F5A13FA97FE10C25EAC68B2EB6623BC5028B881C7E331C0EC9E170E8BFFEF873FCD3B3EF194F388ADD804CCCA3D1A1696062078E4B561333A1CB1F3E983F7DFCC777E30BC77F363EE774278C0E5A9278623E521A9E5A566C3F621FC523DFB5A3200E96746407BE859CC03A3E3CFCB775746461803001CB30C69F12425D1FA71FF0390D888D439A20EF3A70B017F372A899A7A8C60DF2711C221B4FCCAB5FCEA6F3DBD9FDE8E17294519BC699E72290648EBDA5692042028A28C879FA10E3398D02B29A875080BCFB971003DD127931E6F29F96E45DBB7278CCBA62950D73283B8969E0F7043C3AE1BAB1C4E66B69D82C7407DABB002DD317D6EB548313F3D2C169D1A7C00305880C4FA75EC48827E675C1E22C0E6F301DE50D4719E42C02B86F41F47554453C303AB73B286CE97874C8FE1D18D3C4A349842704273442DE8171972C3CD7FE05BFDC075F31999C1C2D96271FDEBD47CEC9FB1FF1C9BB6A4FA1AF40572B80A2BB28087104B2E165D17FD3B0EAED2CB161D1ACD226D30AD8124C0BD3B846CF5798ACE8234C98E30FA631739FB1939770E37A202ECC226844A3043E6F12CF430B0F17F556234FF67F03D7E377EF07E17A839EDC553AF4027F983811CCAB4FD84B6BE34737CCA6576DBCBF70B25914F8ECBB6E5F59ED9779904436EB4CA025B947D10AD3BA7463AB34DE4E26CDA08637EB1C75FF4D9B492A9BB7929475689D9990B3D8F66CC8E57D5DBE9D2DEE2C0C61F052D3621A69323879B31A09AD0F8C0A4D693A475D4D874097FECE2BE1858F5C6F80A5B00317F042966EE4E3A2973F07607888F496F90EC531AC04CE7F51FCD8203AFC3980E8736C271118E89C223F7C756E778F01C13789BF6076BF3D5E830DCDFDB760866C1A441784B5DA18EF2AB0BF0609BD20CE39A2F881DA3920FBBC77FDEE0083887366DB388E6760CCD89906E064E78097849E1CF786630BD4AE5D91A9875C5FED8B084BE9979CB4F447D414924FA22153F9254DA25E052B9774133527D58B9A51B48ACAC9FA8ACAC0BA49CA29F582A604AD72665483797AE9080DEFEAA5B0FBEFEB6DB679EBD6828A1AE7B042E2FF60822358C69C3B44298E4839025DD68D5D380BE9F031A6AFBE37A59C3E232F199AD55AB3215D04869F0D29ECFECF86544C287E721DE695743800E5C400DF895E7DB66A9F738264DB9E0EB56E6E9BF976D600DD74398BE3C076D359A0087DF1C0455D7EF0E18CF62846D61B3112021D034377D9960725D0375334AA5B728E3D4CB1716667A1C1298A6DE4C86A840E393D04CB775485606544A42EDCF7124FB0741CB146881D826298A92EA1F2B47089ED86C86BD592D0B2E316C6FA5EF0106BCE71880963D8AA892ECCD501102640C1471894360D8DAD8AC5351BA2C66BD58D799B0B5B8EBB1497D88A4DB6F8CE1ABBE4FEDBAB1866B3C6B6609CCD2AE922803698B70B03E56795AE06201E5CF6CD40851393C640B94BB51503AD6B6C07065A57C99B33D0EC88DA75FC85F3EABE9967FDA0BCFD6DBD515D3BB0CD9A3EF6CC3433DF13DA50688123D93CCF17AC123F53C5E10CE4E4E7B398BBBAA28930F039A6F5904DE9EF2AFD50AB194434A226C0D2D05A40F935A004244DA81EC2E5B1BC46E9B817D103368FBB35C2F2B55F80ADD8808C5DBD0EAD10EA2F4D45E3EC74FA287A56588364E49D0E0B151C8541888B57BDE31D94A28BCBCA8AE9E20BF7F1862B1DE383D1A0A016CF55A3A4BC33836B2937CD762DA91CB23E2ED9465A12DC278D96F2CE0CAE256EA3ED4A5238053DDC828D5454DFC2079A6C79A4A3D86D8ABAB1956549F182B1A549A71A5FA33074C9AA925EC54B8C79965B35FD61DE3FE9C8CF302C3B56E41E15D2169C6810A115166A8135483A73A3989E238A1688C579A68E2F9129F756CDF29FB3AC6E9FF220E6FB404ECDFEE6D13BF9F2BEB6D7CACE08C798410F7DE6D1A46174C5F8AB9B1B2CDD0D79285244EEA78197F844EF60E95B67F777D5F659898C30B604F925074AD296E4E6D655DF6960E44931D02015FECBFA03A587D0A93BF73EAB0AD779A47A943C405545D105AD7636703A47A6D760893E62FFB16A45789D79C51353AA00BCA8274625B74102ABD47547ADA79F5431EB35DD11851C932AA450D543CA6A26494DC86AC55A781A8DAA29BA73907347AAE8726D7764451649155A51BD06B64266B1AE3BAA22D1A40AACA8EE8E5D669D888BE81EEF5CDA93CBDA5B5776B8DD6CEFD260BCCE8A38CCD657B9C3AF02558A7B62F15B7A098C97EFA535694F786B5B5316D3D8CC9A3418FA95A776FB5D5F781AAFECF598B52BEDDAE2DE74A5AFC7EB67B3AF6A19D2014F2429B817073DE14037E687ABF64734D2692B23318D5C8DB0B1BFC414FB2346309AFFEA4D3D17B3653C27B846C45DE29866691CE6F1E1D1B1F00E677FDEC45871EC788AC3A9EE614C7DCCB69091459E50643FA248CE8FD8E0DD48092A859E2F89839F27E66F69ABD3348AC1FE4A8B0F8CCBF881B8BF2650711F25D8F85DCEF71C268FBEF990B5A7AF1EBA6BF5F27F5FB2A607C66D0433E6D4381474B9CE08D7DF42F492266BBA81346BBF9078BB13AAF6FC40892A4C88F55F1B2C5C3AC84B835CCA7FFAE8F95F7D4553BE26D80851F1626028BC4154A87B11B00E96F63580039F347D0DD0AFB3EAD701EB88A67D19E092FE60E2BB80EECB50DE72875B8DE24CB48D2529D5736B5EF5464996BBDE9BA4F4EB8D26BA9C62DD036E8334EA352CE38D65200FB63B2A128C07C3DEA569BF7A56F1BE241297291EBBCD1FDE66CA70C3B5D0DF2A53780F72DB14B93ABBCF07DEB6ADE9E2B87B9E54D92FEB77CF8C8D6770ED3EB777DBC6A60BF3EEB9B1F5CAE0DD335BDBD5FEB9634BEBBC85EE3C1F574E2DD2DCC7A862C16DF9B659E01C4EF88B008C20F328B36792EA04AFA6E4D4168625899EA93EB34C642C4D1C89AF44D1CCB65F5FF986DFD8594ED3CC56938FD9C49BAFFF8DBC394D336F4D96E32E3285957986AAECED9675AC2909EA2D6506D77AD29288DEE6B3365EAEBFA544E04194529B3D9A3BE2B793F73B884A869C3A3DF27CE5EB5ED83B2BBFAC08FB77ECAE4A08F63B8B04DBB55DB3A0B924CB20DFBC058972122142738D2972604B3D8BA8BB4436856A16634EDF79A7713B76D3B1C0CE25B94D689850E832F6175E2DE0C59C8026FE6932735DE6F16D98FE64C9105D00315D169BBF253F27AEE71472CF1431210D04F32E7844978D256591DDD54B817413908E405C7D8553748FFDD003B0F896CCD1135E473630BF2BBC42F64B1901D481B40F445DEDE37317AD22E4C71CA36C0F9F60C38EFFFCF1FFCF9177CD60540000, N'6.1.3-40302')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'f236591d-2c84-4784-86de-d1199d79d61a', N'Administrator')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9039a3e1-8f69-47bf-add1-0f21bb45a080', N'Client')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5603779c-0d33-41a0-b24d-87eb4a070af5', N'DEV')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'40f26443-e83a-4957-a5e1-faa00af280e4', N'Nhân viên')
INSERT [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'5603779c-0d33-41a0-b24d-87eb4a070af4', N'Sub Client')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId], [Date]) VALUES (N'1a1d8cbf-5d4e-4eae-9e7f-99eb3a7984f6', N'f236591d-2c84-4784-86de-d1199d79d61a', NULL)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId], [Date]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'5603779c-0d33-41a0-b24d-87eb4a070af5', NULL)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId], [Date]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'9039a3e1-8f69-47bf-add1-0f21bb45a080', NULL)
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId], [Date]) VALUES (N'faa7b14b-07cc-4865-b681-d29f131b444f', N'40f26443-e83a-4957-a5e1-faa00af280e4', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1a1d8cbf-5d4e-4eae-9e7f-99eb3a7984f6', N'bienhynh96@gmail.com', 0, N'AN1qy9P9Yg3riIKkspST0XsdvfSIFM7GL8l037ymtdRwZ3hFtGZb6pzXfM7TYBXl9w==', N'95955eb3-f7eb-494d-82cd-7c8707fa6525', NULL, 0, 0, NULL, 1, 0, N'bienhynh96@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'sieugiaiphap@gmail.com', 0, N'AEgS62hVTcSWksj+ltP1vclnAIPyYf1vqbg44lzPO9Po8BLGqKbhbWfbXu2wzqmC+w==', N'cf9ed5ce-5183-4a0f-8de9-3524d888eb99', NULL, 0, 0, NULL, 1, 0, N'sieugiaiphap@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd2d0701c-5b7b-4e94-85e2-9993fd5215bb', N'sieugiaiphap2@gmail.com', 0, N'ALS+CqcXS0lPsnNdTxqPucZW3fM/qItpDmlpRND68Sm+b/7zrXlAAgXuYBVEPfwdBA==', N'd249a84e-9954-4361-9c4b-4336df0b5cb8', NULL, 0, 0, NULL, 1, 0, N'sieugiaiphap2@gmail.com')
INSERT [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'faa7b14b-07cc-4865-b681-d29f131b444f', N'tunganh2@gmail.com', 0, N'AFn9SGXFyjVv6M5CXIV6yp32phBa5io23bDSfuMl4Yygcrk4O7JG+yUyJui6+dP31g==', N'a12e65ab-1300-437b-8f24-25be9d150ac0', NULL, 0, 0, NULL, 1, 0, N'tunganh2@gmail.com')
INSERT [dbo].[ComputerMasterClient] ([MAC], [UserId], [NameComputer], [IP], [IsDelete], [IsDisable], [DateJoin], [SystemOperator]) VALUES (N'1E3CC9E61921', N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'WIN-3VUL0CU7S27', N'124.158.13.36', 0, 0, CAST(N'2018-05-05' AS Date), N'N/A')
INSERT [dbo].[ComputerMasterClient] ([MAC], [UserId], [NameComputer], [IP], [IsDelete], [IsDisable], [DateJoin], [SystemOperator]) VALUES (N'36461E6A3C90', N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'WIN-3VUL0CU7S27', N'124.158.13.36', 0, 0, CAST(N'2018-05-23' AS Date), N'N/A')
SET IDENTITY_INSERT [dbo].[HistoryLoginSession] ON 

INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 1, CAST(N'2018-05-05T01:21:20.783' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 2, CAST(N'2018-05-05T01:24:35.250' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 3, CAST(N'2018-05-05T01:25:04.000' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 4, CAST(N'2018-05-05T01:25:52.150' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 5, CAST(N'2018-05-05T01:32:24.443' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 6, CAST(N'2018-05-05T01:33:37.763' AS DateTime), NULL, NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 7, CAST(N'2018-05-05T03:23:50.703' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 8, CAST(N'2018-05-05T03:24:46.327' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 9, CAST(N'2018-05-05T03:25:11.603' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 10, CAST(N'2018-05-05T03:25:49.857' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 11, CAST(N'2018-05-05T03:27:37.077' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 12, CAST(N'2018-05-05T03:27:55.317' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 13, CAST(N'2018-05-05T05:38:57.093' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 14, CAST(N'2018-05-05T05:39:39.877' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 15, CAST(N'2018-05-05T05:44:40.770' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 16, CAST(N'2018-05-05T05:47:04.980' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 17, CAST(N'2018-05-05T05:58:19.787' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 18, CAST(N'2018-05-05T06:03:56.660' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 19, CAST(N'2018-05-05T06:04:28.507' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 20, CAST(N'2018-05-05T06:05:00.887' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 21, CAST(N'2018-05-05T06:06:03.590' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 22, CAST(N'2018-05-06T04:57:30.997' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 23, CAST(N'2018-05-06T05:00:48.643' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 24, CAST(N'2018-05-06T05:01:07.083' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 25, CAST(N'2018-05-06T05:01:11.063' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 26, CAST(N'2018-05-06T05:01:22.883' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 27, CAST(N'2018-05-06T05:02:51.163' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 28, CAST(N'2018-05-06T05:17:43.407' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 29, CAST(N'2018-05-06T05:37:46.567' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 30, CAST(N'2018-05-16T07:03:03.047' AS DateTime), N'10.170.16.94', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 31, CAST(N'2018-05-16T07:05:54.997' AS DateTime), N'10.170.16.94', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 32, CAST(N'2018-05-16T07:06:30.437' AS DateTime), N'10.170.16.94', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 33, CAST(N'2018-05-19T07:08:52.000' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 34, CAST(N'2018-05-19T07:14:06.863' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 35, CAST(N'2018-05-19T07:17:25.470' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 36, CAST(N'2018-05-19T08:33:03.447' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 37, CAST(N'2018-05-19T08:36:50.127' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 38, CAST(N'2018-05-19T08:37:30.220' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 39, CAST(N'2018-05-19T08:40:37.657' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 40, CAST(N'2018-05-19T08:41:36.453' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 41, CAST(N'2018-05-19T08:41:40.723' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 42, CAST(N'2018-05-19T08:41:50.277' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 43, CAST(N'2018-05-19T08:42:14.070' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 44, CAST(N'2018-05-19T08:44:28.247' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 45, CAST(N'2018-05-19T08:46:17.167' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 46, CAST(N'2018-05-19T08:46:21.513' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 47, CAST(N'2018-05-19T11:23:35.330' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 48, CAST(N'2018-05-19T11:24:44.990' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 49, CAST(N'2018-05-19T11:36:09.860' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 50, CAST(N'2018-05-23T10:21:43.460' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 51, CAST(N'2018-05-23T10:22:10.747' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 52, CAST(N'2018-05-23T22:40:34.333' AS DateTime), N'124.158.13.36', NULL, NULL)
INSERT [dbo].[HistoryLoginSession] ([UserId], [Id], [TimeStartLogin], [IPAddress], [MacAddress], [NameMachine]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', 53, CAST(N'2018-05-25T10:44:06.697' AS DateTime), N'124.158.13.36', NULL, NULL)
SET IDENTITY_INSERT [dbo].[HistoryLoginSession] OFF
INSERT [dbo].[Licence] ([Id], [LicenceKey], [IsActive], [NumberDevicesLiveActive], [MaxNumberDevices], [Price], [DateCreate], [UserIdCreate]) VALUES (N'13124', N'12345-12345-12345-12345-12345', 1, 1, 1, 0.0000, CAST(N'2018-05-05' AS Date), N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9')
INSERT [dbo].[Licence] ([Id], [LicenceKey], [IsActive], [NumberDevicesLiveActive], [MaxNumberDevices], [Price], [DateCreate], [UserIdCreate]) VALUES (N'21314', N'GJKSA-HSAAK-QTYWU-JGSJK-KJSAD', 1, 0, 5, 1000.0000, CAST(N'2018-05-04' AS Date), N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9')
INSERT [dbo].[List_Game_Disk] ([Id], [NameGame], [URLExecute], [IconUrL], [IcoUrl], [IconImage], [DateScan], [Size], [Description], [Version], [IsDelete], [CategoryGames]) VALUES (N'SGP03214', N'LIÊN MINH HUYỀN THOẠI', N'C:\Program Files (x86)\Google\Chrome\Application\chrome.exe', N'C:\SGP\IMG\ico\SGP03214.jpg', NULL, NULL, CAST(N'2018-04-16' AS Date), 4, N'Tựa game hot nhất mọi thời đại. Nhập 
vai game chiến thuật đỉnh cao', N'1         ', 0, NULL)
INSERT [dbo].[List_Game_Disk] ([Id], [NameGame], [URLExecute], [IconUrL], [IcoUrl], [IconImage], [DateScan], [Size], [Description], [Version], [IsDelete], [CategoryGames]) VALUES (N'SGP03215', N'THE WAR', N'/bâc/sgp_lol_go.exe', N'C:\SGP\IMG\ico\SGP03215.png', NULL, NULL, CAST(N'2018-04-16' AS Date), 0, N'Thế chiến thứ 2 trong lịch sử sắp trở lại với trần thế', NULL, 0, NULL)
INSERT [dbo].[List_Game_Disk] ([Id], [NameGame], [URLExecute], [IconUrL], [IcoUrl], [IconImage], [DateScan], [Size], [Description], [Version], [IsDelete], [CategoryGames]) VALUES (N'SGP03216', N'GTA 5', N'/bâc/sgp_lol_go.exe', N'C:\SGP\IMG\ico\SGP03216.jpg', N'C:\SGP\IMG\icons8_Information_96px.png', NULL, CAST(N'2018-04-16' AS Date), 6, N'Siêu quậy trong một thế giới ảo, game cực kì mượt mà với hiệu ứng 3D như thật', NULL, 0, NULL)
SET IDENTITY_INSERT [dbo].[Menu_Type] ON 

INSERT [dbo].[Menu_Type] ([Id], [Name]) VALUES (1, N'Game All')
INSERT [dbo].[Menu_Type] ([Id], [Name]) VALUES (2, N'Game được nhiêu người chơi')
INSERT [dbo].[Menu_Type] ([Id], [Name]) VALUES (3, N'Game Hot')
INSERT [dbo].[Menu_Type] ([Id], [Name]) VALUES (4, N'Quảng cáo')
INSERT [dbo].[Menu_Type] ([Id], [Name]) VALUES (5, N'Game Online')
INSERT [dbo].[Menu_Type] ([Id], [Name]) VALUES (6, N'Game Offline')
SET IDENTITY_INSERT [dbo].[Menu_Type] OFF
INSERT [dbo].[User_Game_Owner] ([UserId], [GameId], [IsShowOnMenu], [IsRemoveOnDisk], [IsGameHot], [URLDiskGame], [IconUrlCustom], [IcoUrlCustom], [SumNumberPlay], [NumberPlayInDay]) VALUES (N'1a1d8cbf-5d4e-4eae-9e7f-99eb3a7984f6', N'SGP03214', 0, 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User_Game_Owner] ([UserId], [GameId], [IsShowOnMenu], [IsRemoveOnDisk], [IsGameHot], [URLDiskGame], [IconUrlCustom], [IcoUrlCustom], [SumNumberPlay], [NumberPlayInDay]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'SGP03214', 0, 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User_Game_Owner] ([UserId], [GameId], [IsShowOnMenu], [IsRemoveOnDisk], [IsGameHot], [URLDiskGame], [IconUrlCustom], [IcoUrlCustom], [SumNumberPlay], [NumberPlayInDay]) VALUES (N'd2d0701c-5b7b-4e94-85e2-9993fd5215bb', N'SGP03214', 0, 0, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[User_Licence] ([Userid], [LicenceId], [DateStart], [DateEnd], [IsActive], [IsLive], [DateInput], [MACMasterId]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'13124', CAST(N'2018-05-05' AS Date), CAST(N'2019-05-05' AS Date), 1, 1, CAST(N'2018-05-05' AS Date), N'36461E6A3C90')
INSERT [dbo].[User_Licence] ([Userid], [LicenceId], [DateStart], [DateEnd], [IsActive], [IsLive], [DateInput], [MACMasterId]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'21314', CAST(N'2018-05-19' AS Date), CAST(N'2019-05-19' AS Date), 1, 1, CAST(N'2018-05-19' AS Date), N'1E3CC9E61921')
INSERT [dbo].[UserProfile] ([UserId], [FirstName], [LastName], [NetName], [Address], [NumberPhone], [DateCreate], [IsDelete], [IsDisable], [LogoUrl]) VALUES (N'1a1d8cbf-5d4e-4eae-9e7f-99eb3a7984f6', N'Huỳnh Cao', N'Biên', N'HCBBOOK NET', N'Quận 9', N'0961481095', CAST(N'2018-04-12' AS Date), 0, 0, NULL)
INSERT [dbo].[UserProfile] ([UserId], [FirstName], [LastName], [NetName], [Address], [NumberPhone], [DateCreate], [IsDelete], [IsDisable], [LogoUrl]) VALUES (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9', N'Bùi Quang ', N'Được', N'SGP NET', N'Quận 3', NULL, CAST(N'2018-04-12' AS Date), 0, 0, NULL)
INSERT [dbo].[UserProfile] ([UserId], [FirstName], [LastName], [NetName], [Address], [NumberPhone], [DateCreate], [IsDelete], [IsDisable], [LogoUrl]) VALUES (N'd2d0701c-5b7b-4e94-85e2-9993fd5215bb', N'', N'', N'SGP NET', N'', N'', CAST(N'2018-04-12' AS Date), 0, 0, N'')
INSERT [dbo].[UserProfile] ([UserId], [FirstName], [LastName], [NetName], [Address], [NumberPhone], [DateCreate], [IsDelete], [IsDisable], [LogoUrl]) VALUES (N'faa7b14b-07cc-4865-b681-d29f131b444f', NULL, NULL, N'SGP NET', NULL, NULL, CAST(N'2018-04-12' AS Date), 0, 0, NULL)
SET IDENTITY_INSERT [dbo].[VersionHistory] ON 

INSERT [dbo].[VersionHistory] ([Id], [Version], [IsUpdateAvailable], [Mandatory], [InstallerArgs], [Checksum], [HashingAlgorithm], [SoftName], [DateChange], [ChangeLog]) VALUES (1, N'1.0.0.0', 0, 0, NULL, NULL, N'MD5', N'SGPMGC', CAST(N'2018-05-24' AS Date), NULL)
INSERT [dbo].[VersionHistory] ([Id], [Version], [IsUpdateAvailable], [Mandatory], [InstallerArgs], [Checksum], [HashingAlgorithm], [SoftName], [DateChange], [ChangeLog]) VALUES (2, N'1.2.0.1', 0, 0, NULL, NULL, N'MD5', N'SGPMGC', CAST(N'2018-05-30' AS Date), N'PHA+LUZpeCBidXg6PC9wPg0KDQo8cD4rVGgmZWNpcmM7bSBHYW1lPC9wPg0KDQo8cD4rU2NhbiBnYW1lPC9wPg0KDQo8cD4rQyZhZ3JhdmU7aSDEkeG6t3QgY+G6pXUgaCZpZ3JhdmU7bmggU3ViY2xpZW50IFNHUE1HPC9wPg0KDQo8cD4tTW9kdWxlIFVwZGF0ZSBuZXcgdmVyc2lvbiBTR1BNR0MgYW5kIFNHUE1HPC9wPg0K')
SET IDENTITY_INSERT [dbo].[VersionHistory] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 30/05/2018 5:49:12 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 30/05/2018 5:49:12 CH ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 30/05/2018 5:49:12 CH ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_RoleId]    Script Date: 30/05/2018 5:49:12 CH ******/
CREATE NONCLUSTERED INDEX [IX_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_UserId]    Script Date: 30/05/2018 5:49:12 CH ******/
CREATE NONCLUSTERED INDEX [IX_UserId] ON [dbo].[AspNetUserRoles]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 30/05/2018 5:49:12 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Licence]    Script Date: 30/05/2018 5:49:12 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_Licence] ON [dbo].[Licence]
(
	[LicenceKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_User_Licence]    Script Date: 30/05/2018 5:49:12 CH ******/
CREATE UNIQUE NONCLUSTERED INDEX [IX_User_Licence] ON [dbo].[User_Licence]
(
	[LicenceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ComputerMasterClient] ADD  CONSTRAINT [DF_ComputerMasterClient_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[ComputerMasterClient] ADD  CONSTRAINT [DF_ComputerMasterClient_IsDisable]  DEFAULT ((0)) FOR [IsDisable]
GO
ALTER TABLE [dbo].[ComputerSubClient] ADD  CONSTRAINT [DF_ComputerSubClient_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[ComputerSubClient] ADD  CONSTRAINT [DF_ComputerSubClient_IsDisable]  DEFAULT ((0)) FOR [IsDisable]
GO
ALTER TABLE [dbo].[HistoryLoginSession] ADD  CONSTRAINT [DF_HistoryLoginSession_TimeStartLogin]  DEFAULT (getdate()) FOR [TimeStartLogin]
GO
ALTER TABLE [dbo].[HistoryLoginSession] ADD  CONSTRAINT [DF_HistoryLoginSession_IPAddress]  DEFAULT (N'N/A') FOR [IPAddress]
GO
ALTER TABLE [dbo].[HistoryLoginSession] ADD  CONSTRAINT [DF_HistoryLoginSession_MacAddress]  DEFAULT (N'N/A') FOR [MacAddress]
GO
ALTER TABLE [dbo].[HistoryLoginSession] ADD  CONSTRAINT [DF_HistoryLoginSession_NameMachine]  DEFAULT (N'N/A') FOR [NameMachine]
GO
ALTER TABLE [dbo].[Licence] ADD  CONSTRAINT [DF_Licence_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[Licence] ADD  CONSTRAINT [DF_Licence_NumberDevicesLiveActive]  DEFAULT ((0)) FOR [NumberDevicesLiveActive]
GO
ALTER TABLE [dbo].[Licence] ADD  CONSTRAINT [DF_Licence_MaxNumberDevices]  DEFAULT ((1)) FOR [MaxNumberDevices]
GO
ALTER TABLE [dbo].[Licence] ADD  CONSTRAINT [DF_Licence_Price]  DEFAULT ((0)) FOR [Price]
GO
ALTER TABLE [dbo].[Licence] ADD  CONSTRAINT [DF_Licence_DateCreate]  DEFAULT (getdate()) FOR [DateCreate]
GO
ALTER TABLE [dbo].[Licence] ADD  CONSTRAINT [DF_Licence_UserIdCreate]  DEFAULT (N'2af0b772-b5f1-4a9c-ad66-aae0bf7fdfa9') FOR [UserIdCreate]
GO
ALTER TABLE [dbo].[List_Game_Disk] ADD  CONSTRAINT [DF_List_Game_Disk_URLExecute]  DEFAULT (N'C:\SGP\IMG\Notfound.jpg') FOR [URLExecute]
GO
ALTER TABLE [dbo].[List_Game_Disk] ADD  CONSTRAINT [DF_List_Game_Disk_IconUrL]  DEFAULT (N'C:\SGP\IMG\icons8_Information_96px.png') FOR [IconUrL]
GO
ALTER TABLE [dbo].[List_Game_Disk] ADD  CONSTRAINT [DF_List_Game_Disk_IcoUrl]  DEFAULT (N'C:\SGP\IMG\icons8_Information_96px.png') FOR [IcoUrl]
GO
ALTER TABLE [dbo].[List_Game_Disk] ADD  CONSTRAINT [DF_List_Game_Disk_DateScan]  DEFAULT (getdate()) FOR [DateScan]
GO
ALTER TABLE [dbo].[List_Game_Disk] ADD  CONSTRAINT [DF_List_Game_Disk_Size]  DEFAULT ((0)) FOR [Size]
GO
ALTER TABLE [dbo].[List_Game_Disk] ADD  CONSTRAINT [DF_List_Game_Disk_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[User_Control_Menu] ADD  CONSTRAINT [DF_User_Control_Menu_MenuId]  DEFAULT ((3)) FOR [MenuId]
GO
ALTER TABLE [dbo].[User_Control_Menu] ADD  CONSTRAINT [DF_User_Control_Menu_IsHidden]  DEFAULT ((0)) FOR [IsHidden]
GO
ALTER TABLE [dbo].[User_Game_Owner] ADD  CONSTRAINT [DF_User_Game_Owner_IsShowOnMenu]  DEFAULT ((1)) FOR [IsShowOnMenu]
GO
ALTER TABLE [dbo].[User_Game_Owner] ADD  CONSTRAINT [DF_User_Game_Owner_IsRemoveOnDisk]  DEFAULT ((0)) FOR [IsRemoveOnDisk]
GO
ALTER TABLE [dbo].[User_Game_Owner] ADD  CONSTRAINT [DF_User_Game_Owner_IsGameHot]  DEFAULT ((0)) FOR [IsGameHot]
GO
ALTER TABLE [dbo].[User_Game_Owner] ADD  CONSTRAINT [DF_User_Game_Owner_SumNumberPlay]  DEFAULT ((0)) FOR [SumNumberPlay]
GO
ALTER TABLE [dbo].[User_Licence] ADD  CONSTRAINT [DF_User_Licence_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO
ALTER TABLE [dbo].[User_Licence] ADD  CONSTRAINT [DF_User_Licence_IsLive]  DEFAULT ((1)) FOR [IsLive]
GO
ALTER TABLE [dbo].[User_Licence] ADD  CONSTRAINT [DF_User_Licence_DateInput]  DEFAULT (getdate()) FOR [DateInput]
GO
ALTER TABLE [dbo].[UserProfile] ADD  CONSTRAINT [DF_UserProfile_NetName]  DEFAULT (N'SGP NET') FOR [NetName]
GO
ALTER TABLE [dbo].[UserProfile] ADD  CONSTRAINT [DF_UserProfile_DateCreate]  DEFAULT (getdate()) FOR [DateCreate]
GO
ALTER TABLE [dbo].[UserProfile] ADD  CONSTRAINT [DF_UserProfile_IsDelete]  DEFAULT ((0)) FOR [IsDelete]
GO
ALTER TABLE [dbo].[UserProfile] ADD  CONSTRAINT [DF_UserProfile_IsDisable]  DEFAULT ((0)) FOR [IsDisable]
GO
ALTER TABLE [dbo].[VersionHistory] ADD  CONSTRAINT [DF_VersionHistory_IsNew]  DEFAULT ((1)) FOR [IsUpdateAvailable]
GO
ALTER TABLE [dbo].[VersionHistory] ADD  CONSTRAINT [DF_VersionHistory_Mandatory]  DEFAULT ((0)) FOR [Mandatory]
GO
ALTER TABLE [dbo].[VersionHistory] ADD  CONSTRAINT [DF_VersionHistory_DateChange]  DEFAULT (getdate()) FOR [DateChange]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[ComputerMasterClient]  WITH CHECK ADD  CONSTRAINT [FK_ComputerMasterClient_UserProfile] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[ComputerMasterClient] CHECK CONSTRAINT [FK_ComputerMasterClient_UserProfile]
GO
ALTER TABLE [dbo].[ComputerSubClient]  WITH CHECK ADD  CONSTRAINT [FK_ComputerSubClient_ComputerMasterClient] FOREIGN KEY([MacIdMaster])
REFERENCES [dbo].[ComputerMasterClient] ([MAC])
GO
ALTER TABLE [dbo].[ComputerSubClient] CHECK CONSTRAINT [FK_ComputerSubClient_ComputerMasterClient]
GO
ALTER TABLE [dbo].[HistoryLoginSession]  WITH CHECK ADD  CONSTRAINT [FK_HistoryLoginSession_UserProfile] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[HistoryLoginSession] CHECK CONSTRAINT [FK_HistoryLoginSession_UserProfile]
GO
ALTER TABLE [dbo].[Licence]  WITH CHECK ADD  CONSTRAINT [FK_Licence_UserProfile] FOREIGN KEY([UserIdCreate])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[Licence] CHECK CONSTRAINT [FK_Licence_UserProfile]
GO
ALTER TABLE [dbo].[User_Control_Menu]  WITH CHECK ADD  CONSTRAINT [FK_User_Control_Menu_Menu_Type] FOREIGN KEY([MenuId])
REFERENCES [dbo].[Menu_Type] ([Id])
GO
ALTER TABLE [dbo].[User_Control_Menu] CHECK CONSTRAINT [FK_User_Control_Menu_Menu_Type]
GO
ALTER TABLE [dbo].[User_Game_Owner]  WITH CHECK ADD  CONSTRAINT [FK_User_Game_Owner_List_Game_Disk] FOREIGN KEY([GameId])
REFERENCES [dbo].[List_Game_Disk] ([Id])
GO
ALTER TABLE [dbo].[User_Game_Owner] CHECK CONSTRAINT [FK_User_Game_Owner_List_Game_Disk]
GO
ALTER TABLE [dbo].[User_Game_Owner]  WITH CHECK ADD  CONSTRAINT [FK_User_Game_Owner_UserProfile] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[User_Game_Owner] CHECK CONSTRAINT [FK_User_Game_Owner_UserProfile]
GO
ALTER TABLE [dbo].[User_Licence]  WITH CHECK ADD  CONSTRAINT [FK_User_Licence_ComputerMasterClient] FOREIGN KEY([MACMasterId])
REFERENCES [dbo].[ComputerMasterClient] ([MAC])
GO
ALTER TABLE [dbo].[User_Licence] CHECK CONSTRAINT [FK_User_Licence_ComputerMasterClient]
GO
ALTER TABLE [dbo].[User_Licence]  WITH CHECK ADD  CONSTRAINT [FK_User_Licence_Licence] FOREIGN KEY([LicenceId])
REFERENCES [dbo].[Licence] ([Id])
GO
ALTER TABLE [dbo].[User_Licence] CHECK CONSTRAINT [FK_User_Licence_Licence]
GO
ALTER TABLE [dbo].[User_Licence]  WITH CHECK ADD  CONSTRAINT [FK_User_Licence_UserProfile] FOREIGN KEY([Userid])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[User_Licence] CHECK CONSTRAINT [FK_User_Licence_UserProfile]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ẩn máy này trên GUI
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ComputerMasterClient', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vô hiệu hóa menu trên toàn bộ máy trạm này' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ComputerMasterClient', @level2type=N'COLUMN',@level2name=N'IsDisable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Xóa hiển thị trên GUI' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ComputerSubClient', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vô hiệu hóa menu trên máy con này' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'ComputerSubClient', @level2type=N'COLUMN',@level2name=N'IsDisable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Trạng thái còn sống của licence. 
true là còn sống, false là không còn sống.
Nếu Licence còn sống thì các máy chạy licence sẽ còn quyền điều khiển menu.
Ngược lại chết thì một số tính năng điều khiển của khách hàng chạy licence này sẽ bị vo hiệu hóa.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Licence', @level2type=N'COLUMN',@level2name=N'IsActive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tổng số máy đang sử dụng licence không tính máy bị chết' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Licence', @level2type=N'COLUMN',@level2name=N'NumberDevicesLiveActive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Số máy tối đa có thể dùng cùng một licence' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Licence', @level2type=N'COLUMN',@level2name=N'MaxNumberDevices'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Giá trị của licence này, tính bằng tiền việt nam đồng.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Licence', @level2type=N'COLUMN',@level2name=N'Price'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Đánh dấu là xóa: true xóa, false không xóa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'List_Game_Disk', @level2type=N'COLUMN',@level2name=N'IsDelete'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'mỗi category game ngan cach nhau bởi dáu ;' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'List_Game_Disk', @level2type=N'COLUMN',@level2name=N'CategoryGames'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Bảng Menu type là loại menu này là gì:
Menu Game mới
Menu game hot
Menu all
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Menu_Type'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ẩn menu hay không?
Có là true.
Không là false.
Nếu true thì game này sẽ bị ẩn đi.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Control_Menu', @level2type=N'COLUMN',@level2name=N'IsHidden'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ẩn hiện game này trên giao diên menu: true ẩn, false hiện' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Game_Owner', @level2type=N'COLUMN',@level2name=N'IsShowOnMenu'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Xóa game khỏi Đĩa' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Game_Owner', @level2type=N'COLUMN',@level2name=N'IsRemoveOnDisk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'1 laf game hot,0 la game khong hot' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Game_Owner', @level2type=N'COLUMN',@level2name=N'IsGameHot'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Duowngf dan de dia game' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Game_Owner', @level2type=N'COLUMN',@level2name=N'URLDiskGame'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Icon do nguoi dung tu cap nhat' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Game_Owner', @level2type=N'COLUMN',@level2name=N'IconUrlCustom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Icon do nguoi dung tu cap nhat Anh nho' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Game_Owner', @level2type=N'COLUMN',@level2name=N'IcoUrlCustom'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày bắt đầu mở licence' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Licence', @level2type=N'COLUMN',@level2name=N'DateStart'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày hết hạn' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Licence', @level2type=N'COLUMN',@level2name=N'DateEnd'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Trang thai Key bi vo hieu hoa hay khong
1 la hd binh thuong
0 la bi vo hieu hoa , tat ca tinh nang cai boi key nay se bi vo hieu hoa voi may do' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Licence', @level2type=N'COLUMN',@level2name=N'IsActive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Trạng thái sống của máy với licence này. nghĩa là máy đó có đang sử dụng licence này hay không, hoặc card mạng của máy đó bị die thị sẽ đặt giá trị là false. 
Còn đang sử dụng thì true.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Licence', @level2type=N'COLUMN',@level2name=N'IsLive'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ngày nhập licence
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'User_Licence', @level2type=N'COLUMN',@level2name=N'DateInput'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Ten tiem net' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserProfile', @level2type=N'COLUMN',@level2name=N'NetName'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vô hiệu hóa tài khoản.
true là vô hiệu hóa, false là không vô hiệu hóa.
Tài khoản nào bị vô hiệu hóa thì sẽ không có quyền đăng nhập vào hệ thống.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserProfile', @level2type=N'COLUMN',@level2name=N'IsDisable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Logo tiệm nét của khách hàng' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'UserProfile', @level2type=N'COLUMN',@level2name=N'LogoUrl'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Version' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VersionHistory', @level2type=N'COLUMN',@level2name=N'Version'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'If new update is available then returns true otherwise false.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VersionHistory', @level2type=N'COLUMN',@level2name=N'IsUpdateAvailable'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Shows if the update is required or optional.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VersionHistory', @level2type=N'COLUMN',@level2name=N'Mandatory'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Command line arguments used by Installer.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VersionHistory', @level2type=N'COLUMN',@level2name=N'InstallerArgs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Checksum of the update file.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VersionHistory', @level2type=N'COLUMN',@level2name=N'Checksum'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Hash algorithm that generated the checksum provided in the XML file.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VersionHistory', @level2type=N'COLUMN',@level2name=N'HashingAlgorithm'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'name Soft need update: SGPMGC, SGPMC' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'VersionHistory', @level2type=N'COLUMN',@level2name=N'SoftName'
GO
USE [master]
GO
ALTER DATABASE [GAME_MENU_CONTROL] SET  READ_WRITE 
GO
