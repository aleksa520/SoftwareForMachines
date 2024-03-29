USE [master]
GO
/****** Object:  Database [VezbanjeDoSmrti]    Script Date: 11/21/2019 10:51:04 PM ******/
CREATE DATABASE [VezbanjeDoSmrti]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'VezbanjeDoSmrti', FILENAME = N'C:\Users\aleksa\VezbanjeDoSmrti.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'VezbanjeDoSmrti_log', FILENAME = N'C:\Users\aleksa\VezbanjeDoSmrti_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [VezbanjeDoSmrti] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [VezbanjeDoSmrti].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [VezbanjeDoSmrti] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET ARITHABORT OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET  DISABLE_BROKER 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET  MULTI_USER 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [VezbanjeDoSmrti] SET DB_CHAINING OFF 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [VezbanjeDoSmrti] SET QUERY_STORE = OFF
GO
USE [VezbanjeDoSmrti]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [VezbanjeDoSmrti]
GO
/****** Object:  Table [dbo].[Alat]    Script Date: 11/21/2019 10:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alat](
	[AlatId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NULL,
	[StanjeNaZalihama] [int] NULL,
 CONSTRAINT [PK_Alat] PRIMARY KEY CLUSTERED 
(
	[AlatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lokacija]    Script Date: 11/21/2019 10:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lokacija](
	[LokacijaId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NULL,
 CONSTRAINT [PK_Lokacija] PRIMARY KEY CLUSTERED 
(
	[LokacijaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Masina]    Script Date: 11/21/2019 10:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Masina](
	[MasinaId] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NULL,
	[Proizvodjac] [varchar](50) NULL,
	[OcekivaniRadniVek] [int] NULL,
	[GodinaProizvodnje] [int] NULL,
	[Korisnik] [varchar](50) NULL,
	[DatumPocetkaEksploatacije] [datetime] NULL,
	[TipMasine] [varchar](50) NULL,
	[LokacijaId] [int] NULL,
 CONSTRAINT [PK_Masina] PRIMARY KEY CLUSTERED 
(
	[MasinaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MasinaAlat]    Script Date: 11/21/2019 10:51:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasinaAlat](
	[MasinaId] [int] NOT NULL,
	[AlatId] [int] NOT NULL,
 CONSTRAINT [PK_MasinaAlat] PRIMARY KEY CLUSTERED 
(
	[MasinaId] ASC,
	[AlatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Alat] ON 

INSERT [dbo].[Alat] ([AlatId], [Naziv], [StanjeNaZalihama]) VALUES (1, N'Busilica', 2)
INSERT [dbo].[Alat] ([AlatId], [Naziv], [StanjeNaZalihama]) VALUES (2, N'Bager', 1)
INSERT [dbo].[Alat] ([AlatId], [Naziv], [StanjeNaZalihama]) VALUES (3, N'Selotejp traka', 7)
INSERT [dbo].[Alat] ([AlatId], [Naziv], [StanjeNaZalihama]) VALUES (4, N'Ekseri', 55)
INSERT [dbo].[Alat] ([AlatId], [Naziv], [StanjeNaZalihama]) VALUES (5, N'Cekic', 0)
INSERT [dbo].[Alat] ([AlatId], [Naziv], [StanjeNaZalihama]) VALUES (6, N'Matice', 80)
SET IDENTITY_INSERT [dbo].[Alat] OFF
SET IDENTITY_INSERT [dbo].[Lokacija] ON 

INSERT [dbo].[Lokacija] ([LokacijaId], [Naziv]) VALUES (1, N'Kragujevac')
INSERT [dbo].[Lokacija] ([LokacijaId], [Naziv]) VALUES (2, N'Smederevo')
INSERT [dbo].[Lokacija] ([LokacijaId], [Naziv]) VALUES (3, N'Beograd')
INSERT [dbo].[Lokacija] ([LokacijaId], [Naziv]) VALUES (4, N'Pozarevac')
INSERT [dbo].[Lokacija] ([LokacijaId], [Naziv]) VALUES (5, N'Pristina')
INSERT [dbo].[Lokacija] ([LokacijaId], [Naziv]) VALUES (6, N'Novi Sad')
SET IDENTITY_INSERT [dbo].[Lokacija] OFF
SET IDENTITY_INSERT [dbo].[Masina] ON 

INSERT [dbo].[Masina] ([MasinaId], [Naziv], [Proizvodjac], [OcekivaniRadniVek], [GodinaProizvodnje], [Korisnik], [DatumPocetkaEksploatacije], [TipMasine], [LokacijaId]) VALUES (1, N'PeraPeric', N'Milunka', 3, 2000, N'ZileCulic', CAST(N'2020-01-01T00:00:00.000' AS DateTime), N'Prdez', 2)
INSERT [dbo].[Masina] ([MasinaId], [Naziv], [Proizvodjac], [OcekivaniRadniVek], [GodinaProizvodnje], [Korisnik], [DatumPocetkaEksploatacije], [TipMasine], [LokacijaId]) VALUES (2, N'Masina za karanje', N'Aleks Fabric', 90, 1997, N'a', CAST(N'2019-11-22T18:56:09.000' AS DateTime), N'skrubler', 3)
INSERT [dbo].[Masina] ([MasinaId], [Naziv], [Proizvodjac], [OcekivaniRadniVek], [GodinaProizvodnje], [Korisnik], [DatumPocetkaEksploatacije], [TipMasine], [LokacijaId]) VALUES (3, N'Aleksa', N'Milovan', 30, 1997, N'a', CAST(N'2019-11-22T18:58:24.000' AS DateTime), N'bager', 4)
INSERT [dbo].[Masina] ([MasinaId], [Naziv], [Proizvodjac], [OcekivaniRadniVek], [GodinaProizvodnje], [Korisnik], [DatumPocetkaEksploatacije], [TipMasine], [LokacijaId]) VALUES (4, N'Vidan', N'Keva', 2, 1997, N'a', CAST(N'2019-11-22T19:02:13.000' AS DateTime), N'trafo', 5)
INSERT [dbo].[Masina] ([MasinaId], [Naziv], [Proizvodjac], [OcekivaniRadniVek], [GodinaProizvodnje], [Korisnik], [DatumPocetkaEksploatacije], [TipMasine], [LokacijaId]) VALUES (5, N'sdfh', N'dfgfd', 1345, 2000, N'a', CAST(N'2019-12-07T19:11:37.000' AS DateTime), N'induktor', 6)
INSERT [dbo].[Masina] ([MasinaId], [Naziv], [Proizvodjac], [OcekivaniRadniVek], [GodinaProizvodnje], [Korisnik], [DatumPocetkaEksploatacije], [TipMasine], [LokacijaId]) VALUES (1005, N'Mustang IV', N'Fender', 20, 2000, N'a', CAST(N'2019-11-29T21:29:00.000' AS DateTime), N'stator', 1)
SET IDENTITY_INSERT [dbo].[Masina] OFF
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (2, 4)
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (3, 4)
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (4, 2)
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (4, 3)
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (4, 4)
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (5, 1)
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (5, 4)
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (1005, 3)
INSERT [dbo].[MasinaAlat] ([MasinaId], [AlatId]) VALUES (1005, 5)
ALTER TABLE [dbo].[Masina]  WITH CHECK ADD  CONSTRAINT [FK_Masina_Lokacija] FOREIGN KEY([LokacijaId])
REFERENCES [dbo].[Lokacija] ([LokacijaId])
GO
ALTER TABLE [dbo].[Masina] CHECK CONSTRAINT [FK_Masina_Lokacija]
GO
ALTER TABLE [dbo].[MasinaAlat]  WITH CHECK ADD  CONSTRAINT [FK_MasinaAlat_Alat] FOREIGN KEY([AlatId])
REFERENCES [dbo].[Alat] ([AlatId])
GO
ALTER TABLE [dbo].[MasinaAlat] CHECK CONSTRAINT [FK_MasinaAlat_Alat]
GO
ALTER TABLE [dbo].[MasinaAlat]  WITH CHECK ADD  CONSTRAINT [FK_MasinaAlat_Masina] FOREIGN KEY([MasinaId])
REFERENCES [dbo].[Masina] ([MasinaId])
GO
ALTER TABLE [dbo].[MasinaAlat] CHECK CONSTRAINT [FK_MasinaAlat_Masina]
GO
USE [master]
GO
ALTER DATABASE [VezbanjeDoSmrti] SET  READ_WRITE 
GO
