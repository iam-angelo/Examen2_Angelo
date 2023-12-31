USE [master]
GO
/****** Object:  Database [proyectofinal]    Script Date: 13/12/2023 07:35:48 ******/
CREATE DATABASE [proyectofinal]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'proyectofinal', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\proyectofinal.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'proyectofinal_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\proyectofinal_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [proyectofinal] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [proyectofinal].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [proyectofinal] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [proyectofinal] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [proyectofinal] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [proyectofinal] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [proyectofinal] SET ARITHABORT OFF 
GO
ALTER DATABASE [proyectofinal] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [proyectofinal] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [proyectofinal] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [proyectofinal] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [proyectofinal] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [proyectofinal] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [proyectofinal] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [proyectofinal] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [proyectofinal] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [proyectofinal] SET  ENABLE_BROKER 
GO
ALTER DATABASE [proyectofinal] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [proyectofinal] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [proyectofinal] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [proyectofinal] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [proyectofinal] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [proyectofinal] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [proyectofinal] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [proyectofinal] SET RECOVERY FULL 
GO
ALTER DATABASE [proyectofinal] SET  MULTI_USER 
GO
ALTER DATABASE [proyectofinal] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [proyectofinal] SET DB_CHAINING OFF 
GO
ALTER DATABASE [proyectofinal] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [proyectofinal] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [proyectofinal] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [proyectofinal] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'proyectofinal', N'ON'
GO
ALTER DATABASE [proyectofinal] SET QUERY_STORE = ON
GO
ALTER DATABASE [proyectofinal] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [proyectofinal]
GO
/****** Object:  Table [dbo].[Asignaciones]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Asignaciones](
	[AsignacionID] [int] IDENTITY(1,1) NOT NULL,
	[ReparacionID] [int] NULL,
	[TecnicoID] [int] NULL,
	[FechaAsignacion] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[AsignacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Autenticar]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autenticar](
	[Username] [varchar](100) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
	[RoleID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetallesReparacion]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetallesReparacion](
	[DetalleID] [int] IDENTITY(1,1) NOT NULL,
	[ReparacionID] [int] NULL,
	[Descripcion] [varchar](50) NULL,
	[FechaInicio] [date] NULL,
	[FechaFin] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[DetalleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Equipos]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Equipos](
	[EquipoID] [int] IDENTITY(1,1) NOT NULL,
	[TipoEquipo] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NULL,
	[UsuarioID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[EquipoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[Username] [varchar](100) NOT NULL,
	[Pass] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reparaciones]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reparaciones](
	[ReparacionID] [int] IDENTITY(1,1) NOT NULL,
	[EquipoID] [int] NULL,
	[FechaSolicitud] [date] NULL,
	[Estado] [char](1) NULL,
PRIMARY KEY CLUSTERED 
(
	[ReparacionID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tecnicos]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tecnicos](
	[TecnicoID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Especialidad] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[TecnicoID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[UsuarioID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[CorreoElectronico] [varchar](50) NULL,
	[Telefono] [varchar](15) NULL,
PRIMARY KEY CLUSTERED 
(
	[UsuarioID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Telefono] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Asignaciones] ADD  DEFAULT (getdate()) FOR [FechaAsignacion]
GO
ALTER TABLE [dbo].[DetallesReparacion] ADD  DEFAULT (getdate()) FOR [FechaInicio]
GO
ALTER TABLE [dbo].[Reparaciones] ADD  DEFAULT (getdate()) FOR [FechaSolicitud]
GO
ALTER TABLE [dbo].[Asignaciones]  WITH CHECK ADD  CONSTRAINT [fk_asignaciones_reparacionId] FOREIGN KEY([ReparacionID])
REFERENCES [dbo].[Reparaciones] ([ReparacionID])
GO
ALTER TABLE [dbo].[Asignaciones] CHECK CONSTRAINT [fk_asignaciones_reparacionId]
GO
ALTER TABLE [dbo].[Asignaciones]  WITH CHECK ADD  CONSTRAINT [fk_asignaciones_tecnicoId] FOREIGN KEY([TecnicoID])
REFERENCES [dbo].[Tecnicos] ([TecnicoID])
GO
ALTER TABLE [dbo].[Asignaciones] CHECK CONSTRAINT [fk_asignaciones_tecnicoId]
GO
ALTER TABLE [dbo].[Autenticar]  WITH CHECK ADD  CONSTRAINT [fk_authUsers_roleId] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Roles] ([RoleID])
GO
ALTER TABLE [dbo].[Autenticar] CHECK CONSTRAINT [fk_authUsers_roleId]
GO
ALTER TABLE [dbo].[DetallesReparacion]  WITH CHECK ADD  CONSTRAINT [fk_detallesReparacion_reparacionId] FOREIGN KEY([ReparacionID])
REFERENCES [dbo].[Reparaciones] ([ReparacionID])
GO
ALTER TABLE [dbo].[DetallesReparacion] CHECK CONSTRAINT [fk_detallesReparacion_reparacionId]
GO
ALTER TABLE [dbo].[Equipos]  WITH CHECK ADD  CONSTRAINT [fk_equipos_usuarioId] FOREIGN KEY([UsuarioID])
REFERENCES [dbo].[Usuarios] ([UsuarioID])
GO
ALTER TABLE [dbo].[Equipos] CHECK CONSTRAINT [fk_equipos_usuarioId]
GO
ALTER TABLE [dbo].[Reparaciones]  WITH CHECK ADD  CONSTRAINT [fk_reparaciones_equipoId] FOREIGN KEY([EquipoID])
REFERENCES [dbo].[Equipos] ([EquipoID])
GO
ALTER TABLE [dbo].[Reparaciones] CHECK CONSTRAINT [fk_reparaciones_equipoId]
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_ASIGNACION_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_ASIGNACION_ID]
@ID INT,
@REPARACIONID INT,
@TECNICOID INT

AS
	BEGIN
		UPDATE Asignaciones SET ReparacionID = @REPARACIONID, TecnicoID = @TECNICOID WHERE AsignacionID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_DETALLESREPARACION_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_DETALLESREPARACION_ID]
@ID INT,
@REPARACIONID INT,
@DESCRIPCION VARCHAR(50),
@FECHAFIN DATE

AS
	BEGIN
		UPDATE DetallesReparacion SET ReparacionID = @REPARACIONID, Descripcion = @DESCRIPCION, FechaFin = @FECHAFIN WHERE DetalleID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_EQUIPO_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_EQUIPO_ID]
@ID INT,
@TIPOEQUIPO VARCHAR(50),
@MODELO VARCHAR(50),
@USUARIOID INT
AS
	BEGIN
		UPDATE Equipos SET TipoEquipo = @TIPOEQUIPO, Modelo = @MODELO, UsuarioID = @USUARIOID WHERE EquipoID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_REPARACION_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_REPARACION_ID]
@ID INT,
@EQUIPOID INT,
@ESTADO CHAR

AS
	BEGIN
		UPDATE Reparaciones SET EquipoID = @EQUIPOID, Estado = @ESTADO WHERE ReparacionID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_TECNICO_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_TECNICO_ID]
@ID INT,
@NOMBRE VARCHAR(50),
@ESPECIALIDAD VARCHAR(50)
AS
	BEGIN
		UPDATE Tecnicos SET Nombre = @NOMBRE, Especialidad = @ESPECIALIDAD WHERE TecnicoID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[ACTUALIZAR_USUARIO_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ACTUALIZAR_USUARIO_ID]
@ID INT,
@NOMBRE VARCHAR(50),
@CORREO VARCHAR(50),
@TELEFONO VARCHAR(15)
AS
	BEGIN
		UPDATE Usuarios SET Nombre = @NOMBRE, CorreoElectronico = @CORREO, Telefono = @TELEFONO WHERE UsuarioID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[BORRAR_ASIGNACIONES_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BORRAR_ASIGNACIONES_ID]
@ID INT
AS
	BEGIN
		DELETE Asignaciones WHERE AsignacionID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[BORRAR_DETALLESREPARACION_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BORRAR_DETALLESREPARACION_ID]
@ID INT
AS
	BEGIN
		DELETE DetallesReparacion WHERE DetalleID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[BORRAR_EQUIPOS_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BORRAR_EQUIPOS_ID]
@ID INT
AS
	BEGIN
		DELETE Equipos WHERE EquipoID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[BORRAR_REPARACIONES_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BORRAR_REPARACIONES_ID]
@ID INT
AS
	BEGIN
		DELETE Reparaciones WHERE ReparacionID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[BORRAR_TECNICOS_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BORRAR_TECNICOS_ID]
@ID INT
AS
	BEGIN
		DELETE Tecnicos WHERE TecnicoID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[BORRAR_USUARIOS_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[BORRAR_USUARIOS_ID]
@ID INT
AS
	BEGIN
		DELETE Usuarios WHERE UsuarioID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_ASIGNACIONES]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_ASIGNACIONES]
AS
	BEGIN
		SELECT AsignacionID, Reparaciones.Estado as EstadoDeReparacion, Tecnicos.Nombre as Tecnico, FechaAsignacion 
		FROM Asignaciones
		JOIN Reparaciones ON Asignaciones.ReparacionID = Reparaciones.ReparacionID
		JOIN Tecnicos ON Asignaciones.TecnicoID = Tecnicos.TecnicoID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_ASIGNACIONES_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_ASIGNACIONES_ID]
@ID INT
AS
	BEGIN
		SELECT AsignacionID, Reparaciones.Estado as EstadoDeReparacion, Tecnicos.Nombre as Tecnico, FechaAsignacion
		FROM Asignaciones 
		JOIN Reparaciones ON Asignaciones.ReparacionID = Reparaciones.ReparacionID
		JOIN Tecnicos ON Asignaciones.TecnicoID = Tecnicos.TecnicoID
		WHERE AsignacionID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_DETALLESREPARACION]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_DETALLESREPARACION]
AS
	BEGIN
		SELECT DetalleID, Reparaciones.ReparacionID as Reparacion, Descripcion, FechaInicio, FechaFin
		FROM DetallesReparacion 
		JOIN Reparaciones ON DetallesReparacion.ReparacionID = Reparaciones.ReparacionID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_DETALLESREPARACION_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_DETALLESREPARACION_ID]
@ID INT
AS
	BEGIN
		SELECT DetalleID, Reparaciones.ReparacionID as Reparacion, Descripcion, FechaInicio, FechaFin 
		FROM DetallesReparacion 
		JOIN Reparaciones ON DetallesReparacion.ReparacionID = Reparaciones.ReparacionID
		WHERE DetalleID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_EQUIPOS]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_EQUIPOS]
AS
	BEGIN
		SELECT EquipoID, TipoEquipo, Modelo, Usuarios.Nombre as Usuario 
		FROM Equipos
		JOIN Usuarios ON Usuarios.UsuarioID = Equipos.UsuarioID 
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_EQUIPOS_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_EQUIPOS_ID]
@ID INT
AS
	BEGIN
		SELECT EquipoID, TipoEquipo, Modelo, Usuarios.Nombre as Usuario 
		FROM Equipos 
		JOIN Usuarios ON Usuarios.UsuarioID = Equipos.UsuarioID 
		WHERE EquipoID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_REPARACIONES]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_REPARACIONES]
AS
	BEGIN
		SELECT ReparacionID, Equipos.TipoEquipo as Equipo, FechaSolicitud, Estado 
		FROM Reparaciones
		JOIN Equipos ON Equipos.EquipoID = Reparaciones.EquipoID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_REPARACIONES_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_REPARACIONES_ID]
@ID INT
AS
	BEGIN
		SELECT ReparacionID, Equipos.EquipoID as Equipo, FechaSolicitud, Estado 
		FROM Reparaciones
		JOIN Equipos ON Equipos.EquipoID = Reparaciones.EquipoID
		WHERE ReparacionID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_TECNICOS]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_TECNICOS]
AS
	BEGIN
		SELECT * FROM Tecnicos
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_TECNICOS_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_TECNICOS_ID]
@ID INT
AS
	BEGIN
		SELECT * FROM Tecnicos WHERE TecnicoID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_USUARIOS]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_USUARIOS]
AS
	BEGIN
		SELECT * FROM Usuarios
	END
GO
/****** Object:  StoredProcedure [dbo].[CONSULTAR_USUARIOS_ID]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[CONSULTAR_USUARIOS_ID]
@ID INT
AS
	BEGIN
		SELECT * FROM Usuarios WHERE UsuarioID = @ID
	END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_ASIGNACION]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERTAR_ASIGNACION]
@REPARACIONID INT,
@TECNICOID INT

AS
	BEGIN
		INSERT INTO Asignaciones(ReparacionID, TecnicoID) VALUES (@REPARACIONID, @TECNICOID)
	END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_DETALLESREPARACION]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERTAR_DETALLESREPARACION]
@REPARACIONID INT,
@DESCRIPCION VARCHAR(50)

AS
	BEGIN
		INSERT INTO DetallesReparacion(ReparacionID, Descripcion) VALUES (@REPARACIONID, @DESCRIPCION)
	END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_EQUIPO]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERTAR_EQUIPO]
@TIPOEQUIPO VARCHAR(50),
@MODELO VARCHAR(50),
@USUARIOID INT
AS
	BEGIN
		INSERT INTO Equipos(TipoEquipo, Modelo, UsuarioID) VALUES (@TIPOEQUIPO, @MODELO, @USUARIOID)
	END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_REPARACION]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERTAR_REPARACION]
@EQUIPOID INT,
@ESTADO CHAR

AS
	BEGIN
		INSERT INTO Reparaciones(EquipoID, Estado) VALUES (@EQUIPOID, @ESTADO)
	END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_TECNICO]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERTAR_TECNICO]
@NOMBRE VARCHAR(50),
@ESPECIALIDAD VARCHAR(50)
AS
	BEGIN
		INSERT INTO Tecnicos(Nombre, Especialidad) VALUES (@NOMBRE, @ESPECIALIDAD)
	END
GO
/****** Object:  StoredProcedure [dbo].[INSERTAR_USUARIO]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[INSERTAR_USUARIO]
@NOMBRE VARCHAR(50),
@CORREO VARCHAR(50),
@TELEFONO VARCHAR(15)
AS
	BEGIN
		INSERT INTO Usuarios(Nombre, CorreoElectronico, Telefono) VALUES (@NOMBRE, @CORREO, @TELEFONO)
	END
GO
/****** Object:  StoredProcedure [dbo].[LoginProcedure]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[LoginProcedure]
    @Username VARCHAR(100),
    @Pass VARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT * FROM Login WHERE Username = @Username AND Pass = @Pass)
        SELECT '1' AS Result
    ELSE
        SELECT '-1' AS Result
END;
GO
/****** Object:  StoredProcedure [dbo].[REPORTE_ADMIN]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[REPORTE_ADMIN]
AS 
	BEGIN
		SELECT Usuarios.Nombre, Usuarios.CorreoElectronico, Equipos.Modelo, Equipos.TipoEquipo, Reparaciones.Estado, Asignaciones.FechaAsignacion, Tecnicos.Nombre, DetallesReparacion.Descripcion
		FROM Usuarios
		INNER JOIN Equipos ON Usuarios.UsuarioID = Equipos.EquipoID
		INNER JOIN Reparaciones ON Equipos.EquipoID = Reparaciones.EquipoID
		INNER JOIN Asignaciones ON Reparaciones.ReparacionID = Asignaciones.ReparacionID
		INNER JOIN Tecnicos ON Asignaciones.TecnicoID = Tecnicos.TecnicoID
		INNER JOIN DetallesReparacion ON DetallesReparacion.ReparacionID = Reparaciones.ReparacionID
	END
GO
/****** Object:  StoredProcedure [dbo].[REPORTE_USUARIO_CORREO]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[REPORTE_USUARIO_CORREO]
@CORREO VARCHAR(50)
AS 
	BEGIN
		SELECT Usuarios.Nombre, Usuarios.CorreoElectronico, Equipos.Modelo, Equipos.TipoEquipo, Reparaciones.Estado, Asignaciones.FechaAsignacion, Tecnicos.Nombre, DetallesReparacion.Descripcion
		FROM Usuarios
		INNER JOIN Equipos ON Usuarios.UsuarioID = Equipos.EquipoID
		INNER JOIN Reparaciones ON Equipos.EquipoID = Reparaciones.EquipoID
		INNER JOIN Asignaciones ON Reparaciones.ReparacionID = Asignaciones.ReparacionID
		INNER JOIN Tecnicos ON Asignaciones.TecnicoID = Tecnicos.TecnicoID
		INNER JOIN DetallesReparacion ON DetallesReparacion.ReparacionID = Reparaciones.ReparacionID
		WHERE Usuarios.CorreoElectronico = @CORREO
	END
GO
/****** Object:  StoredProcedure [dbo].[REPORTE_USUARIO_NOMBRE]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[REPORTE_USUARIO_NOMBRE]
@NOMBRE VARCHAR(50)
AS 
	BEGIN
		SELECT Usuarios.Nombre, Usuarios.CorreoElectronico, Equipos.Modelo, Equipos.TipoEquipo, Reparaciones.Estado, Asignaciones.FechaAsignacion, Tecnicos.Nombre, DetallesReparacion.Descripcion
		FROM Usuarios
		INNER JOIN Equipos ON Usuarios.UsuarioID = Equipos.EquipoID
		INNER JOIN Reparaciones ON Equipos.EquipoID = Reparaciones.EquipoID
		INNER JOIN Asignaciones ON Reparaciones.ReparacionID = Asignaciones.ReparacionID
		INNER JOIN Tecnicos ON Asignaciones.TecnicoID = Tecnicos.TecnicoID
		INNER JOIN DetallesReparacion ON DetallesReparacion.ReparacionID = Reparaciones.ReparacionID
		WHERE Usuarios.Nombre = @NOMBRE
	END
GO
/****** Object:  StoredProcedure [dbo].[VALIDAR]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VALIDAR]
@USERNAME VARCHAR(100),
@PASSWORD VARCHAR(50)

AS
	BEGIN 
		SELECT Username
		FROM Login
		WHERE Username = @USERNAME AND Pass = @PASSWORD
	END
GO
/****** Object:  StoredProcedure [dbo].[VALIDAR_LOGIN]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[VALIDAR_LOGIN]
@USERNAME VARCHAR(100),
@PASSWORD VARCHAR(50)

AS
	BEGIN 
		SELECT RoleID 
		FROM AuthUsers
		WHERE Username = @USERNAME AND Pass = @PASSWORD
	END
GO
/****** Object:  StoredProcedure [dbo].[VALIDAR_LOGIN1]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VALIDAR_LOGIN1]
@USERNAME VARCHAR(100),
@PASSWORD VARCHAR(50)

AS
	BEGIN 
		SELECT Username
		FROM AuthUsers
		WHERE Username = @USERNAME AND Pass = @PASSWORD
	END
GO
/****** Object:  StoredProcedure [dbo].[validarusuario]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[validarusuario]
    @Username VARCHAR(100),
    @Pass VARCHAR(50)
AS
BEGIN
    select Username, Pass from AuthUsers where user = @Username and pass = @Pass
END;
GO
/****** Object:  StoredProcedure [dbo].[validausuario]    Script Date: 13/12/2023 07:35:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[validausuario]
    @Username VARCHAR(100),
    @Pass VARCHAR(50)
AS
BEGIN
    select Username, Pass from AuthUsers where User = @Username and Pass = @Pass
END;
GO
USE [master]
GO
ALTER DATABASE [proyectofinal] SET  READ_WRITE 
GO
