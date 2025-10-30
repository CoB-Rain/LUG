USE [master]
GO
/****** Object:  Database [BatallaNaval]    Script Date: 30/10/2025 10:39:19 ******/
CREATE DATABASE [BatallaNaval]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BatallaNaval', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BatallaNaval.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BatallaNaval_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\BatallaNaval_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [BatallaNaval] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BatallaNaval].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BatallaNaval] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BatallaNaval] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BatallaNaval] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BatallaNaval] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BatallaNaval] SET ARITHABORT OFF 
GO
ALTER DATABASE [BatallaNaval] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BatallaNaval] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BatallaNaval] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BatallaNaval] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BatallaNaval] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BatallaNaval] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BatallaNaval] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BatallaNaval] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BatallaNaval] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BatallaNaval] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BatallaNaval] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BatallaNaval] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BatallaNaval] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BatallaNaval] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BatallaNaval] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BatallaNaval] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BatallaNaval] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BatallaNaval] SET RECOVERY FULL 
GO
ALTER DATABASE [BatallaNaval] SET  MULTI_USER 
GO
ALTER DATABASE [BatallaNaval] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BatallaNaval] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BatallaNaval] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BatallaNaval] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BatallaNaval] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [BatallaNaval] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'BatallaNaval', N'ON'
GO
ALTER DATABASE [BatallaNaval] SET QUERY_STORE = ON
GO
ALTER DATABASE [BatallaNaval] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [BatallaNaval]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[ID_USUARIO] [int] NOT NULL,
	[NOMBRE] [varchar](50) NOT NULL,
	[CONTRASEÑA] [varchar](50) NOT NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[ID_USUARIO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[JUGADOR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[JUGADOR](
	[ID_JUGADOR] [int] NOT NULL,
	[PARTIDAS_GANADAS] [int] NOT NULL,
	[PARTIDAS_EMPATADAS] [int] NOT NULL,
	[PARTIDAS_PERDIDAS] [int] NOT NULL,
	[ID_U] [int] NOT NULL,
 CONSTRAINT [PK_JUGADOR] PRIMARY KEY CLUSTERED 
(
	[ID_JUGADOR] ASC,
	[ID_U] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VISTA_USUARIO_JUGADOR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VISTA_USUARIO_JUGADOR]
AS
SELECT        dbo.USUARIO.*, dbo.JUGADOR.*
FROM            dbo.JUGADOR INNER JOIN
                         dbo.USUARIO ON dbo.JUGADOR.ID_U = dbo.USUARIO.ID_USUARIO
GO
INSERT [dbo].[JUGADOR] ([ID_JUGADOR], [PARTIDAS_GANADAS], [PARTIDAS_EMPATADAS], [PARTIDAS_PERDIDAS], [ID_U]) VALUES (2, 0, 0, 0, 2)
GO
INSERT [dbo].[JUGADOR] ([ID_JUGADOR], [PARTIDAS_GANADAS], [PARTIDAS_EMPATADAS], [PARTIDAS_PERDIDAS], [ID_U]) VALUES (5, 0, 0, 0, 2)
GO
INSERT [dbo].[JUGADOR] ([ID_JUGADOR], [PARTIDAS_GANADAS], [PARTIDAS_EMPATADAS], [PARTIDAS_PERDIDAS], [ID_U]) VALUES (6, 17, 21, 12, 1)
GO
INSERT [dbo].[JUGADOR] ([ID_JUGADOR], [PARTIDAS_GANADAS], [PARTIDAS_EMPATADAS], [PARTIDAS_PERDIDAS], [ID_U]) VALUES (7, 22, 11, 17, 1)
GO
INSERT [dbo].[JUGADOR] ([ID_JUGADOR], [PARTIDAS_GANADAS], [PARTIDAS_EMPATADAS], [PARTIDAS_PERDIDAS], [ID_U]) VALUES (8, 18, 14, 18, 1)
GO
INSERT [dbo].[USUARIO] ([ID_USUARIO], [NOMBRE], [CONTRASEÑA]) VALUES (1, N'Brian', N'123')
GO
INSERT [dbo].[USUARIO] ([ID_USUARIO], [NOMBRE], [CONTRASEÑA]) VALUES (2, N'Ester', N'456')
GO
ALTER TABLE [dbo].[JUGADOR]  WITH CHECK ADD  CONSTRAINT [FK_JUGADOR_USUARIO] FOREIGN KEY([ID_U])
REFERENCES [dbo].[USUARIO] ([ID_USUARIO])
GO
ALTER TABLE [dbo].[JUGADOR] CHECK CONSTRAINT [FK_JUGADOR_USUARIO]
GO
/****** Object:  StoredProcedure [dbo].[JUGADOR_BORRAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[JUGADOR_BORRAR]
@id int
as
BEGIN
	DELETE FROM JUGADOR WHERE ID_JUGADOR = @id
END
GO
/****** Object:  StoredProcedure [dbo].[JUGADOR_EDITAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[JUGADOR_EDITAR]
@id int, @PG int, @PE int, @PP int
as
BEGIN
	UPDATE JUGADOR SET
	PARTIDAS_GANADAS = @PG,
	PARTIDAS_EMPATADAS = @PE,
	PARTIDAS_PERDIDAS = @PP
	where ID_JUGADOR = @id
END
GO
/****** Object:  StoredProcedure [dbo].[JUGADOR_INSERTAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[JUGADOR_INSERTAR]
@id_j int, @id_u int
as
BEGIN
	declare @PG int, @PE int, @PP int
	set @PG = 0
	set @PE = 0
	set @PP = 0
	
	INSERT INTO JUGADOR (ID_JUGADOR, PARTIDAS_GANADAS, PARTIDAS_EMPATADAS, PARTIDAS_PERDIDAS, ID_U)
	VALUES (@id_j, @PG, @PE, @PP, @id_u)
END
GO
/****** Object:  StoredProcedure [dbo].[JUGADOR_LISTAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[JUGADOR_LISTAR]
as
BEGIN
	SELECT ID_JUGADOR, PARTIDAS_GANADAS, PARTIDAS_EMPATADAS, PARTIDAS_PERDIDAS FROM JUGADOR
END

GO
/****** Object:  StoredProcedure [dbo].[USUARIO_BORRAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_BORRAR]
@id int
as
BEGIN
	delete from USUARIO where ID_USUARIO = @id
END


GO
/****** Object:  StoredProcedure [dbo].[USUARIO_BUSCAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_BUSCAR]
@nom varchar(50), @pass varchar(50)
as
BEGIN
	select ID_USUARIO, NOMBRE, CONTRASEÑA from USUARIO
	where NOMBRE = @nom and CONTRASEÑA = @pass
END


GO
/****** Object:  StoredProcedure [dbo].[USUARIO_EDITAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_EDITAR]
@id int, @nom varchar(50), @pass varchar(50)
as
BEGIN
	UPDATE USUARIO SET
	NOMBRE = @nom,
	CONTRASEÑA = @pass
	WHERE ID_USUARIO = @id
END


GO
/****** Object:  StoredProcedure [dbo].[USUARIO_INSERTAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_INSERTAR]
@nom varchar(50), @pass varchar(50)
as
BEGIN
	declare @id int
	set @id = (select isnull(max(ID_USUARIO), 0) + 1 from USUARIO)

	 INSERT INTO USUARIO (ID_USUARIO, NOMBRE, CONTRASEÑA) VALUES (@id, @nom, @pass)
END


GO
/****** Object:  StoredProcedure [dbo].[USUARIO_INSERTAR_JUGADOR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_INSERTAR_JUGADOR]
@id_usu int
as
BEGIN
	declare @id_jugador int
	set @id_jugador = (select isnull(max(ID_JUGADOR), 0) + 1 from JUGADOR)
	exec JUGADOR_INSERTAR @id_jugador, @id_usu
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_JUGADOR_LISTAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_JUGADOR_LISTAR]
@id_usu int
as
BEGIN
	select * from VISTA_USUARIO_JUGADOR
	where ID_USUARIO = @id_usu
END
GO
/****** Object:  StoredProcedure [dbo].[USUARIO_LISTAR]    Script Date: 30/10/2025 10:39:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USUARIO_LISTAR]
as
BEGIN
	SELECT ID_USUARIO, NOMBRE, CONTRASEÑA FROM USUARIO
END


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
         Begin Table = "JUGADOR"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 160
               Right = 255
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "USUARIO"
            Begin Extent = 
               Top = 23
               Left = 389
               Bottom = 136
               Right = 559
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
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VISTA_USUARIO_JUGADOR'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'VISTA_USUARIO_JUGADOR'
GO
USE [master]
GO
ALTER DATABASE [BatallaNaval] SET  READ_WRITE 
GO
