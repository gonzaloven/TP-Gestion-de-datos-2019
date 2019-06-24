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

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.Pasajes_Cancelados'))
    DROP TABLE FGNN_19.Pasajes_Cancelados
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

IF EXISTS (SELECT * FROM sys.views WHERE name = 'vw_RolesYFuncionalidades' AND type = 'V') 
	DROP VIEW FGNN_19.vw_RolesYFuncionalidades
GO

IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'FGNN_19.TR_Roles_InsteadOfDelete' AND [type] = 'TR')
    DROP TRIGGER FGNN_19.TR_Roles_InsteadOfDelete
GO

IF EXISTS (SELECT * FROM sys.objects WHERE [name] = N'FGNN_19.TR_Recorridos_AfterUpdate' AND [type] = 'TR')
    DROP TRIGGER FGNN_19.TR_Recorridos_InsteadOfUpdate
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_ValidarLogin') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_ValidarLogin 
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.P_Viaje_valido') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.P_Viaje_valido
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Baja_difinitiva_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Baja_difinitiva_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Baja_temporal_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Baja_temporal_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Actualizacion_reinicio_cruceros') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Actualizacion_reinicio_cruceros
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Cancelar_pasajes_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Cancelar_pasajes_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Reemplazar_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Reemplazar_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.Reeprogramar_viajes_crucero') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.Reeprogramar_viajes_crucero
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_recorridos_mas_comprados') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_recorridos_mas_comprados
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_recorridos_mas_cabinas_libres') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_recorridos_mas_cabinas_libres
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = object_id(N'FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio') AND OBJECTPROPERTY(object_id, N'IsProcedure') = 1)
	DROP PROCEDURE FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Calcular_costo_pasaje') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Calcular_costo_pasaje
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Calcular_costo_base') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Calcular_costo_base
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Tiene_fecha_libre') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Tiene_fecha_libre
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Puede_cumplir_sus_viajes') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Puede_cumplir_sus_viajes
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Pasaje_no_cancelado') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Pasaje_no_cancelado
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Crucero_reemplazante') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Crucero_reemplazante
GO

IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'FGNN_19.FN_Puede_cumplir_recorrido') AND type in (N'FN', N'IF', N'TF', N'FS', N'FT'))
	DROP FUNCTION FGNN_19.FN_Puede_cumplir_recorrido
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
	[cuotas] BIT NOT NULL,
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
	[fecha_nac] DATETIME2(3) NOT NULL,
	[mail] VARCHAR(255),
	PRIMARY KEY ([id])
);
GO

CREATE TABLE [FGNN_19].[Cruceros] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[nombre] VARCHAR(255) NOT NULL,
	[fecha_alta] DATETIME2(3),
	[modelo] VARCHAR(255) NOT NULL,
	[fabricante_id] NUMERIC(18, 0),
	[tipo_servicio] VARCHAR(255),
	[baja_servicio] BIT DEFAULT 0,
	[baja_vida_util] BIT DEFAULT 0,
	[fecha_fuera_servicio] DATETIME2(3),
	[fecha_reinicio_servicio] DATETIME2(3),
	[fecha_baja_definitiva] DATETIME2(3),
	[cant_cabinas] SMALLINT,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id]),
	FOREIGN KEY (fabricante_id) REFERENCES FGNN_19.Fabricantes(id)
);
GO

CREATE TABLE [FGNN_19].[Recorridos] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[codigo] VARCHAR(255),
	[puerto_desde_id] NUMERIC(18, 0) NOT NULL,
	[puerto_hasta_id] NUMERIC(18, 0) NOT NULL,
	[precio_base] FLOAT NOT NULL,
	[habilitado] BIT DEFAULT 1 NOT NULL,
	PRIMARY KEY ([id]),
	FOREIGN KEY (puerto_desde_id) REFERENCES FGNN_19.Puertos(id),
	FOREIGN KEY (puerto_hasta_id) REFERENCES FGNN_19.Puertos(id)
);
GO

CREATE TABLE [FGNN_19].[Viajes] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[crucero_id] NUMERIC(18, 0),
	[recorrido_codigo] NUMERIC(18, 0),
	[fecha_inicio] DATETIME2(3),
	[fecha_fin] DATETIME2(3),
	[fecha_fin_estimada] DATETIME2(3),
	PRIMARY KEY([codigo]),
	FOREIGN KEY (crucero_id) REFERENCES FGNN_19.Cruceros(id),
	FOREIGN KEY (recorrido_codigo) REFERENCES FGNN_19.Recorridos(id)
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
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[reserva_codigo] NUMERIC(18, 0),
	[cliente_id] NUMERIC(18, 0),
	[compra_codigo] NUMERIC(18, 0),
	[viaje_codigo] NUMERIC(18, 0),
	[fecha_compra] DATETIME2(3),
	[precio] FLOAT,
	[codigo] NUMERIC(18,0)
	PRIMARY KEY ([id]),
	FOREIGN KEY (reserva_codigo) REFERENCES FGNN_19.Reservas(codigo),
	FOREIGN KEY (cliente_id) REFERENCES FGNN_19.Clientes(id),
	FOREIGN KEY (compra_codigo) REFERENCES FGNN_19.Compras(codigo),
	FOREIGN KEY (viaje_codigo) REFERENCES FGNN_19.Viajes(codigo)
);
GO

CREATE TABLE [FGNN_19].[Cabinas] (
	[codigo] NUMERIC(18, 0) IDENTITY(1, 1),
	[crucero_id] NUMERIC(18, 0),
	[numero] NUMERIC(18, 0),
	[piso] NUMERIC(18, 0) NOT NULL,
	[tipo_id] NUMERIC(18, 0),
	[estado] BIT,
	[pasaje_codigo] NUMERIC(18, 0),
	PRIMARY KEY ([codigo]),
	FOREIGN KEY (crucero_id) REFERENCES FGNN_19.Cruceros(id),
	FOREIGN KEY (tipo_id) REFERENCES FGNN_19.Tipos_Cabinas(id),
	FOREIGN KEY (pasaje_codigo) REFERENCES FGNN_19.Pasajes(id)
);
GO

CREATE TABLE [FGNN_19].[Recorrido_X_Recorrido] (
	[recorrido_total] NUMERIC(18, 0),
	[recorrido_tramo] NUMERIC(18, 0),
	PRIMARY KEY ([recorrido_total], [recorrido_tramo]),
	FOREIGN KEY (recorrido_total) REFERENCES FGNN_19.Recorridos(id),
	FOREIGN KEY (recorrido_tramo) REFERENCES FGNN_19.Recorridos(id)
);
GO

CREATE TABLE [FGNN_19].[Recorridos_X_Crucero] (
	[recorrido_codigo] NUMERIC(18, 0),
	[recorrido_crucero] NUMERIC(18, 0),
	PRIMARY KEY ([recorrido_codigo], [recorrido_crucero]),
	FOREIGN KEY (recorrido_codigo) REFERENCES FGNN_19.Recorridos(id),
	FOREIGN KEY (recorrido_crucero) REFERENCES FGNN_19.Cruceros(id)
);
GO

CREATE TABLE [FGNN_19].[Pasajes_Cancelados] (
	[id] NUMERIC(18, 0) IDENTITY(1, 1),
	[id_pasaje] NUMERIC(18,0),
	[fecha_cancelacion] datetime2(3),
	[motivo] VARCHAR(255)
	PRIMARY KEY([id]),
	FOREIGN KEY (id_pasaje) REFERENCES FGNN_19.Pasajes(id)
);
GO

--Fin creación de tablas.

--Migración

INSERT INTO FGNN_19.Tipos_Cabinas (descripcion, porcentaje_adicional)
SELECT CABINA_TIPO, CABINA_TIPO_PORC_RECARGO FROM gd_esquema.Maestra
GROUP BY CABINA_TIPO, CABINA_TIPO_PORC_RECARGO

INSERT INTO FGNN_19.Puertos (descripcion)
SELECT C.PUERTO_DESDE FROM gd_esquema.Maestra C
UNION
SELECT D.PUERTO_HASTA FROM gd_esquema.Maestra D

INSERT INTO FGNN_19.Recorridos (codigo, puerto_desde_id, puerto_hasta_id, precio_base)
SELECT CONVERT(VARCHAR,M.RECORRIDO_CODIGO), PD.id, PH.id, M.RECORRIDO_PRECIO_BASE
FROM gd_esquema.Maestra M, FGNN_19.Puertos PD, FGNN_19.Puertos PH
WHERE PD.descripcion = M.PUERTO_DESDE
AND PH.descripcion = M.PUERTO_HASTA
GROUP BY CONVERT(VARCHAR,M.RECORRIDO_CODIGO), PD.id, PH.id, M.RECORRIDO_PRECIO_BASE

INSERT INTO FGNN_19.Reservas (codigo, fecha)
SELECT RESERVA_CODIGO, RESERVA_FECHA
FROM gd_esquema.Maestra
WHERE RESERVA_CODIGO IS NOT NULL
AND RESERVA_FECHA IS NOT NULL
GROUP BY RESERVA_CODIGO, RESERVA_FECHA
ORDER BY RESERVA_CODIGO ASC

INSERT INTO FGNN_19.Fabricantes(descripcion)
SELECT CRU_FABRICANTE
FROM gd_esquema.Maestra
GROUP BY CRU_FABRICANTE
ORDER BY CRU_FABRICANTE ASC

INSERT INTO FGNN_19.Cruceros(nombre, modelo, fabricante_id)
SELECT m.CRUCERO_IDENTIFICADOR, m.CRUCERO_MODELO, f.id
FROM gd_esquema.Maestra m, FGNN_19.Fabricantes f
WHERE f.descripcion = m.CRU_FABRICANTE
GROUP BY m.CRUCERO_IDENTIFICADOR, m.CRUCERO_MODELO, f.id
ORDER BY m.CRUCERO_MODELO ASC, f.id ASC

INSERT INTO FGNN_19.Clientes(nombre, apellido, dni, direccion, telefono, fecha_nac, mail)
SELECT CLI_NOMBRE, CLI_APELLIDO, CLI_DNI, CLI_DIRECCION, CLI_TELEFONO, CLI_FECHA_NAC, CLI_MAIL
FROM gd_esquema.Maestra
GROUP BY CLI_NOMBRE, CLI_APELLIDO, CLI_DNI, CLI_DIRECCION, CLI_TELEFONO, CLI_FECHA_NAC, CLI_MAIL

INSERT INTO FGNN_19.Viajes(crucero_id, recorrido_codigo, fecha_inicio, fecha_fin, fecha_fin_estimada)
SELECT c.id, r.id, m.FECHA_SALIDA, m.FECHA_LLEGADA, m.FECHA_LLEGADA_ESTIMADA
FROM gd_esquema.Maestra m, FGNN_19.Cruceros c, FGNN_19.Fabricantes f, FGNN_19.Recorridos r
WHERE c.nombre = m.CRUCERO_IDENTIFICADOR 
AND c.modelo = m.CRUCERO_MODELO 
AND f.descripcion = m.CRU_FABRICANTE 
AND c.fabricante_id = f.id
AND r.codigo = CONVERT(VARCHAR,M.RECORRIDO_CODIGO)
GROUP BY c.id, r.id, m.FECHA_SALIDA, m.FECHA_LLEGADA, m.FECHA_LLEGADA_ESTIMADA

INSERT INTO FGNN_19.Pasajes(reserva_codigo, cliente_id, viaje_codigo, fecha_compra, precio, codigo)
SELECT m.RESERVA_CODIGO, c.id, v.codigo, m.PASAJE_FECHA_COMPRA, m.PASAJE_PRECIO, m.PASAJE_CODIGO
FROM gd_esquema.Maestra m, FGNN_19.Clientes c, FGNN_19.Viajes v, FGNN_19.Cruceros cru, FGNN_19.Fabricantes f, FGNN_19.Recorridos r, FGNN_19.Puertos pd, FGNN_19.Puertos ph
WHERE m.CLI_APELLIDO = c.apellido
AND m.CLI_DIRECCION = c.direccion
AND m.CLI_DNI = c.dni
AND m.CLI_FECHA_NAC = c.fecha_nac
AND m.CLI_MAIL = c.mail
AND m.CLI_NOMBRE = c.nombre
AND m.CLI_TELEFONO = c.telefono
AND cru.nombre = m.CRUCERO_IDENTIFICADOR
AND cru.modelo = m.CRUCERO_MODELO
AND f.descripcion = m.CRU_FABRICANTE
AND cru.fabricante_id = f.id
AND v.crucero_id = cru.id
AND r.codigo = CONVERT(varchar,m.RECORRIDO_CODIGO)
AND r.puerto_desde_id = pd.id
AND r.puerto_hasta_id = ph.id
AND pd.descripcion = m.PUERTO_DESDE
AND ph.descripcion = m.PUERTO_HASTA
AND v.recorrido_codigo = r.id
GROUP BY m.RESERVA_CODIGO, c.id, v.codigo, m.PASAJE_FECHA_COMPRA, m.PASAJE_PRECIO, m.PASAJE_CODIGO

INSERT INTO FGNN_19.Cabinas(crucero_id, numero, piso, tipo_id, pasaje_codigo)
SELECT cru.id, m.CABINA_NRO, m.CABINA_PISO, tc.id, p.id
FROM gd_esquema.Maestra m, FGNN_19.Cruceros cru, FGNN_19.Tipos_Cabinas tc, FGNN_19.Pasajes p, FGNN_19.Fabricantes f
WHERE m.CRUCERO_IDENTIFICADOR = cru.nombre
AND m.CRUCERO_MODELO = cru.modelo
AND m.CRU_FABRICANTE = f.descripcion
AND f.id = cru.fabricante_id
AND tc.descripcion = m.CABINA_TIPO
AND tc.porcentaje_adicional = m.CABINA_TIPO_PORC_RECARGO
AND p.codigo = m.PASAJE_CODIGO
GROUP BY cru.id, m.CABINA_NRO, m.CABINA_PISO, tc.id, p.id

INSERT INTO FGNN_19.Recorridos_X_Crucero 
SELECT r.id, c.id
FROM gd_esquema.Maestra m, FGNN_19.Cruceros c, FGNN_19.Fabricantes f, FGNN_19.Recorridos r
WHERE c.nombre = m.CRUCERO_IDENTIFICADOR
AND c.modelo = m.CRUCERO_MODELO
AND c.fabricante_id = f.id
AND f.descripcion = m.CRU_FABRICANTE
AND r.codigo = CONVERT(VARCHAR,M.RECORRIDO_CODIGO)
GROUP BY r.id, c.id

-- Fin Migracion

-- Roles --
INSERT INTO [FGNN_19].[Roles](descripcion)
VALUES ('Administrador')

-- Funcionalidades --
INSERT INTO [FGNN_19].[Funcionalidades](descripcion)
VALUES ('ABM Roles'),
	('ABM Recorridos'),
	('ABM Cruceros'),
	('Generar Viajes'),
	('Comprar Viajes'),
	('Pagar Reservas'),
	('Listado Estadistico')

-- Funcionalidades_Roles --
INSERT INTO [FGNN_19].[Funcionalidades_Roles]
	SELECT r.id, f.id 
	FROM [FGNN_19].[Funcionalidades] f, [FGNN_19].[Roles] r
	WHERE r.descripcion = 'Administrador';
GO

INSERT INTO FGNN_19.Usuarios (username, password, intentos_fallidos, habilitado)
VALUES ('juanpedro',CONVERT(BINARY(32),HASHBYTES('SHA2_256','w23e')),0,1)
GO

INSERT INTO FGNN_19.Usuarios (username, password, intentos_fallidos, habilitado)
VALUES ('pablo18',CONVERT(BINARY(32),HASHBYTES('SHA2_256','w23e')),0,1)
GO

INSERT INTO FGNN_19.Usuarios (username, password, intentos_fallidos, habilitado)
VALUES ('javiperez67',CONVERT(BINARY(32),HASHBYTES('SHA2_256','w23e')),0,1)
GO

INSERT INTO FGNN_19.Usuarios_Roles
SELECT u.id, r.id
FROM FGNN_19.Usuarios u, FGNN_19.Roles r
WHERE r.descripcion = 'Administrador';
GO

-- Vistas

CREATE VIEW FGNN_19.vw_RolesYFuncionalidades
AS 
SELECT r.descripcion AS ROL, f.descripcion AS FUNCIONALIDAD 
FROM FGNN_19.Roles r, FGNN_19.Funcionalidades f, FGNN_19.Funcionalidades_Roles fr
WHERE fr.funcionalidad_id = f.id
AND fr.rol_id = r.id;
GO

-- Funciones

CREATE FUNCTION FGNN_19.FN_Calcular_costo_base(@idRecorrido NUMERIC(18,0))
RETURNS FLOAT
AS

BEGIN

	DECLARE @PrecioBaseTotal FLOAT

	SET @PrecioBaseTotal = (SELECT SUM(FGNN_19.FN_Calcular_costo_base(rr.recorrido_tramo))
	FROM FGNN_19.Recorridos r, FGNN_19.Recorrido_X_Recorrido rr
	WHERE r.id = @idRecorrido
	AND r.id = rr.recorrido_total)

	IF @PrecioBaseTotal IS NULL
	BEGIN
		SET @PrecioBaseTotal = (SELECT r.precio_base FROM FGNN_19.Recorridos r WHERE r.id = @idRecorrido)
	END

	RETURN @PrecioBaseTotal

END;
GO

CREATE FUNCTION FGNN_19.FN_Calcular_costo_pasaje(@idViaje NUMERIC(18,0), @idCabina NUMERIC(18,0))
RETURNS FLOAT
AS
BEGIN
	
	DECLARE @idRecorrido NUMERIC(18,0)
	DECLARE @PorcAdicional FLOAT
	DECLARE @PrecioBaseTotal FLOAT

	SET @idRecorrido = (SELECT v.recorrido_codigo
		FROM FGNN_19.Viajes v
		WHERE v.codigo = @idViaje)

	SET @PorcAdicional = (SELECT tc.porcentaje_adicional
		FROM FGNN_19.Cabinas c
			JOIN FGNN_19.Tipos_Cabinas tc ON tc.id = c.tipo_id
			WHERE c.codigo = @idCabina)

	SET @PrecioBaseTotal = FGNN_19.FN_Calcular_costo_base(@idRecorrido)

	RETURN @PrecioBaseTotal * @PorcAdicional
END
GO

CREATE FUNCTION FGNN_19.FN_Pasaje_no_cancelado(@idPasaje NUMERIC(18,0))
RETURNS BIT
AS
BEGIN

	IF NOT EXISTS (SELECT 1
		FROM Pasajes_Cancelados 
		WHERE id_pasaje = @idPasaje)
		RETURN 1

	RETURN 0

END
GO

CREATE FUNCTION FGNN_19.FN_Tiene_fecha_libre(@idCrucero NUMERIC(18,0), @fecha_inicio DATETIME2(3), @fecha_fin DATETIME2(3))
RETURNS INT
AS
BEGIN

	IF NOT EXISTS (SELECT 1
		FROM Viajes v
			JOIN Pasajes p ON p.viaje_codigo = v.codigo 
		WHERE v.crucero_id = @idCrucero AND v.fecha_inicio < @fecha_fin AND v.fecha_fin > @fecha_inicio AND FGNN_19.FN_Pasaje_no_cancelado(p.id) = 1)
		RETURN 1

	RETURN 0

END
GO

CREATE FUNCTION FGNN_19.FN_Puede_cumplir_recorrido(@idCrucero NUMERIC(18,0), @idRecorrido NUMERIC(18,0))
RETURNS INT
AS
BEGIN

	IF EXISTS (SELECT 1
		FROM FGNN_19.Recorridos_X_Crucero
		WHERE recorrido_codigo = @idRecorrido AND recorrido_crucero = @idCrucero)
		RETURN 1

	RETURN 0

END
GO

CREATE FUNCTION FGNN_19.FN_Puede_cumplir_sus_viajes(@idCruceroOriginal NUMERIC(18,0), @idCruceroReemplazo NUMERIC(18,0))
RETURNS BIT
AS
BEGIN

	DECLARE @cantidad_viajes_cumple_fecha INT
	DECLARE @cantidad_viajes_cumple_recorrido INT
	DECLARE @cantidad_viajes_existentes INT

	SET @cantidad_viajes_cumple_fecha = (SELECT ISNULL(SUM(FGNN_19.FN_Tiene_fecha_libre(@idCruceroReemplazo, fecha_inicio, fecha_fin)),0)
		FROM FGNN_19.Viajes 
		WHERE crucero_id = @idCruceroOriginal
		GROUP BY crucero_id)
		
	SET @cantidad_viajes_cumple_recorrido = (SELECT ISNULL(SUM(FGNN_19.FN_Puede_cumplir_recorrido(@idCruceroReemplazo, recorrido_codigo)),0)
		FROM FGNN_19.Viajes 
		WHERE crucero_id = @idCruceroOriginal
		GROUP BY crucero_id)

	SET @cantidad_viajes_existentes = (SELECT COUNT(v.codigo)
		FROM FGNN_19.Viajes v
			JOIN Pasajes p ON p.viaje_codigo = v.codigo
		WHERE v.crucero_id = @idCruceroOriginal AND v.fecha_inicio >=  CONVERT(datetime2(3), GETDATE()) AND FGNN_19.FN_Pasaje_no_cancelado(p.id) = 1
		GROUP BY v.crucero_id)

	IF(@cantidad_viajes_cumple_fecha = @cantidad_viajes_existentes AND @cantidad_viajes_cumple_recorrido = @cantidad_viajes_existentes)
		RETURN 1

	RETURN 0

END
GO

CREATE FUNCTION FGNN_19.FN_Crucero_reemplazante(@idCruceroOriginal NUMERIC(18,0))
RETURNS NUMERIC(18,0)
AS
BEGIN

	DECLARE @idCruceroReemplazo NUMERIC(18,0)

	SET @idCruceroReemplazo = (SELECT TOP 1 cr.id
		FROM Cruceros co
			JOIN Cruceros cr ON co.id != cr.id
		WHERE co.id = @idCruceroOriginal AND cr.baja_servicio = 0 AND cr.baja_vida_util = 0 AND FGNN_19.FN_Puede_cumplir_sus_viajes(@idCruceroOriginal, cr.id) = 1
			AND cr.modelo = co.modelo AND cr.tipo_servicio = co.tipo_servicio)

	RETURN @idCruceroReemplazo
END
GO

-- Procedures

CREATE PROCEDURE FGNN_19.P_ValidarLogin 
@User VARCHAR(255), 
@Pass VARCHAR(255), 
@Resultado INT OUTPUT
AS
BEGIN TRANSACTION
	IF EXISTS (
			SELECT 1
			FROM FGNN_19.Usuarios
			WHERE username = @User
			)
	BEGIN
		IF EXISTS (
				SELECT 1
				FROM FGNN_19.Usuarios
				WHERE username = @User
				AND password = CONVERT(BINARY (32), HASHBYTES('SHA2_256',@Pass))
				)
		BEGIN
			SET @Resultado = 0
		END
		ELSE
		BEGIN
			UPDATE FGNN_19.Usuarios
			SET intentos_fallidos = intentos_fallidos + 1
			WHERE username = @user

			SET @Resultado = 1
		END
	END
	ELSE
	BEGIN
		SET @Resultado = 1
	END

	RETURN @Resultado
COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.P_Viaje_valido
@nombreCrucero VARCHAR(255), 
@puertoDesde VARCHAR(255), 
@puertoHasta VARCHAR(255),
@fechaInicio DATETIME2(3),
@fechaFin DATETIME2(3),
@Resultado BIT OUTPUT
AS
BEGIN
	
	IF @fechaFin < @fechaInicio
	BEGIN
		SET @Resultado = 0
	END
	ELSE IF @puertoDesde = @puertoHasta
	BEGIN
		SET @Resultado = 0
	END
	ELSE IF EXISTS(SELECT id
				  FROM Cruceros
				  WHERE nombre = @nombreCrucero
					AND FGNN_19.FN_Tiene_fecha_libre(id, @fechaInicio, @fechaFin) = 0)
	BEGIN
		SET @Resultado = 0
	END
	ELSE
	BEGIN
		SET @Resultado = 1
	END

RETURN @Resultado	

END;
GO

CREATE PROCEDURE FGNN_19.Baja_difinitiva_crucero (@idCrucero numeric(18,0), @fechaBaja datetime2(3))
AS
BEGIN TRANSACTION

	UPDATE FGNN_19.Cruceros
	SET baja_vida_util = 1, fecha_baja_definitiva = @fechaBaja
	WHERE id = @idCrucero

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Baja_temporal_crucero (@idCrucero numeric(18,0), @fechaBaja datetime2(3), @fechaReinicio datetime2(3))
AS
BEGIN TRANSACTION

	UPDATE FGNN_19.Cruceros
	SET baja_servicio = 1, fecha_fuera_servicio = @fechaBaja, fecha_reinicio_servicio = @fechaReinicio
	WHERE id = @idCrucero

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Actualizacion_reinicio_cruceros
AS
BEGIN TRANSACTION

	UPDATE FGNN_19.Cruceros
	SET baja_servicio = 0, fecha_fuera_servicio = NULL, fecha_reinicio_servicio = NULL
	WHERE baja_servicio = 1 AND fecha_reinicio_servicio <= CONVERT(datetime2(3), GETDATE())

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Cancelar_pasajes_crucero(@idCrucero NUMERIC(18,0), @motivo VARCHAR(255))
AS
BEGIN TRANSACTION
	
	INSERT INTO FGNN_19.Pasajes_Cancelados(id_pasaje, fecha_cancelacion, motivo)
	SELECT pasaje_codigo, CONVERT(datetime2(3), GETDATE()), @motivo
	FROM Cabinas
	WHERE crucero_id = @idCrucero

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Reemplazar_crucero(@idCrucero NUMERIC(18,0))
AS
BEGIN TRANSACTION

	DECLARE @idReemplazo NUMERIC(18,0)

	SET @idReemplazo = FGNN_19.FN_Crucero_reemplazante(@idCrucero)

	IF(@idReemplazo IS NULL)
		BEGIN
			RAISERROR('ERROR: El crucero no puede ser reemplazado por ningun crucero existente, debe dar de alta uno nuevo para poder reemplazarlo',1,1)
			RETURN -1
		END

	UPDATE Cabinas
	SET crucero_id = @idReemplazo
	WHERE crucero_id = @idCrucero AND (SELECT v.fecha_inicio
		FROM Pasajes p
			JOIN Viajes v ON v.codigo = p.viaje_codigo
		WHERE p.id = pasaje_codigo) >= CONVERT(datetime2(3), GETDATE()) AND FGNN_19.FN_Pasaje_no_cancelado(pasaje_codigo) = 1

	UPDATE Viajes
	SET crucero_id = @idReemplazo
	WHERE crucero_id = @idCrucero AND fecha_inicio >= CONVERT(datetime2(3), GETDATE()) AND EXISTS(SELECT 1 FROM Pasajes WHERE viaje_codigo = codigo AND FGNN_19.FN_Pasaje_no_cancelado(id) = 1)

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.Reeprogramar_viajes_crucero(@idCrucero NUMERIC(18,0), @cantidadDias INT)
AS
BEGIN TRANSACTION

	UPDATE Viajes
	SET fecha_inicio = DATEADD(DAY, @cantidadDias, fecha_inicio), fecha_fin = DATEADD(DAY, @cantidadDias, fecha_fin)
	WHERE crucero_id = @idCrucero AND fecha_inicio >= CONVERT(datetime2(3), GETDATE()) AND EXISTS(SELECT 1 FROM Pasajes WHERE viaje_codigo = codigo AND FGNN_19.FN_Pasaje_no_cancelado(id) = 1)

COMMIT TRANSACTION;
GO

CREATE PROCEDURE FGNN_19.TOP5_recorridos_mas_comprados(@anio INT, @semestre INT)
AS
BEGIN
DECLARE @QUERY_FINAL NVARCHAR(1500)
DECLARE @QUERY_1 VARCHAR(200) = 'SELECT TOP 5 ps.descripcion AS [Puerto de salida], pl.descripcion [Puerto de llegada], COUNT(*) AS [Cantidad de pasajes vendidos]'
DECLARE @QUERY_2 VARCHAR(200) = ' FROM FGNN_19.Pasajes p JOIN FGNN_19.Viajes v ON v.codigo = p.viaje_codigo JOIN FGNN_19.Recorridos r ON r.id = v.recorrido_codigo'
DECLARE @QUERY_3 VARCHAR(200) = ' JOIN FGNN_19.Compras c ON c.codigo = p.compra_codigo JOIN FGNN_19.Puertos ps ON ps.id = r.puerto_desde_id JOIN FGNN_19.Puertos pl ON pl.id = r.puerto_hasta_id '
DECLARE @QUERY_4 VARCHAR(200)
DECLARE @QUERY_5 VARCHAR(200) = ' GROUP BY r.id, ps.descripcion, pl.descripcion ORDER BY [Cantidad de pasajes vendidos] DESC'

		IF @semestre = 1
			SET @QUERY_4 = 'WHERE YEAR(c.fecha) = @anio AND MONTH(c.fecha) IN (1, 2, 3, 4, 5, 6)'
		ELSE
			SET @QUERY_4 = 'WHERE YEAR(c.fecha) = @anio AND MONTH(c.fecha) IN (7, 8, 9, 10, 11, 12)'
	SET @QUERY_FINAL = @QUERY_1 + @QUERY_2 + @QUERY_3 + @QUERY_4 + @QUERY_5
	EXEC sp_executesql @QUERY_FINAL, N'@anio INT, @semestre INT', @anio, @semestre

END
GO

CREATE PROCEDURE FGNN_19.Anios_TOP5_recorridos_mas_comprados
AS
BEGIN
	SELECT DISTINCT YEAR(c.fecha) AS anio
	FROM FGNN_19.Compras c 
	JOIN FGNN_19.Pasajes p
	ON (c.codigo = p.compra_codigo)
END
GO

CREATE PROCEDURE FGNN_19.TOP5_recorridos_mas_cabinas_libres(@anio INT, @semestre INT)
AS
BEGIN
DECLARE @QUERY_FINAL NVARCHAR(1500)
DECLARE @QUERY_1 VARCHAR(200) = 'SELECT TOP 5 ps.descripcion AS [Puerto de salida], pl.descripcion AS [Puerto de llegada], COUNT(*) AS [Cantidad de cabinas libres]'
DECLARE @QUERY_2 VARCHAR(200) = ' FROM FGNN_19.Cabinas c JOIN FGNN_19.Pasajes p ON p.id = c.pasaje_codigo JOIN FGNN_19.Viajes v ON v.codigo = p.viaje_codigo'
DECLARE @QUERY_3 VARCHAR(200) = ' JOIN FGNN_19.Recorridos r ON r.codigo = v.recorrido_codigo JOIN FGNN_19.Puertos ps ON ps.id = r.puerto_desde_id JOIN FGNN_19.Puertos pl ON pl.id = r.puerto_hasta_id'
DECLARE @QUERY_4 VARCHAR(200) = ' WHERE c.estado = 0 AND '
DECLARE @QUERY_5 VARCHAR(200)
DECLARE @QUERY_6 VARCHAR(200) = ' GROUP BY r.codigo, ps.descripcion, pl.descripcion ORDER BY [Cantidad de cabinas libres] DESC'
	
	IF @semestre = 1
			SET @QUERY_5 = 'YEAR(v.fecha_fin) = @anio AND MONTH(v.fecha_fin) IN (1, 2, 3, 4, 5, 6)'
		ELSE
			SET @QUERY_5 = 'YEAR(v.fecha_fin) = @anio AND MONTH(v.fecha_fin) IN (7, 8, 9, 10, 11, 12)'
	SET @QUERY_FINAL = @QUERY_1 + @QUERY_2 + @QUERY_3 + @QUERY_4 + @QUERY_5 + @QUERY_6
	EXEC sp_executesql @QUERY_FINAL, N'@anio INT, @semestre INT', @anio, @semestre

END
GO

CREATE PROCEDURE FGNN_19.Anios_TOP5_recorridos_mas_cabinas_libres
AS
BEGIN
	SELECT DISTINCT YEAR(v.fecha_fin) AS anio
	FROM FGNN_19.Viajes v 
	JOIN FGNN_19.Pasajes p
	ON (v.codigo = p.viaje_codigo)
END
GO

CREATE PROCEDURE FGNN_19.TOP5_cruceros_mas_dias_fuera_servicio(@anio INT, @semestre INT)
AS
BEGIN
DECLARE @QUERY_FINAL NVARCHAR(1500)
DECLARE @QUERY_1 VARCHAR(200) = 'SELECT TOP 5 nombre, modelo, DATEDIFF(DAY, fecha_fuera_servicio, CONVERT(DATETIME2(3),GETDATE())) AS [Dias fuera de servicio]'
DECLARE @QUERY_2 VARCHAR(200) = ' FROM FGNN_19.Cruceros WHERE fecha_reinicio_servicio < CONVERT(DATETIME2(3),GETDATE()) AND ' 
DECLARE @QUERY_3 VARCHAR(200)
DECLARE @QUERY_4 VARCHAR(200) = ' GROUP BY id, nombre, modelo, fecha_fuera_servicio ORDER BY [Dias fuera de servicio] DESC'

	IF @semestre = 1
			SET @QUERY_3 = 'YEAR(fecha_fuera_servicio) = @anio AND MONTH(fecha_fuera_servicio) IN (1, 2, 3, 4, 5, 6)'
		ELSE
			SET @QUERY_3 = 'YEAR(fecha_fuera_servicio) = @anio AND MONTH(fecha_fuera_servicio) IN (7, 8, 9, 10, 11, 12)'
	SET @QUERY_FINAL = @QUERY_1 + @QUERY_2 + @QUERY_3 + @QUERY_4
	EXEC sp_executesql @QUERY_FINAL, N'@anio INT, @semestre INT', @anio, @semestre

END
GO

CREATE PROCEDURE FGNN_19.Anios_TOP5_cruceros_mas_dias_fuera_servicio
AS
BEGIN
	SELECT DISTINCT YEAR(fecha_fuera_servicio) AS anio
	FROM FGNN_19.Cruceros
END
GO


-- Triggers

CREATE TRIGGER FGNN_19.TR_Roles_InsteadOfDelete ON FGNN_19.Roles
INSTEAD OF DELETE
AS

BEGIN TRANSACTION

UPDATE FGNN_19.Roles
SET habilitado = 0
WHERE id IN (SELECT id FROM DELETED)

DELETE FROM FGNN_19.Usuarios_Roles
WHERE rol_id IN (SELECT id FROM DELETED)

COMMIT;
GO

CREATE TRIGGER FGNN_19.TR_Recorridos_AfterUpdate ON FGNN_19.Recorridos
AFTER UPDATE
AS
BEGIN TRANSACTION

UPDATE FGNN_19.Recorridos
SET habilitado = 1
WHERE id IN (SELECT i.id FROM INSERTED i, FGNN_19.Viajes v
			 WHERE i.habilitado = 0
			 AND i.id = v.recorrido_codigo
			 AND v.fecha_inicio > CONVERT(datetime2(3), GETDATE()))

COMMIT TRANSACTION;
GO

