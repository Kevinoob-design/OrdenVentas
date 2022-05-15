--Creando la base de datos, practica final modulo 2 del grupo 3-----

create database OrdenVentasDB
use OrdenVentasDB

--------------------------Creando las 7 tablas de la practica -----------------------

--------------Tabla 1 "Categoria"---------------

CREATE TABLE CATEGORIA 
(
IDCATEGORIA INT PRIMARY KEY IDENTITY,
NOMBRE VARCHAR(50) not null UNIQUE,
DESCRIPCION VARCHAR(256) null,
ESTADO BIT DEFAULT(1)
)

--------------Tabla 2 "Articulo"---------------

CREATE TABLE ARTICULO 
(
IDARTICULO int primary key IDENTITY,
IDCATEGORIA INT NOT NULL constraint FK_IDCATEGORIA foreign key 
(IDCATEGORIA) References CATEGORIA(IDCATEGORIA),
CODIGO VARCHAR(50),
NOMBRE VARCHAR(100) NOT NULL UNIQUE,
PRECIO_VENTA FLOAT NOT NULL,
STOCK INT NOT NULL,
DESCRIPCION VARCHAR(256) NULL,
ESTADO BIT DEFAULT(1)
)

--------------Tabla 3 "CLiEntes"---------------

CREATE TABLE CLIENTES
(
IDCLIENTE INT PRIMARY KEY IDENTITY,
TIPO_CLIENTE VARCHAR(20) NOT NULL,
NOMBRE VARCHAR(100) NOT NULL,
TIPO_DOCUMENTO VARCHAR(20) NULL,
NUM_DOCUMENTO VARCHAR(20) NULL,
DIRECCION VARCHAR(70) NULL,
TELEFONO VARCHAR(20) NULL,
EMAIL VARCHAR(50) NULL,
)

--------------Tabla 4 "ROL"---------------

CREATE TABLE ROL
(
IDROL INT PRIMARY KEY IDENTITY,
NOMBRE VARCHAR(100) NOT NULL,
DESCRIPCION VARCHAR(100) NOT NULL,
ESTADO BIT DEFAULT 1
)

--------------Tabla 5 "USUARIO"---------------

CREATE TABLE USUARIO
(
IDUSUARIO INT PRIMARY KEY IDENTITY,
NOMBRE VARCHAR(20) NOT NULL,
IDROL INT NOT NULL constraint FK_IDROL foreign key,
(IDROL) References ROL(IDROL),
USUARIO VARCHAR(100) NOT NULL,
[PASSWORD] VARBINARY(25) NOT NULL,
NUM_DOCUMENTO VARCHAR(20) NULL,
DIRECCION VARCHAR(70) NULL,
TELEFONO VARCHAR(20) NULL,
EMAIL VARCHAR(50) NULL,
ESTADO BIT DEFAULT 1
)

--------------Tabla 6 "VENTA"---------------

CREATE TABLE VENTA
(
IDVENTA INT PRIMARY KEY IDENTITY,
IDCLIENTE INT NOT NULL constraint FK_IDCLIENTE foreign key 
(IDCLIENTE) References CLIENTES(IDCLIENTE),
IDUSUARIO INT NOT NULL constraint FK_IDUSUARIO foreign key 
(IDUSUARIO) References USUARIO(IDUSUARIO),
TIPO_COMPROBANTE VARCHAR(20) NOT NULL,
SERIE_COMPROBANTE VARCHAR(7) NOT NULL,
NUM_COMPROBANTE VARCHAR(10) NOT NULL,
FECHA_HORA DATETIME NOT NULL,
IMPUESTO FLOAT NOT NULL,
TOTAL FLOAT NOT NULL,
ESTADO VARCHAR(20) NOT NULL,
)

--------------Tabla 7 "DETALLE_VENTA"---------------

CREATE TABLE DETALLE_VENTA
(
IDDETALLE INT PRIMARY KEY IDENTITY,
IDVENTA INT NOT NULL constraint FK_IDVENTA foreign key 
(IDVENTA) References VENTA(IDVENTA),
IDARTICULO INT NOT NULL constraint FK_IDARTICULO foreign key 
(IDARTICULO) References ARTICULO(IDARTICULO)
ON UPDATE CASCADE
ON DELETE CASCADE,
PRECIO FLOAT NOT NULL,
DESCUENTO FLOAT NOT NULL
)