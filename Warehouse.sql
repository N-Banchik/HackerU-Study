USE [master]
GO
/****** Object:  Database [FactoryDB]    Script Date: 06/01/2022 12:49:27 ******/
CREATE DATABASE [FactoryDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FactoryDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FactoryDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'FactoryDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\FactoryDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [FactoryDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FactoryDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FactoryDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FactoryDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FactoryDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FactoryDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FactoryDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [FactoryDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [FactoryDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FactoryDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FactoryDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FactoryDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FactoryDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FactoryDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FactoryDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FactoryDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FactoryDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [FactoryDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FactoryDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FactoryDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FactoryDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FactoryDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FactoryDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [FactoryDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FactoryDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [FactoryDB] SET  MULTI_USER 
GO
ALTER DATABASE [FactoryDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FactoryDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FactoryDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FactoryDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [FactoryDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [FactoryDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [FactoryDB] SET QUERY_STORE = OFF
GO
USE [FactoryDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Address_Costumers]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Address_Costumers](
	[Address_ID] [int] IDENTITY(1,1) NOT NULL,
	[Costumer_ID] [int] NOT NULL,
	[Street Name] [nvarchar](max) NOT NULL,
	[House Number] [int] NOT NULL,
	[Apartment Number] [int] NOT NULL,
	[Zipcode] [int] NOT NULL,
	[City] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Address_Costumers] PRIMARY KEY CLUSTERED 
(
	[Address_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[address_Employees]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[address_Employees](
	[Address_ID] [int] IDENTITY(1,1) NOT NULL,
	[Employee Id] [int] NOT NULL,
	[Street Name] [nvarchar](max) NOT NULL,
	[House Number] [int] NOT NULL,
	[Apartment Number] [int] NOT NULL,
	[Zipcode] [int] NOT NULL,
	[City] [nvarchar](max) NOT NULL,
 CONSTRAINT [Address Id] PRIMARY KEY CLUSTERED 
(
	[Address_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brands]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brands](
	[Brand Id] [int] IDENTITY(1,1) NOT NULL,
	[Brand Name] [nvarchar](25) NULL,
	[Manufacturing Country] [nvarchar](25) NULL,
 CONSTRAINT [PK_Brands] PRIMARY KEY CLUSTERED 
(
	[Brand Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[Category_ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
 CONSTRAINT [Category ID] PRIMARY KEY CLUSTERED 
(
	[Category_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Costumers]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Costumers](
	[Costumer Id] [int] IDENTITY(1,1) NOT NULL,
	[First Name] [nvarchar](25) NOT NULL,
	[Last Name] [nvarchar](25) NOT NULL,
	[Birthdate] [smalldatetime] NOT NULL,
	[Email] [nvarchar](25) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Phone number] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Costumers] PRIMARY KEY CLUSTERED 
(
	[Costumer Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EDIs]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EDIs](
	[EDI_Id] [int] IDENTITY(1000,1) NOT NULL,
	[Date] [datetime2](7) NOT NULL,
	[Total_Weight] [float] NOT NULL,
	[Total_Items] [int] NOT NULL,
	[Approved_By] [int] NULL,
 CONSTRAINT [PK_EDIs] PRIMARY KEY CLUSTERED 
(
	[EDI_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EIs]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EIs](
	[Item_Id] [int] NOT NULL,
	[EDI_Id] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[QuantityArrived] [int] NULL,
 CONSTRAINT [PK_EIs] PRIMARY KEY CLUSTERED 
(
	[EDI_Id] ASC,
	[Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[ID] [int] NOT NULL,
	[First Name] [nvarchar](25) NOT NULL,
	[Last Name] [nvarchar](25) NOT NULL,
	[Birthdate] [smalldatetime] NOT NULL,
	[Hire Date] [smalldatetime] NOT NULL,
	[Phone number] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](max) NULL,
	[Is_Manager] [smallint] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Item Id] [int] IDENTITY(1,1) NOT NULL,
	[Item Name] [nvarchar](max) NOT NULL,
	[Category Id] [int] NOT NULL,
	[Brand Id] [int] NOT NULL,
	[Weight] [float] NOT NULL,
	[Units In inventory] [int] NOT NULL,
	[Minimum Units In inventory] [int] NOT NULL,
	[Unit Price] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Item Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Shifts]    Script Date: 06/01/2022 12:49:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Shifts](
	[Shift_ID] [int] IDENTITY(1,1) NOT NULL,
	[Employee_ID] [int] NOT NULL,
	[Shift start time] [smalldatetime] NOT NULL,
	[Shift end time] [smalldatetime] NULL,
	[Shift Time] [float] NOT NULL,
 CONSTRAINT [PK_Shifts] PRIMARY KEY CLUSTERED 
(
	[Shift_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20211211131655_Initial_Migration', N'5.0.12')
GO
SET IDENTITY_INSERT [dbo].[Address_Costumers] ON 

INSERT [dbo].[Address_Costumers] ([Address_ID], [Costumer_ID], [Street Name], [House Number], [Apartment Number], [Zipcode], [City]) VALUES (1, 1, N'42-09 47th ave', 50, 3, 444021, N'Sunnyside')
SET IDENTITY_INSERT [dbo].[Address_Costumers] OFF
GO
SET IDENTITY_INSERT [dbo].[address_Employees] ON 

INSERT [dbo].[address_Employees] ([Address_ID], [Employee Id], [Street Name], [House Number], [Apartment Number], [Zipcode], [City]) VALUES (1, 0, N'Dizingof', 224, 3, 123456, N'Tel Aviv')
INSERT [dbo].[address_Employees] ([Address_ID], [Employee Id], [Street Name], [House Number], [Apartment Number], [Zipcode], [City]) VALUES (2, 0, N'Sokolov', 32, 9, 65879541, N'Ramat Hasharon')
SET IDENTITY_INSERT [dbo].[address_Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Brands] ON 

INSERT [dbo].[Brands] ([Brand Id], [Brand Name], [Manufacturing Country]) VALUES (1, N'Nonda', N'China')
INSERT [dbo].[Brands] ([Brand Id], [Brand Name], [Manufacturing Country]) VALUES (2, N'Fair-rari', N'Spain')
INSERT [dbo].[Brands] ([Brand Id], [Brand Name], [Manufacturing Country]) VALUES (3, N'Beta-Juliet', N'USA')
SET IDENTITY_INSERT [dbo].[Brands] OFF
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([Category_ID], [Name], [Description]) VALUES (1, N'Playing-Cards', N'Regular Playing card game')
INSERT [dbo].[Categories] ([Category_ID], [Name], [Description]) VALUES (2, N'Play_Dice', N'Normal play Dice set.')
INSERT [dbo].[Categories] ([Category_ID], [Name], [Description]) VALUES (3, N'Race Tyres', N'F1 Race Tyres')
SET IDENTITY_INSERT [dbo].[Categories] OFF
GO
SET IDENTITY_INSERT [dbo].[Costumers] ON 

INSERT [dbo].[Costumers] ([Costumer Id], [First Name], [Last Name], [Birthdate], [Email], [Password], [Phone number]) VALUES (1, N'Mike', N'Chen', CAST(N'1992-06-17T00:00:00' AS SmallDateTime), N'Mchen@Yahoo.com', N'EADA62F8F90F008DEAD127D430608047C09B725756E73113895258CDAA65E399', N'8457099476')
SET IDENTITY_INSERT [dbo].[Costumers] OFF
GO
SET IDENTITY_INSERT [dbo].[EDIs] ON 

INSERT [dbo].[EDIs] ([EDI_Id], [Date], [Total_Weight], [Total_Items], [Approved_By]) VALUES (1000, CAST(N'2021-12-12T10:04:49.9284321' AS DateTime2), 9.2000000000000011, 5, 2)
INSERT [dbo].[EDIs] ([EDI_Id], [Date], [Total_Weight], [Total_Items], [Approved_By]) VALUES (1001, CAST(N'2021-12-12T11:42:12.4376222' AS DateTime2), 4.4, 2, NULL)
SET IDENTITY_INSERT [dbo].[EDIs] OFF
GO
INSERT [dbo].[EIs] ([Item_Id], [EDI_Id], [Quantity], [QuantityArrived]) VALUES (3, 1000, 3, 3)
INSERT [dbo].[EIs] ([Item_Id], [EDI_Id], [Quantity], [QuantityArrived]) VALUES (4, 1000, 2, 0)
INSERT [dbo].[EIs] ([Item_Id], [EDI_Id], [Quantity], [QuantityArrived]) VALUES (4, 1001, 2, NULL)
GO
INSERT [dbo].[Employees] ([ID], [First Name], [Last Name], [Birthdate], [Hire Date], [Phone number], [Password], [Email], [Is_Manager]) VALUES (1, N'Toto', N'Wolf', CAST(N'1990-03-14T00:00:00' AS SmallDateTime), CAST(N'2021-12-11T15:51:00' AS SmallDateTime), N'05455679823', N'72DE75E92D9A5F8570E75ED2416544A42A5BB8E0D8567701AF910623894E4B99', N'Toto@AMG.com', 1)
INSERT [dbo].[Employees] ([ID], [First Name], [Last Name], [Birthdate], [Hire Date], [Phone number], [Password], [Email], [Is_Manager]) VALUES (2, N'Tom', N' Scott', CAST(N'1988-03-30T00:00:00' AS SmallDateTime), CAST(N'2021-12-12T10:27:00' AS SmallDateTime), N'4498752524', N'47294B75379BBDC1A74FD1D819539290657E1AA30AE71FE41DFAB65CCD254384', N'TScott@aol.com', 0)
GO
SET IDENTITY_INSERT [dbo].[Items] ON 

INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (1, N'Hard compound', 3, 3, 2, 4, 2, 1500.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (2, N'Mideum Compound', 3, 3, 1.8, 6, 6, 1700.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (3, N'Soft Compound', 3, 2, 1.6, 8, 8, 1770.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (4, N'Wet Compound', 3, 1, 2.2, 8, 10, 1250.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (5, N'Plastic Dice set', 2, 2, 0.5, 45, 100, 15.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (6, N'Metal Dice set', 2, 3, 0.7, 10, 15, 25.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (7, N'Special D20 Die', 2, 3, 0.1, 5, 3, 15.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (8, N'Blue Bycicle deck', 1, 1, 0.1, 35, 25, 10.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (9, N'Red Bycicle deck', 1, 2, 0.1, 10, 25, 12.0000)
INSERT [dbo].[Items] ([Item Id], [Item Name], [Category Id], [Brand Id], [Weight], [Units In inventory], [Minimum Units In inventory], [Unit Price]) VALUES (10, N'Crazy Bycicle deck', 1, 1, 0.1, 15, 25, 105.0000)
SET IDENTITY_INSERT [dbo].[Items] OFF
GO
SET IDENTITY_INSERT [dbo].[Shifts] ON 

INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (1, 1, CAST(N'2021-12-11T15:51:00' AS SmallDateTime), CAST(N'2021-12-11T16:07:00' AS SmallDateTime), 0.26759460347222225)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (2, 1, CAST(N'2021-12-12T09:09:00' AS SmallDateTime), CAST(N'2021-12-12T10:04:00' AS SmallDateTime), 0)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (3, 1, CAST(N'2021-12-12T10:04:00' AS SmallDateTime), CAST(N'2021-12-12T10:28:00' AS SmallDateTime), 0.39387320261111114)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (4, 2, CAST(N'2021-12-12T10:33:00' AS SmallDateTime), CAST(N'2021-12-12T10:43:00' AS SmallDateTime), 0.16871816233333331)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (5, 2, CAST(N'2021-12-12T11:06:00' AS SmallDateTime), CAST(N'2021-12-12T11:06:00' AS SmallDateTime), 0.0094714984444444449)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (6, 1, CAST(N'2021-12-12T11:06:00' AS SmallDateTime), CAST(N'2021-12-12T11:07:00' AS SmallDateTime), 0.018955007972222222)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (7, 1, CAST(N'2021-12-12T11:09:00' AS SmallDateTime), CAST(N'2021-12-12T11:17:00' AS SmallDateTime), 0.1272831003888889)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (8, 1, CAST(N'2021-12-12T11:23:00' AS SmallDateTime), CAST(N'2021-12-12T11:24:00' AS SmallDateTime), 0.0057800965555555557)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (11, 1, CAST(N'2021-12-12T11:37:00' AS SmallDateTime), CAST(N'2021-12-12T11:46:00' AS SmallDateTime), 0.15404112669444445)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (12, 1, CAST(N'2021-12-12T15:40:00' AS SmallDateTime), CAST(N'2021-12-12T15:40:00' AS SmallDateTime), 0.00040469680555555555)
INSERT [dbo].[Shifts] ([Shift_ID], [Employee_ID], [Shift start time], [Shift end time], [Shift Time]) VALUES (13, 1, CAST(N'2021-12-12T16:31:00' AS SmallDateTime), CAST(N'2021-12-12T16:39:00' AS SmallDateTime), 0.12187392472222222)
SET IDENTITY_INSERT [dbo].[Shifts] OFF
GO
/****** Object:  Index [IX_Address_Costumers_Costumer_ID]    Script Date: 06/01/2022 12:49:27 ******/
CREATE NONCLUSTERED INDEX [IX_Address_Costumers_Costumer_ID] ON [dbo].[Address_Costumers]
(
	[Costumer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EDIs_Approved_By]    Script Date: 06/01/2022 12:49:27 ******/
CREATE NONCLUSTERED INDEX [IX_EDIs_Approved_By] ON [dbo].[EDIs]
(
	[Approved_By] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_EIs_Item_Id]    Script Date: 06/01/2022 12:49:27 ******/
CREATE NONCLUSTERED INDEX [IX_EIs_Item_Id] ON [dbo].[EIs]
(
	[Item_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Items_Brand Id]    Script Date: 06/01/2022 12:49:27 ******/
CREATE NONCLUSTERED INDEX [IX_Items_Brand Id] ON [dbo].[Items]
(
	[Brand Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Items_Category Id]    Script Date: 06/01/2022 12:49:27 ******/
CREATE NONCLUSTERED INDEX [IX_Items_Category Id] ON [dbo].[Items]
(
	[Category Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Shifts_Employee_ID]    Script Date: 06/01/2022 12:49:27 ******/
CREATE NONCLUSTERED INDEX [IX_Shifts_Employee_ID] ON [dbo].[Shifts]
(
	[Employee_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Address_Costumers]  WITH CHECK ADD  CONSTRAINT [FK_Address_Costumers_Costumers_Costumer_ID] FOREIGN KEY([Costumer_ID])
REFERENCES [dbo].[Costumers] ([Costumer Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Address_Costumers] CHECK CONSTRAINT [FK_Address_Costumers_Costumers_Costumer_ID]
GO
ALTER TABLE [dbo].[EDIs]  WITH CHECK ADD  CONSTRAINT [FK_EDIs_Employees_Approved_By] FOREIGN KEY([Approved_By])
REFERENCES [dbo].[Employees] ([ID])
GO
ALTER TABLE [dbo].[EDIs] CHECK CONSTRAINT [FK_EDIs_Employees_Approved_By]
GO
ALTER TABLE [dbo].[EIs]  WITH CHECK ADD  CONSTRAINT [FK_EIs_EDIs_EDI_Id] FOREIGN KEY([EDI_Id])
REFERENCES [dbo].[EDIs] ([EDI_Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EIs] CHECK CONSTRAINT [FK_EIs_EDIs_EDI_Id]
GO
ALTER TABLE [dbo].[EIs]  WITH CHECK ADD  CONSTRAINT [FK_EIs_Items_Item_Id] FOREIGN KEY([Item_Id])
REFERENCES [dbo].[Items] ([Item Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EIs] CHECK CONSTRAINT [FK_EIs_Items_Item_Id]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_address_Employees_ID] FOREIGN KEY([ID])
REFERENCES [dbo].[address_Employees] ([Address_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_address_Employees_ID]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Brands_Brand Id] FOREIGN KEY([Brand Id])
REFERENCES [dbo].[Brands] ([Brand Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Brands_Brand Id]
GO
ALTER TABLE [dbo].[Items]  WITH CHECK ADD  CONSTRAINT [FK_Items_Categories_Category Id] FOREIGN KEY([Category Id])
REFERENCES [dbo].[Categories] ([Category_ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Items] CHECK CONSTRAINT [FK_Items_Categories_Category Id]
GO
ALTER TABLE [dbo].[Shifts]  WITH CHECK ADD  CONSTRAINT [FK_Shifts_Employees_Employee_ID] FOREIGN KEY([Employee_ID])
REFERENCES [dbo].[Employees] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Shifts] CHECK CONSTRAINT [FK_Shifts_Employees_Employee_ID]
GO
USE [master]
GO
ALTER DATABASE [FactoryDB] SET  READ_WRITE 
GO
