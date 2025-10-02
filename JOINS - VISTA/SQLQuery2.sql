USE [master]
GO
/****** Object:  Database [BASE]    Script Date: 02/10/2025 18:57:44 ******/
CREATE DATABASE [BASE]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BASE', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BASE.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BASE_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BASE_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BASE] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BASE].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BASE] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BASE] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BASE] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BASE] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BASE] SET ARITHABORT OFF 
GO
ALTER DATABASE [BASE] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BASE] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BASE] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BASE] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BASE] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BASE] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BASE] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BASE] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BASE] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BASE] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BASE] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BASE] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BASE] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BASE] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BASE] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BASE] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BASE] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BASE] SET RECOVERY FULL 
GO
ALTER DATABASE [BASE] SET  MULTI_USER 
GO
ALTER DATABASE [BASE] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BASE] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BASE] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BASE] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BASE] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BASE] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BASE', N'ON'
GO
ALTER DATABASE [BASE] SET QUERY_STORE = ON
GO
ALTER DATABASE [BASE] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BASE]
GO
/****** Object:  Table [dbo].[ALUMNO]    Script Date: 02/10/2025 18:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNO](
	[ID_ALUMNO] [int] NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
 CONSTRAINT [PK_ALUMNO] PRIMARY KEY CLUSTERED 
(
	[ID_ALUMNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BECA]    Script Date: 02/10/2025 18:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BECA](
	[ID_BECA] [int] NOT NULL,
	[DESCRIPCION] [varchar](50) NOT NULL,
 CONSTRAINT [PK_BECA] PRIMARY KEY CLUSTERED 
(
	[ID_BECA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ALUMNO_BECA]    Script Date: 02/10/2025 18:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ALUMNO_BECA](
	[ID_ALUMNO] [int] NOT NULL,
	[ID_BECA] [int] NOT NULL,
 CONSTRAINT [PK_ALUMNO_BECA] PRIMARY KEY CLUSTERED 
(
	[ID_ALUMNO] ASC,
	[ID_BECA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VISTA_ALUMNOBECADO]    Script Date: 02/10/2025 18:57:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VISTA_ALUMNOBECADO]
AS
SELECT        a.ID_ALUMNO, a.NOMBRE, b.ID_BECA, b.DESCRIPCION
FROM            dbo.ALUMNO AS a INNER JOIN
                         dbo.ALUMNO_BECA AS ab ON a.ID_ALUMNO = ab.ID_ALUMNO INNER JOIN
                         dbo.BECA AS b ON ab.ID_BECA = b.ID_BECA
GO
INSERT [dbo].[ALUMNO] ([ID_ALUMNO], [NOMBRE]) VALUES (1, N'Christian')
GO
INSERT [dbo].[ALUMNO] ([ID_ALUMNO], [NOMBRE]) VALUES (2, N'Gael')
GO
INSERT [dbo].[ALUMNO] ([ID_ALUMNO], [NOMBRE]) VALUES (3, N'Cloe')
GO
INSERT [dbo].[ALUMNO] ([ID_ALUMNO], [NOMBRE]) VALUES (4, N'Susy')
GO
INSERT [dbo].[ALUMNO] ([ID_ALUMNO], [NOMBRE]) VALUES (5, N'Ana')
GO
INSERT [dbo].[ALUMNO] ([ID_ALUMNO], [NOMBRE]) VALUES (6, N'Gaston')
GO
INSERT [dbo].[ALUMNO_BECA] ([ID_ALUMNO], [ID_BECA]) VALUES (2, 1)
GO
INSERT [dbo].[ALUMNO_BECA] ([ID_ALUMNO], [ID_BECA]) VALUES (4, 2)
GO
INSERT [dbo].[ALUMNO_BECA] ([ID_ALUMNO], [ID_BECA]) VALUES (6, 3)
GO
INSERT [dbo].[BECA] ([ID_BECA], [DESCRIPCION]) VALUES (1, N'50%')
GO
INSERT [dbo].[BECA] ([ID_BECA], [DESCRIPCION]) VALUES (2, N'70%')
GO
INSERT [dbo].[BECA] ([ID_BECA], [DESCRIPCION]) VALUES (3, N'100%')
GO
ALTER TABLE [dbo].[ALUMNO_BECA]  WITH CHECK ADD  CONSTRAINT [FK_ALUMNO_BECA_ALUMNO] FOREIGN KEY([ID_ALUMNO])
REFERENCES [dbo].[ALUMNO] ([ID_ALUMNO])
GO
ALTER TABLE [dbo].[ALUMNO_BECA] CHECK CONSTRAINT [FK_ALUMNO_BECA_ALUMNO]
GO
ALTER TABLE [dbo].[ALUMNO_BECA]  WITH CHECK ADD  CONSTRAINT [FK_ALUMNO_BECA_BECA] FOREIGN KEY([ID_BECA])
REFERENCES [dbo].[BECA] ([ID_BECA])
GO
ALTER TABLE [dbo].[ALUMNO_BECA] CHECK CONSTRAINT [FK_ALUMNO_BECA_BECA]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 208
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ab"
            Begin Extent = 
               Top = 6
               Left = 246
               Bottom = 102
               Right = 416
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "b"
            Begin Extent = 
               Top = 6
               Left = 454
               Bottom = 102
               Right = 624
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VISTA_ALUMNOBECADO'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VISTA_ALUMNOBECADO'
GO
USE [master]
GO
ALTER DATABASE [BASE] SET  READ_WRITE 
GO
