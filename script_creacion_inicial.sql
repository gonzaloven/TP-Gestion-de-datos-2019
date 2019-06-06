--Conexión a la base de datos.
USE [GD1C2019]
GO

--Creación de schema.
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = 'FGNN_19')
BEGIN
	EXEC ('CREATE SCHEMA FGNN_19 AUTHORIZATION gdCruceros2019')
END
GO

--Validación de tablas.
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Recorridos_X_Crucero'))
    DROP TABLE FGNN_19.Recorridos_X_Crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Recorrido_X_Recorrido'))
    DROP TABLE FGNN_19.Recorrido_X_Recorrido
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Cabinas'))
    DROP TABLE FGNN_19.Cabinas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Pasajes'))
    DROP TABLE FGNN_19.Pasajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Compras'))
    DROP TABLE FGNN_19.Compras
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Viajes'))
    DROP TABLE FGNN_19.Viajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Recorridos'))
    DROP TABLE FGNN_19.Recorridos
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Cruceros'))
    DROP TABLE FGNN_19.Cruceros
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Clientes'))
    DROP TABLE FGNN_19.Clientes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Funcionalidades_Roles'))
    DROP TABLE FGNN_19.Funcionalidades_Roles
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Usuarios_Roles'))
    DROP TABLE FGNN_19.Usuarios_Roles		
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Usuarios'))
    DROP TABLE FGNN_19.Usuarios
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Funcionalidades'))
    DROP TABLE FGNN_19.Funcionalidades
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Roles'))
    DROP TABLE FGNN_19.Roles
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Reservas'))
    DROP TABLE FGNN_19.Reservas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Metodos_Pago'))
    DROP TABLE FGNN_19.Metodos_Pago
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Tipos_Cabinas'))
	DROP TABLE FGNN_19.Tipos_Cabinas
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Fabricantes'))
	DROP TABLE FGNN_19.Fabricantes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Puertos'))
    DROP TABLE FGNN_19.Puertos
GO

--Creación de tablas.
CREATE TABLE [FGNN_19].[Usuarios] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[username] VARCHAR(255) UNIQUE NOT NULL,
	[password] BINARY(32) NOT NULL,
	[intentos_fallidos] SMALLINT DEFAULT 0 NOT NULL,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Funcionalidades] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Roles] (
	[id] SMALLINT IDENTITY(1, 1),
	[descripcion] VARCHAR(255) UNIQUE NOT NULL,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Reservas] (
	[codigo] NUMERIC(18, 0),
	[habilitada] BIT DEFAULT 1 NOT NULL,
	[fecha] DATETIME2(3) NOT NULL,
	PRIMARY KEY ([codigo])
);
GO

CREATE TABLE [FGNN_19].[Metodos_Pago] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Tipos_Cabinas] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	[porcentaje_adicional] FLOAT NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Fabricantes] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Puertos] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[descripcion] VARCHAR(255) NOT NULL,
	PRIMARY KEY ([id]),
);
GO

CREATE TABLE [FGNN_19].[Usuarios_Roles] (
	[usuario_id] NUMERIC(18, 0),
	[rol_id] SMALLINT NOT NULL,
	PRIMARY KEY ([usuario_id], [rol_id]),
	FOREIGN KEY (usuario_id) REFERENCES FGNN_19.Usuarios(id),
	FOREIGN KEY (rol_id) REFERENCES FGNN_19.Roles(id)
);
GO

CREATE TABLE [FGNN_19].[Funcionalidades_Roles] (
	[rol_id] SMALLINT,
	[funcionalidad_id] NUMERIC(18, 0),
	PRIMARY KEY ([rol_id], [funcionalidad_id]),
	FOREIGN KEY (rol_id) REFERENCES FGNN_19.Roles(id),
	FOREIGN KEY (funcionalidad_id) REFERENCES FGNN_19.Funcionalidades(id)
);
GO

CREATE TABLE [FGNN_19].[Clientes] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[nombre] VARCHAR(255) NOT NULL,
	[apellido] VARCHAR(255) NOT NULL,
	[dni] NUMERIC(18, 0) NOT NULL,
	[direccion] VARCHAR(255) NOT NULL,
	[telefono] NUMERIC(18, 0) NOT NULL,
	[fecha_nac] DATETIME NOT NULL,
	[mail] VARCHAR(255),
	[usuario_id] NUMERIC(18, 0),
	PRIMARY KEY ([id]),
	UNIQUE([dni]),
	FOREIGN KEY (usuario_id) REFERENCES FGNN_19.Usuarios(id)
);
GO

CREATE TABLE [FGNN_19].[Cruceros] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[nombre] VARCHAR(255) NOT NULL,
	[fecha_alta] DATETIME2(3) NOT NULL,
	[modelo] VARCHAR(255) NOT NULL,
	[fabricante_id] NUMERIC(18, 0),
	[tipo_servicio] VARCHAR(255) NOT NULL,
	[baja_servicio] BIT DEFAULT 0 NOT NULL,
	[baja_vida_util] BIT DEFAULT 0 NOT NULL,
	[fecha_fuera_servicio] DATETIME2(3),
	[fecha_reinicio_servicio] DATETIME2(3),
	[fecha_baja_definitiva] DATETIME2(3),
	[cant_cabinas] SMALLINT NOT NULL,
	PRIMARY KEY ([id]),
	FOREIGN KEY (fabricante_id) REFERENCES FGNN_19.Fabricantes(id)
);
GO

CREATE TABLE [FGNN_19].[Recorridos] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[puerto_desde_id] NUMERIC(18, 0),
	[puerto_hasta_id] NUMERIC(18, 0),
	[precio_base] FLOAT NOT NULL,
	PRIMARY KEY ([codigo]),
	FOREIGN KEY (puerto_desde_id) REFERENCES FGNN_19.Puertos(id),
	FOREIGN KEY (puerto_hasta_id) REFERENCES FGNN_19.Puertos(id)
);
GO

CREATE TABLE [FGNN_19].[Viajes] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[crucero_id] NUMERIC(18, 0),
	[recorrido_codigo] NUMERIC(18, 0),
	[fecha_inicio] DATETIME2(3) NOT NULL,
	[fecha_fin] DATETIME2(3) NOT NULL,
	PRIMARY KEY([codigo]),
	FOREIGN KEY (crucero_id) REFERENCES FGNN_19.Cruceros(id),
	FOREIGN KEY (recorrido_codigo) REFERENCES FGNN_19.Recorridos(codigo)
);
GO

CREATE TABLE [FGNN_19].[Compras] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[metodo_pago] NUMERIC(18, 0),
	[fecha] DATETIME2(3) NOT NULL,
	PRIMARY KEY ([codigo]),
	FOREIGN KEY (metodo_pago) REFERENCES FGNN_19.Metodos_Pago(id)
);
GO

CREATE TABLE [FGNN_19].[Pasajes] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[reserva_codigo] NUMERIC(18, 0),
	[cliente_id] NUMERIC(18, 0),
	[compra_codigo] NUMERIC(18, 0),
	[viaje_codigo] NUMERIC(18, 0),
	[fecha_compra] DATETIME2(3) NOT NULL,
	[precio] FLOAT NOT NULL,
	PRIMARY KEY ([codigo]),
	FOREIGN KEY (reserva_codigo) REFERENCES FGNN_19.Reservas(codigo),
	FOREIGN KEY (cliente_id) REFERENCES FGNN_19.Clientes(id),
	FOREIGN KEY (compra_codigo) REFERENCES FGNN_19.Compras(codigo),
	FOREIGN KEY (viaje_codigo) REFERENCES FGNN_19.Viajes(codigo)
);
GO

CREATE TABLE [FGNN_19].[Cabinas] (
	[crucero_id] NUMERIC(18, 0),
	[numero] NUMERIC(18, 0),
	[piso] SMALLINT NOT NULL,
	[tipo_id] NUMERIC(18, 0),
	[estado] BIT NOT NULL,
	pasaje_codigo NUMERIC(18, 0),
	PRIMARY KEY ([crucero_id], [numero]),
	FOREIGN KEY (crucero_id) REFERENCES FGNN_19.Cruceros(id),
	FOREIGN KEY (tipo_id) REFERENCES FGNN_19.Tipos_Cabinas(id),
	FOREIGN KEY (pasaje_codigo) REFERENCES FGNN_19.Pasajes(codigo)
);
GO

CREATE TABLE [FGNN_19].[Recorrido_X_Recorrido] (
	[recorrido_total] NUMERIC(18, 0),
	[recorrido_tramo] NUMERIC(18, 0),
	PRIMARY KEY ([recorrido_total], [recorrido_tramo]),
	FOREIGN KEY (recorrido_total) REFERENCES FGNN_19.Recorridos(codigo),
	FOREIGN KEY (recorrido_tramo) REFERENCES FGNN_19.Recorridos(codigo)
);
GO

CREATE TABLE [FGNN_19].[Recorridos_X_Crucero] (
	[recorrido_codigo] NUMERIC(18, 0),
	[recorrido_crucero] NUMERIC(18, 0),
	PRIMARY KEY ([recorrido_codigo], [recorrido_crucero]),
	FOREIGN KEY (recorrido_codigo) REFERENCES FGNN_19.Recorridos(codigo),
	FOREIGN KEY (recorrido_crucero) REFERENCES FGNN_19.Cruceros(id)
);
GO

--Fin creación de tablas.

--Migración