USE [master]
GO
/****** Object:  Database [GestionMatos]    Script Date: 16/04/2024 00:12:24 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'GestionMatos')
BEGIN
CREATE DATABASE [GestionMatos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GestionMatos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GestionMatos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GestionMatos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\GestionMatos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
END
GO
ALTER DATABASE [GestionMatos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionMatos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionMatos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionMatos] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionMatos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionMatos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionMatos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionMatos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionMatos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionMatos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionMatos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionMatos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionMatos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionMatos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionMatos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionMatos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionMatos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionMatos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionMatos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionMatos] SET  MULTI_USER 
GO
ALTER DATABASE [GestionMatos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionMatos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionMatos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionMatos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionMatos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionMatos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestionMatos] SET QUERY_STORE = OFF
GO
USE [GestionMatos]
GO
/****** Object:  Table [dbo].[CLIENT]    Script Date: 16/04/2024 00:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CLIENT]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CLIENT](
	[ID_CLIENT] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Adresse] [varchar](50) NOT NULL,
	[Mail] [varchar](50) NULL,
	[Tel] [varchar](20) NOT NULL,
 CONSTRAINT [CLIENT_PK] PRIMARY KEY CLUSTERED 
(
	[ID_CLIENT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[INTERVENTION]    Script Date: 16/04/2024 00:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[INTERVENTION]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[INTERVENTION](
	[ID_INTER] [int] IDENTITY(1,1) NOT NULL,
	[DATE_INTER] [date] NOT NULL,
	[Commentaire] [text] NULL,
	[Technicien] [varchar](50) NOT NULL,
	[ID_MAT] [int] NOT NULL,
 CONSTRAINT [INTERVENTION_PK] PRIMARY KEY CLUSTERED 
(
	[ID_INTER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[MATERIEL]    Script Date: 16/04/2024 00:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MATERIEL]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MATERIEL](
	[ID_MAT] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[NoSerie] [varchar](50) NOT NULL,
	[Date_install] [date] NOT NULL,
	[MTBF] [int] NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[Marque] [varchar](50) NOT NULL,
	[ID_CLIENT] [int] NOT NULL,
 CONSTRAINT [MATERIEL_PK] PRIMARY KEY CLUSTERED 
(
	[ID_MAT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Utilisateur]    Script Date: 16/04/2024 00:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Utilisateur]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Utilisateur](
	[ID_USER] [int] IDENTITY(1,1) NOT NULL,
	[Login] [varchar](50) NOT NULL,
	[Pwd] [varchar](500) NOT NULL,
 CONSTRAINT [Utilisateur_PK] PRIMARY KEY CLUSTERED 
(
	[ID_USER] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[CLIENT] ON 

INSERT [dbo].[CLIENT] ([ID_CLIENT], [Nom], [Adresse], [Mail], [Tel]) VALUES (2, N'Boulanger', N'88 place Monge 2', N'miam', N'01 54 82 55 11')
INSERT [dbo].[CLIENT] ([ID_CLIENT], [Nom], [Adresse], [Mail], [Tel]) VALUES (19, N'Galeries77', N'', N'gl88@qdoisd,fis.comco', N'')
INSERT [dbo].[CLIENT] ([ID_CLIENT], [Nom], [Adresse], [Mail], [Tel]) VALUES (22, N'Syebel', N'tres loin', N'mail@siebel.com', N'0666666841645715')
INSERT [dbo].[CLIENT] ([ID_CLIENT], [Nom], [Adresse], [Mail], [Tel]) VALUES (24, N'Thibault', N'tibostreet', N'tibo@mail.Com', N'54054050245425')
INSERT [dbo].[CLIENT] ([ID_CLIENT], [Nom], [Adresse], [Mail], [Tel]) VALUES (26, N'Toalfgjg', N'crderic adress', N'bb', N'')
SET IDENTITY_INSERT [dbo].[CLIENT] OFF
GO
SET IDENTITY_INSERT [dbo].[INTERVENTION] ON 

INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (3, CAST(N'2018-11-24' AS Date), N'aaaaaf', N'fffffff', 4)
INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (9, CAST(N'2022-06-22' AS Date), N'le commentazhi qs
qsjgqskjgk', N'tech 754', 4)
INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (10, CAST(N'2029-08-30' AS Date), N'le comment', N'techniien', 1)
INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (12, CAST(N'2008-10-06' AS Date), N'cool alors', N'cest moi', 1)
INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (13, CAST(N'2050-12-23' AS Date), N'loin', N'le techos', 4)
INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (14, CAST(N'2023-04-12' AS Date), N'd', N'qsgq', 20)
INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (15, CAST(N'2023-04-19' AS Date), N'cool alors', N'ouio', 17)
INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (16, CAST(N'2023-04-19' AS Date), N'fdbxc', N'xncxcnx', 19)
INSERT [dbo].[INTERVENTION] ([ID_INTER], [DATE_INTER], [Commentaire], [Technicien], [ID_MAT]) VALUES (17, CAST(N'2023-04-21' AS Date), N'sdhxc', N'xcbxc', 17)
SET IDENTITY_INSERT [dbo].[INTERVENTION] OFF
GO
SET IDENTITY_INSERT [dbo].[MATERIEL] ON 

INSERT [dbo].[MATERIEL] ([ID_MAT], [Nom], [NoSerie], [Date_install], [MTBF], [Type], [Marque], [ID_CLIENT]) VALUES (1, N'Souris G4', N'0540560653', CAST(N'2012-02-13' AS Date), 10, N'SOURIS', N'Logitech', 2)
INSERT [dbo].[MATERIEL] ([ID_MAT], [Nom], [NoSerie], [Date_install], [MTBF], [Type], [Marque], [ID_CLIENT]) VALUES (4, N'UC771447', N'426054', CAST(N'2022-05-11' AS Date), 1, N'UC', N'HP', 2)
INSERT [dbo].[MATERIEL] ([ID_MAT], [Nom], [NoSerie], [Date_install], [MTBF], [Type], [Marque], [ID_CLIENT]) VALUES (17, N'pppp', N'pppp', CAST(N'2005-05-12' AS Date), 20, N'pmp', N'pmp', 22)
INSERT [dbo].[MATERIEL] ([ID_MAT], [Nom], [NoSerie], [Date_install], [MTBF], [Type], [Marque], [ID_CLIENT]) VALUES (19, N'GALOP', N'5178575', CAST(N'2065-04-10' AS Date), 14, N'14', N'fdhdfh', 19)
INSERT [dbo].[MATERIEL] ([ID_MAT], [Nom], [NoSerie], [Date_install], [MTBF], [Type], [Marque], [ID_CLIENT]) VALUES (20, N'printer ter', N'5654896548545', CAST(N'2110-04-11' AS Date), 50, N'oui', N'oui', 19)
SET IDENTITY_INSERT [dbo].[MATERIEL] OFF
GO
SET IDENTITY_INSERT [dbo].[Utilisateur] ON 

INSERT [dbo].[Utilisateur] ([ID_USER], [Login], [Pwd]) VALUES (1, N'admin', N'8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918')
INSERT [dbo].[Utilisateur] ([ID_USER], [Login], [Pwd]) VALUES (2, N'toto', N'd1c7c99c6e2e7b311f51dd9d19161a5832625fb21f35131fba6da62513f0c099')
INSERT [dbo].[Utilisateur] ([ID_USER], [Login], [Pwd]) VALUES (3, N'Fatiba', N'6ff360d3c646fcbf59faad9cb821c676ea4eef8c264edea4047d6b53db99dcb7')
INSERT [dbo].[Utilisateur] ([ID_USER], [Login], [Pwd]) VALUES (4, N'toto01', N'0ebb90813ed4e4bd7b36a1f4ab1cc0842533b10df2550c50f127f9b2e792ed0e')
INSERT [dbo].[Utilisateur] ([ID_USER], [Login], [Pwd]) VALUES (6, N'toto', N'31f7a65e315586ac198bd798b6629ce4903d0899476d5741a9f32e2e521b6a66')
SET IDENTITY_INSERT [dbo].[Utilisateur] OFF
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[INTERVENTION_MATERIEL_FK]') AND parent_object_id = OBJECT_ID(N'[dbo].[INTERVENTION]'))
ALTER TABLE [dbo].[INTERVENTION]  WITH CHECK ADD  CONSTRAINT [INTERVENTION_MATERIEL_FK] FOREIGN KEY([ID_MAT])
REFERENCES [dbo].[MATERIEL] ([ID_MAT])
ON DELETE CASCADE
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[INTERVENTION_MATERIEL_FK]') AND parent_object_id = OBJECT_ID(N'[dbo].[INTERVENTION]'))
ALTER TABLE [dbo].[INTERVENTION] CHECK CONSTRAINT [INTERVENTION_MATERIEL_FK]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MATERIEL_CLIENT]') AND parent_object_id = OBJECT_ID(N'[dbo].[MATERIEL]'))
ALTER TABLE [dbo].[MATERIEL]  WITH CHECK ADD  CONSTRAINT [FK_MATERIEL_CLIENT] FOREIGN KEY([ID_CLIENT])
REFERENCES [dbo].[CLIENT] ([ID_CLIENT])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_MATERIEL_CLIENT]') AND parent_object_id = OBJECT_ID(N'[dbo].[MATERIEL]'))
ALTER TABLE [dbo].[MATERIEL] CHECK CONSTRAINT [FK_MATERIEL_CLIENT]
GO
/****** Object:  StoredProcedure [dbo].[AffInter]    Script Date: 16/04/2024 00:12:24 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[AffInter]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROCEDURE [dbo].[AffInter] AS' 
END
GO
ALTER PROCEDURE [dbo].[AffInter] 
	@Beginning_Date Date, @Ending_Date Date 
AS
BEGIN
	select * from INTERVENTION WHERE 
		DATE_INTER Between @Beginning_Date And @Ending_Date 
END
GO
USE [master]
GO
ALTER DATABASE [GestionMatos] SET  READ_WRITE 
GO
/****** Object:  END    Script Date: 16/04/2024 00:12:24 ******/
