USE [master]
GO
/****** Object:  Database [Funeral_Service_db]    Script Date: 06.05.2022 14:05:09 ******/
CREATE DATABASE [Funeral_Service_db]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Funeral_Service_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL_001\MSSQL\DATA\Funeral_Service_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'Funeral_Service_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQL_001\MSSQL\DATA\Funeral_Service_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Funeral_Service_db] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Funeral_Service_db].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Funeral_Service_db] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET ARITHABORT OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Funeral_Service_db] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Funeral_Service_db] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Funeral_Service_db] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Funeral_Service_db] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Funeral_Service_db] SET  MULTI_USER 
GO
ALTER DATABASE [Funeral_Service_db] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Funeral_Service_db] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Funeral_Service_db] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Funeral_Service_db] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Funeral_Service_db] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Funeral_Service_db] SET QUERY_STORE = OFF
GO
USE [Funeral_Service_db]
GO
/****** Object:  Table [dbo].[_User]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[_User](
	[ID_User] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
	[User_Image] [image] NULL,
	[Telephone] [varchar](50) NULL,
	[ID_Role] [int] NULL,
 CONSTRAINT [PK__User] PRIMARY KEY CLUSTERED 
(
	[ID_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Basket]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Basket](
	[ID_Basket] [int] IDENTITY(1,1) NOT NULL,
	[Count] [int] NULL,
	[Date] [datetime] NULL,
	[ID_User] [int] NULL,
	[Done] [bit] NULL,
 CONSTRAINT [PK_Basket] PRIMARY KEY CLUSTERED 
(
	[ID_Basket] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Graveyard]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Graveyard](
	[ID_Graveyard] [int] IDENTITY(1,1) NOT NULL,
	[Graveyard_Name] [varchar](50) NULL,
	[Graveyard_Location] [varchar](50) NULL,
	[ID_Service] [int] NULL,
	[ID_Role] [int] NULL,
 CONSTRAINT [PK_Graveyard] PRIMARY KEY CLUSTERED 
(
	[ID_Graveyard] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment](
	[ID_Payment] [int] IDENTITY(1,1) NOT NULL,
	[Date_Payment] [datetime] NULL,
	[Card] [varchar](50) NULL,
	[Name_Payment] [varchar](50) NULL,
	[PaymentType_Name] [varchar](50) NULL,
	[ID_User] [int] NULL,
	[Paid] [bit] NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[ID_Payment] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentProduct]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentProduct](
	[ID_PaymentProduct] [int] IDENTITY(1,1) NOT NULL,
	[Date_PaymentProduct] [datetime] NULL,
	[Card] [varchar](50) NULL,
	[Name_PaymentProduct] [varchar](50) NULL,
	[PaymentType_Name] [varchar](50) NULL,
	[Paid] [bit] NULL,
	[ID_User] [int] NULL,
 CONSTRAINT [PK_PaymentProduct] PRIMARY KEY CLUSTERED 
(
	[ID_PaymentProduct] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PaymentType]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentType](
	[ID_PaymentType] [int] IDENTITY(1,1) NOT NULL,
	[Name_PaymentType] [varchar](50) NULL,
	[ID_Role] [int] NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[ID_PaymentType] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[ID_Product] [int] IDENTITY(1,1) NOT NULL,
	[Product_Name] [varchar](50) NULL,
	[Product_Price] [nchar](10) NULL,
	[ID_Role] [int] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[ID_Product] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID_Role] [int] NOT NULL,
	[Role_Name] [varchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID_Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 06.05.2022 14:05:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[ID_Service] [int] NOT NULL,
	[Service_Name] [varchar](50) NULL,
	[Service_Price] [decimal](18, 0) NULL,
	[ID_Role] [int] NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[ID_Service] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[_User]  WITH CHECK ADD  CONSTRAINT [FK__User_Role] FOREIGN KEY([ID_Role])
REFERENCES [dbo].[Role] ([ID_Role])
GO
ALTER TABLE [dbo].[_User] CHECK CONSTRAINT [FK__User_Role]
GO
ALTER TABLE [dbo].[Basket]  WITH CHECK ADD  CONSTRAINT [FK_Basket__User] FOREIGN KEY([ID_User])
REFERENCES [dbo].[_User] ([ID_User])
GO
ALTER TABLE [dbo].[Basket] CHECK CONSTRAINT [FK_Basket__User]
GO
ALTER TABLE [dbo].[Graveyard]  WITH CHECK ADD  CONSTRAINT [FK_Graveyard_Role] FOREIGN KEY([ID_Role])
REFERENCES [dbo].[Role] ([ID_Role])
GO
ALTER TABLE [dbo].[Graveyard] CHECK CONSTRAINT [FK_Graveyard_Role]
GO
ALTER TABLE [dbo].[Graveyard]  WITH CHECK ADD  CONSTRAINT [FK_Graveyard_Service] FOREIGN KEY([ID_Service])
REFERENCES [dbo].[Service] ([ID_Service])
GO
ALTER TABLE [dbo].[Graveyard] CHECK CONSTRAINT [FK_Graveyard_Service]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment__User] FOREIGN KEY([ID_User])
REFERENCES [dbo].[_User] ([ID_User])
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment__User]
GO
ALTER TABLE [dbo].[PaymentProduct]  WITH CHECK ADD  CONSTRAINT [FK_PaymentProduct__User] FOREIGN KEY([ID_User])
REFERENCES [dbo].[_User] ([ID_User])
GO
ALTER TABLE [dbo].[PaymentProduct] CHECK CONSTRAINT [FK_PaymentProduct__User]
GO
ALTER TABLE [dbo].[PaymentType]  WITH CHECK ADD  CONSTRAINT [FK_PaymentType_Role] FOREIGN KEY([ID_Role])
REFERENCES [dbo].[Role] ([ID_Role])
GO
ALTER TABLE [dbo].[PaymentType] CHECK CONSTRAINT [FK_PaymentType_Role]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Role] FOREIGN KEY([ID_Role])
REFERENCES [dbo].[Role] ([ID_Role])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Role]
GO
ALTER TABLE [dbo].[Service]  WITH CHECK ADD  CONSTRAINT [FK_Service_Role] FOREIGN KEY([ID_Role])
REFERENCES [dbo].[Role] ([ID_Role])
GO
ALTER TABLE [dbo].[Service] CHECK CONSTRAINT [FK_Service_Role]
GO
USE [master]
GO
ALTER DATABASE [Funeral_Service_db] SET  READ_WRITE 
GO
