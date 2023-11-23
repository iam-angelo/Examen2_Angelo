CREATE DATABASE Examen2
GO

USE Examen2
GO

CREATE TABLE Usuarios(
	UsuarioID INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(50) NOT NULL,
	CorreoElectronico VARCHAR(50),
	Telefono VARCHAR(15) UNIQUE
)
GO

CREATE TABLE Tecnicos(
	TecnicoID INT PRIMARY KEY IDENTITY(1,1),
	Nombre VARCHAR(50),
	Especialidad VARCHAR(50)
)
GO

CREATE TABLE Equipos(
	EquipoID INT PRIMARY KEY IDENTITY(1,1),
	TipoEquipo VARCHAR(50) NOT NULL,
	Modelo VARCHAR(50),
	UsuarioID INT
	CONSTRAINT fk_equipos_usuarioId FOREIGN KEY (UsuarioID) REFERENCES Usuarios(UsuarioID)
)
GO

CREATE TABLE Reparaciones(
	ReparacionID INT PRIMARY KEY IDENTITY(1,1),
	EquipoID INT,
	FechaSolicitud DATETIME DEFAULT GETDATE(),
	Estado CHAR(1),
	CONSTRAINT fk_reparaciones_equipoId FOREIGN KEY (EquipoID) REFERENCES Equipos(EquipoID)
)
GO

CREATE TABLE Asignaciones(
	AsignacionID INT PRIMARY KEY IDENTITY(1,1),
	ReparacionID INT,
	TecnidoID INT,
	FechaAsignacion DATETIME DEFAULT GETDATE(),
	CONSTRAINT fk_asignaciones_reparacionId FOREIGN KEY (ReparacionID) REFERENCES Reparaciones(ReparacionID),
	CONSTRAINT fk_asignaciones_tecnicoId FOREIGN KEY (TecnidoID) REFERENCES Tecnicos(TecnicoID)
)
GO

CREATE TABLE DetallesReparacion(
	DetalleID INT PRIMARY KEY IDENTITY(1,1),
	ReparacionID INT,
	Descripcion VARCHAR(50),
	FechaInicio DATETIME DEFAULT GETDATE(),
	FechaFin DATETIME,
	CONSTRAINT fk_detallesReparacion_reparacionId FOREIGN KEY (ReparacionID) REFERENCES Reparaciones(ReparacionID)
)
GO

INSERT INTO Usuarios(Nombre, CorreoElectronico, Telefono) VALUES 
('User1', 'mail1@mail.com', '12345678'), 
('User2', 'mail2@mail.com', '34567890'), 
('Javier', 'mail3@mail.com', '23456789')
GO

INSERT INTO Tecnicos(Nombre, Especialidad) VALUES 
('Tech1', 'Speciality1'), 
('Tech2', 'Speciality2'),
('Tech3', 'Speciality3')
GO

INSERT INTO Equipos(TipoEquipo, Modelo, UsuarioID) VALUES
('PC1', 'Brand1', 1),
('PC2', 'Brand2', 2),
('PC3', 'Brand3', 3)
GO

INSERT INTO Reparaciones(EquipoID, Estado) VALUES
(1, 'c'),
(2, 'b'),
(3, 'c')
GO

INSERT INTO Asignaciones(ReparacionID, TecnidoID) VALUES
(1, 1),
(2, 1),
(3, 2)
GO

INSERT INTO DetallesReparacion(ReparacionID, Descripcion) VALUES
(1, 'Orden 1'),
(2, 'Orden 2'),
(3, 'Orden 3')
GO

CREATE PROCEDURE CONSULTAR_USUARIOS
AS
	BEGIN
		SELECT * FROM Usuarios
	END
GO

CREATE PROCEDURE CONSULTA_USUARIO_ID
@ID INT
AS
	BEGIN
		SELECT * FROM Usuarios WHERE UsuarioID = @ID
	END
GO

CREATE PROCEDURE BORRA_USUARIO_ID
@ID INT
AS
	BEGIN
		DELETE Usuarios WHERE UsuarioID = @ID
	END
GO

CREATE PROCEDURE INSERTA_USUARIO
@NOMBRE VARCHAR(50),
@CORREO VARCHAR(50),
@TELEFONO VARCHAR(15)
AS
	BEGIN
		INSERT INTO Usuarios(Nombre, CorreoElectronico, Telefono) VALUES (@NOMBRE, @CORREO, @TELEFONO)
	END
GO

CREATE PROCEDURE ACTUALIZA_USUARIO_ID
@ID INT,
@NOMBRE VARCHAR(50),
@CORREO VARCHAR(50),
@TELEFONO VARCHAR(15)
AS
	BEGIN
		UPDATE Usuarios SET Nombre = @NOMBRE, CorreoElectronico = @CORREO, Telefono = @TELEFONO WHERE UsuarioID = @ID
	END
GO

CREATE PROCEDURE CONSULTA_TECNICO
AS
	BEGIN
		SELECT * FROM Tecnicos
	END
GO

CREATE PROCEDURE CONSULTA_TECNICO_ID
@ID INT
AS
	BEGIN
		SELECT * FROM Tecnicos WHERE TecnicoID = @ID
	END
GO

CREATE PROCEDURE BORRA_TECNICO_ID
@ID INT
AS
	BEGIN
		DELETE Tecnicos WHERE TecnicoID = @ID
	END
GO

CREATE PROCEDURE INSERTA_TECNICO
@NOMBRE VARCHAR(50),
@ESPECIALIDAD VARCHAR(50)
AS
	BEGIN
		INSERT INTO Tecnicos(Nombre, Especialidad) VALUES (@NOMBRE, @ESPECIALIDAD)
	END
GO

CREATE PROCEDURE ACTUALIZA_TECNICO_ID
@ID INT,
@NOMBRE VARCHAR(50),
@ESPECIALIDAD VARCHAR(50)
AS
	BEGIN
		UPDATE Tecnicos SET Nombre = @NOMBRE, Especialidad = @ESPECIALIDAD WHERE TecnicoID = @ID
	END
GO

CREATE PROCEDURE CONSULTA_EQUIPO
AS
	BEGIN
		SELECT * FROM Equipos
	END
GO

CREATE PROCEDURE CONSULTA_EQUIPO_ID
@ID INT
AS
	BEGIN
		SELECT * FROM Equipos WHERE EquipoID = @ID
	END
GO

CREATE PROCEDURE BORRA_EQUIPO_ID
@ID INT
AS
	BEGIN
		DELETE Equipos WHERE EquipoID = @ID
	END
GO

CREATE PROCEDURE INSERTA_EQUIPO
@TIPOEQUIPO VARCHAR(50),
@MODELO VARCHAR(50),
@USUARIOID INT
AS
	BEGIN
		INSERT INTO Equipos(TipoEquipo, Modelo, UsuarioID) VALUES (@TIPOEQUIPO, @MODELO, @USUARIOID)
	END
GO

CREATE PROCEDURE ACTUALIZA_EQUIPOO_ID
@ID INT,
@TIPOEQUIPO VARCHAR(50),
@MODELO VARCHAR(50),
@USUARIOID INT
AS
	BEGIN
		UPDATE Equipos SET TipoEquipo = @TIPOEQUIPO, Modelo = @MODELO, UsuarioID = @USUARIOID WHERE EquipoID = @ID
	END
GO