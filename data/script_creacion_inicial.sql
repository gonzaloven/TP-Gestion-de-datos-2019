--Conexión a la base de datos.
USE [GD1C2019]
GO

--Validación de tablas.
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Usuarios'))
    DROP TABLE FGNN_2019.Usuarios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Funcionalidades_Roles'))
    DROP TABLE FGNN_2019.Funcionalidades_Roles
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Funcionalidades'))
    DROP TABLE FGNN_2019.Funcionalidades
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Roles'))
    DROP TABLE FGNN_2019.Roles
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Usuarios_Roles'))
    DROP TABLE FGNN_2019.Usuarios_Roles		
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Reservas'))
    DROP TABLE FGNN_2019.Reservas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Clientes'))
    DROP TABLE FGNN_2019.Clientes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Pasajes'))
    DROP TABLE FGNN_2019.Pasajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Compras'))
    DROP TABLE FGNN_2019.Compras
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Metodos_Pago'))
    DROP TABLE FGNN_2019.Metodos_Pago
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Viajes'))
    DROP TABLE FGNN_2019.Viajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Cabinas'))
    DROP TABLE FGNN_2019.Cabinas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Cruceros'))
    DROP TABLE FGNN_2019.Cruceros
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Recorridos'))
    DROP TABLE FGNN_2019.Recorridos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Recorridos_X_Crucero'))
    DROP TABLE FGNN_2019.Recorridos_X_Crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Recorrido_X_Recorrido'))
    DROP TABLE FGNN_2019.Recorrido_X_Recorrido
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Puertos'))
    DROP TABLE FGNN_2019.Puertos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Tipos_Cabinas'))
	DROP TABLE FGNN_2019.Tipos_Cabinas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_2019.Fabricantes'))
	DROP TABLE FGNN_2019.Fabricantes
GO

-- Elimina esquema si existe
IF EXISTS (SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'FGNN_2019')
    DROP SCHEMA FGNN_2019

GO

--Creación de schema.
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'FGNN_2019')
BEGIN
	EXEC ('CREATE SCHEMA FGNN_2019 AUTHORIZATION gdCruceros2019')
END
GO

--Creación de tablas.
CREATE TABLE [FGNN_2019].[Usuarios] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[username] VARCHAR(255) UNIQUE NOT NULL,
	[password] BINARY(32) NOT NULL,
	[intentos_fallidos] SMALLINT DEFAULT 0 NOT NULL,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_2019].[Funcionalidades] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_2019].[Roles] (
	[id] SMALLINT IDENTITY(1, 1),
	[descripcion] VARCHAR(255) UNIQUE NOT NULL,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_2019].[Usuarios_Roles] (
	[usuario_id] NUMERIC(18, 0),
	[rol_id] SMALLINT NOT NULL,
	PRIMARY KEY ([usuario_id], [rol_id])
);
GO

CREATE TABLE [FGNN_2019].[Funcionalidades_Roles] (
	[rol_id] SMALLINT,
	[funcionalidad_id] NUMERIC(18, 0),
	PRIMARY KEY ([rol_id], [funcionalidad_id])
);
GO

ALTER TABLE [FGNN_2019].[Funcionalidades_Roles] WITH CHECK ADD  CONSTRAINT FK_id_rol_funcionalidades_roles FOREIGN KEY( rol_id )
REFERENCES [FGNN_2019].[Roles] (id)
GO

ALTER TABLE [FGNN_2019].[Funcionalidades_Roles] WITH CHECK ADD  CONSTRAINT FK_id_funcionalidad_funcionalidades_roles FOREIGN KEY( funcionalidad_id )
REFERENCES [FGNN_2019].[funcionalidades] (id)
GO

CREATE TABLE [FGNN_2019].[Reservas] (
	[codigo] NUMERIC(18, 0),
	[habilitada] BIT DEFAULT 1 NOT NULL,
	[fecha] DATETIME NOT NULL,
	PRIMARY KEY ([codigo])
);
GO

CREATE TABLE [FGNN_2019].[Clientes] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[nombre] VARCHAR(255) NOT NULL,
	[apellido] VARCHAR(255) NOT NULL,
	[dni] NUMERIC(18, 0) NOT NULL,
	[direccion] VARCHAR(255) NOT NULL,
	[telefono] NUMERIC(18, 0) NOT NULL,
	[fecha_nac] DATETIME NOT NULL,
	[mail] VARCHAR(255),
	[usuario_id] NUMERIC(18, 0),
	[pasaje_codigo] NUMERIC(18, 0),
	PRIMARY KEY ([id]),
	UNIQUE([dni])
);
GO

CREATE TABLE [FGNN_2019].[Pasajes] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[reserva_codigo] NUMERIC(18, 0),
	[cliente_id] NUMERIC(18, 0),
	[compra_codigo] NUMERIC(18, 0),
	[recorrido_codigo] NUMERIC(18, 0),
	[viaje_codigo] NUMERIC(18, 0),
	[cabina_nro] NUMERIC(18, 0),
	[fecha_compra] DATETIME NOT NULL,
	[precio] FLOAT NOT NULL,
	PRIMARY KEY ([codigo])
);
GO

CREATE TABLE [FGNN_2019].[Compras] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[metodo_pago] NUMERIC(18, 0),
	[fecha] DATETIME NOT NULL,
	PRIMARY KEY ([codigo])
);
GO

CREATE TABLE [FGNN_2019].[Metodos_Pago] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_2019].[Viajes] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[crucero_id] NUMERIC(18, 0),
	[recorrido_codigo] NUMERIC(18, 0),
	[fecha_inicio] DATETIME NOT NULL,
	[fecha_fin] DATETIME NOT NULL,
	PRIMARY KEY([codigo])
);
GO

CREATE TABLE [FGNN_2019].[Cabinas] (
	[crucero_id] NUMERIC(18, 0),
	[numero] NUMERIC(18, 0),
	[piso] SMALLINT NOT NULL,
	[tipo_id] NUMERIC(18, 0),
	[estado] BIT NOT NULL,
	PRIMARY KEY ([crucero_id], [numero])
);
GO

CREATE TABLE [FGNN_2019].[Cruceros] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[nombre] VARCHAR(255) NOT NULL,
	[fecha_alta] DATETIME NOT NULL,
	[modelo] VARCHAR(255) NOT NULL,
	[fabricante_id] NUMERIC(18, 0),
	[tipo_servicio] VARCHAR(255) NOT NULL,
	[baja_servicio] BIT DEFAULT 0 NOT NULL,
	[baja_vida_util] BIT DEFAULT 0 NOT NULL,
	[fecha_fuera_servicio] DATETIME,
	[fecha_reinicio_servicio] DATETIME,
	[fecha_baja_definitiva] DATETIME,
	[cant_cabinas] SMALLINT NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_2019].[Recorridos] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[puerto_desde_id] NUMERIC(18, 0),
	[puerto_hasta_id] NUMERIC(18, 0),
	[precio_base] FLOAT NOT NULL,
	PRIMARY KEY ([codigo])
);
GO

CREATE TABLE [FGNN_2019].[Puertos] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	[recorrido_id] NUMERIC(18, 0)
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_2019].[Recorrido_X_Recorrido] (
	[recorrido_total] NUMERIC(18, 0),
	[recorrido_tramo] NUMERIC(18, 0),
	PRIMARY KEY ([recorrido_total], [recorrido_tramo])
);
GO

CREATE TABLE [FGNN_2019].[Recorridos_X_Crucero] (
	[recorrido_codigo] NUMERIC(18, 0),
	[recorrido_crucero] NUMERIC(18, 0),
	PRIMARY KEY ([recorrido_codigo], [recorrido_crucero])
);
GO

CREATE TABLE [FGNN_2019].[Tipos_Cabinas] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	[porcentaje_adicional] FLOAT NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_2019].[Fabricantes] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
	
)

--Fin creación de tablas.

/* MIGRACIÓN DE DATOS */

-- Roles --
INSERT INTO [FGNN_2019].[Roles](descripcion)
VALUES ('Administrador'), ('Cliente')

-- Funcionalidades --
INSERT INTO [FGNN_2019].[Roles](descripcion)
VALUES ('ABM Roles'),('ABM Puertos'),('ABM Recorridos'),('ABM Cruceros'),('Generar Viajes'),('Comprar Viajes'),('Pagar Reservas'), ('Listado Estadistico')

-- Funcionalidades_Roles --
INSERT INTO [FGNN_2019].[Funcionalidades_Roles]
	SELECT r.rol_id, f.funcionalidad_id 
	FROM [FGNN_2019].[Funcionalidades_Roles] f,
	[FGNN_2019].[Roles] r join TRAEME_LA_COPA_MESSI.Usuario u on (rpu.Username = u.Username) where u.Username = 'admin'

