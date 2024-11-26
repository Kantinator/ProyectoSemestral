-- Creación de la base de datos
CREATE DATABASE GestionTiquetes;
GO

-- Uso de la base de datos creada
USE GestionTiquetes;
GO

-- Tabla para Tipos de Solicitud
CREATE TABLE TiposSolicitud (
    ID_TipoSolicitud INT PRIMARY KEY IDENTITY(1,1),
    NombreSolicitud NVARCHAR(100) NOT NULL
);

-- Tabla para Niveles de Prioridad
CREATE TABLE NivelesPrioridad (
    ID_Prioridad INT PRIMARY KEY IDENTITY(1,1),
    NombrePrioridad NVARCHAR(50) NOT NULL
);

-- Tabla para Estatus
CREATE TABLE Estatus (
    ID_Estatus INT PRIMARY KEY IDENTITY(1,1),
    NombreEstatus NVARCHAR(50) NOT NULL
);

-- Tabla para Área de Atención
CREATE TABLE AreaAtencion (
    ID_AreaAtencion INT PRIMARY KEY IDENTITY(1,1),
    NombreArea NVARCHAR(100) NOT NULL
);

-- Tabla para Supervisores
CREATE TABLE Supervisores (
    ID_Supervisor INT PRIMARY KEY IDENTITY(1,1),
    NombreSupervisor NVARCHAR(100) NOT NULL,
    ID_AreaAtencion INT,
    FOREIGN KEY (ID_AreaAtencion) REFERENCES AreaAtencion(ID_AreaAtencion)
);

-- Tabla para Técnicos (Agentes)
CREATE TABLE Tecnicos (
    ID_Tecnico INT PRIMARY KEY IDENTITY(1,1),
    NombreTecnico NVARCHAR(100) NOT NULL,
    ID_Supervisor INT,
    ID_AreaAtencion INT,
    FOREIGN KEY (ID_Supervisor) REFERENCES Supervisores(ID_Supervisor),
    FOREIGN KEY (ID_AreaAtencion) REFERENCES AreaAtencion(ID_AreaAtencion)
);

-- Tabla para Tiquetes
CREATE TABLE Tiquetes (
    NumeroTiquete INT PRIMARY KEY IDENTITY(1,1),
    ID_TipoSolicitud INT NOT NULL,
    DescripcionSolicitud NVARCHAR(500),
    FechaTiquete DATE NOT NULL DEFAULT GETDATE(),
    HoraApertura TIME NOT NULL DEFAULT CONVERT(TIME, GETDATE()),
    ID_Prioridad INT NOT NULL,
    NombreUsuario NVARCHAR(100) NOT NULL,
    AreaTrabajo NVARCHAR(100) NOT NULL,
    ID_Estatus INT NOT NULL DEFAULT 1, -- 1 corresponde a 'Abierto'
    FOREIGN KEY (ID_TipoSolicitud) REFERENCES TiposSolicitud(ID_TipoSolicitud),
    FOREIGN KEY (ID_Prioridad) REFERENCES NivelesPrioridad(ID_Prioridad),
    FOREIGN KEY (ID_Estatus) REFERENCES Estatus(ID_Estatus)
);

-- Tabla para Asignación de Técnicos a Tiquetes
CREATE TABLE AsignacionTecnico (
    ID_Asignacion INT PRIMARY KEY IDENTITY(1,1),
    NumeroTiquete INT NOT NULL,
    ID_Tecnico INT NOT NULL,
    FechaAsignacion DATE NOT NULL DEFAULT GETDATE(),
    HoraAsignacion TIME NOT NULL DEFAULT CONVERT(TIME, GETDATE()),
    FOREIGN KEY (NumeroTiquete) REFERENCES Tiquetes(NumeroTiquete),
    FOREIGN KEY (ID_Tecnico) REFERENCES Tecnicos(ID_Tecnico)
);

-- Tabla para Actualización del Estatus de Tiquetes
CREATE TABLE ActualizacionEstatus (
    ID_Actualizacion INT PRIMARY KEY IDENTITY(1,1),
    NumeroTiquete INT NOT NULL,
    ID_Tecnico INT NOT NULL,
    FechaInicio DATE,
    HoraInicio TIME,
    Diagnostico NVARCHAR(500),
    FechaTerminacion DATE,
    HoraTerminacion TIME,
    ID_Estatus INT NOT NULL,
    FOREIGN KEY (NumeroTiquete) REFERENCES Tiquetes(NumeroTiquete),
    FOREIGN KEY (ID_Tecnico) REFERENCES Tecnicos(ID_Tecnico),
    FOREIGN KEY (ID_Estatus) REFERENCES Estatus(ID_Estatus)
);
-- Tabla para Usuarios
CREATE TABLE Usuarios (
    ID_Usuario INT PRIMARY KEY IDENTITY(1,1),
    NombreUsuario NVARCHAR(100) NOT NULL UNIQUE,
    NombreCompleto NVARCHAR(150) NOT NULL,
    Contrasena NVARCHAR(255) NOT NULL, -- Hasheada para seguridad
    TipoUsuario NVARCHAR(50) NOT NULL, -- Supervisor, Técnico o Usuario
    ID_AreaAtencion INT, -- Para Supervisores o Técnicos, NULL para Usuarios
    FOREIGN KEY (ID_AreaAtencion) REFERENCES AreaAtencion(ID_AreaAtencion)
);

-- Insertar registros iniciales para Usuarios
INSERT INTO Usuarios (NombreUsuario, NombreCompleto, Contrasena, TipoUsuario, ID_AreaAtencion)
VALUES 
('admin', 'Administrador del Sistema', 'admin123', 'Supervisor', 1), -- Supervisor General
('tecnico1', 'Técnico de Soporte 1', 'tecnico123', 'Técnico', 1), -- Técnico de Software
('usuario1', 'Usuario Regular 1', 'usuario123', 'Usuario', NULL); -- Usuario General

INSERT INTO AreaAtencion (NombreArea) VALUES ('Software');
INSERT INTO AreaAtencion (NombreArea) VALUES ('Hardware');
INSERT INTO AreaAtencion (NombreArea) VALUES ('Comunicaciones');
INSERT INTO AreaAtencion (NombreArea) VALUES ('Seguridad');

INSERT INTO Usuarios (NombreUsuario, NombreCompleto, Contrasena, TipoUsuario, ID_AreaAtencion)
VALUES 
('admin', 'Administrador del Sistema', 'admin123', 'Supervisor', 1), -- Supervisor General
('tecnico1', 'Técnico de Soporte 1', 'tecnico123', 'Técnico', 1), -- Técnico de Software
('usuario1', 'Usuario Regular 1', 'usuario123', 'Usuario', NULL); -- Usuario General
