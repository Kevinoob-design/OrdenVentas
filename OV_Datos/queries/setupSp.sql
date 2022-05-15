use OrdenVentasDB
go

create proc guardarCategoria

	@NOMBRE VARCHAR(50),
	@DESCRIPCION VARCHAR(256),
	@ESTADO BIT = 1
as
insert into CATEGORIA
values(@NOMBRE, @DESCRIPCION, @ESTADO)
go

create proc guardarArticulo

	@IDCATEGORIA INT,
	@CODIGO VARCHAR(50),
	@NOMBRE VARCHAR(100),
	@PRECIO_VENTA FLOAT,
	@STOCK INT,
	@DESCRIPCION VARCHAR,
	@ESTADO BIT = 1
as
insert into ARTICULO
values(@IDCATEGORIA, @CODIGO, @NOMBRE, @PRECIO_VENTA, @STOCK, @DESCRIPCION, @ESTADO)
go

create proc guardarCliente

	@NOMBRE VARCHAR(100),
	@TIPO_CLIENTE VARCHAR(20),
	@TIPO_DOCUMENTO VARCHAR(20),
	@NUM_DOCUMENTO VARCHAR(20),
	@DIRECCION VARCHAR(70),
	@TELEFONO VARCHAR(20),
	@EMAIL VARCHAR(50)
as
insert into CLIENTES
values(@TIPO_CLIENTE, @NOMBRE, @TIPO_DOCUMENTO, @NUM_DOCUMENTO, @DIRECCION, @TELEFONO, @EMAIL)
go

create proc actualizarCliente
	
	@IDCLIENTE INT,
	@NOMBRE VARCHAR(100),
	@TIPO_CLIENTE VARCHAR(20),
	@TIPO_DOCUMENTO VARCHAR(20),
	@NUM_DOCUMENTO VARCHAR(20),
	@DIRECCION VARCHAR(70),
	@TELEFONO VARCHAR(20),
	@EMAIL VARCHAR(50)
as
update CLIENTES
set
	NOMBRE = @NOMBRE,
	TIPO_CLIENTE = @TIPO_CLIENTE,
	TIPO_DOCUMENTO = @TIPO_DOCUMENTO,
	NUM_DOCUMENTO = @NUM_DOCUMENTO,
	DIRECCION = @DIRECCION,
	TELEFONO = @TELEFONO,
	EMAIL = @EMAIL

	where IDCLIENTE = @IDCLIENTE
go

create proc actualizarCategoria
	
	@IDCATEGORIA INT,
	@NOMBRE VARCHAR(50),
	@DESCRIPCION VARCHAR(256),
	@ESTADO BIT
as
update CATEGORIA
set
	NOMBRE = @NOMBRE,
	DESCRIPCION = @DESCRIPCION,
	ESTADO = @ESTADO

	where IDCATEGORIA = @IDCATEGORIA
go

create proc guardarRol

	@NOMBRE VARCHAR(100),
	@DESCRIPCION VARCHAR(100)
as
insert into ROL
values(@NOMBRE, @DESCRIPCION, 1)
go

create proc guardarDetalleVenta 

	@IDVENTA INT,
	@IDARTICULO INT,
	@PRECIO FLOAT,
	@DESCUENTO FLOAT
as
insert into DETALLE_VENTA
values(@IDVENTA, @IDARTICULO, @PRECIO, @DESCUENTO)
go

create proc guardarVenta 

    @IDCLIENTE INT,
    @IDUSUARIO INT,
	@IDARTICULO INT,
    @TIPO_COMPROBANTE VARCHAR(20),
    @SERIE_COMPROBANTE VARCHAR(7),
    @NUM_COMPROBANTE VARCHAR(10),
    @IMPUESTO FLOAT,
    @TOTAL FLOAT,
    @ESTADO VARCHAR(20) = 'Validada',
	@DESCUENTO FLOAT
as

DECLARE @IDVENTA INT;

insert into VENTA
values(@IDCLIENTE, @IDUSUARIO, @TIPO_COMPROBANTE, @SERIE_COMPROBANTE, @NUM_COMPROBANTE, GETDATE(), @IMPUESTO, @TOTAL, @ESTADO)

SET @IDVENTA = SCOPE_IDENTITY()

select PRECIO_VENTA from ARTICULO where IDARTICULO = @IDARTICULO

exec guardarDetalleVenta @IDVENTA, @IDARTICULO, PRECIO_VENTA, @DESCUENTO
go

create proc login

	@USUARIO VARCHAR(100),
	@PASSWORD VARCHAR(25)

as
	select * from USUARIO where USUARIO = @USUARIO and PASSWORD = CONVERT(VARBINARY, @PASSWORD)
go

create proc consultarUsuario

	@ID INT = null
as
	if @ID is not null
		select * from USUARIO where IDUSUARIO = @ID
	else
		select * from USUARIO
go

create proc consultarClientes

	@ID INT = null
as
	if @ID is not null
		select * from CLIENTES where IDCLIENTE = @ID
	else
		select * from CLIENTES
go

create proc consultarVentas

	@ID INT = null
as
	if @ID is not null
		select * from VENTA where IDVENTA = @ID
	else
		select * from VENTA
go

create proc consultarCategoria

	@IDCATEGORIA INT = null
as
	if @IDCATEGORIA is not null
		select * from CATEGORIA where IDCATEGORIA = @IDCATEGORIA
	else
		select * from CATEGORIA
go

create proc consultarArticulo

	@IDARTICULO INT = null
as
	if @IDARTICULO is not null
		select * from ARTICULO where IDARTICULO = @IDARTICULO
	else
		select * from ARTICULO
go

create proc actualizarArticulo
	
	@IDARTICULO INT,
	@IDCATEGORIA INT,
	@CODIGO VARCHAR(50),
	@NOMBRE VARCHAR(100),
	@PRECIO_VENTA FLOAT,
	@STOCK INT,
	@DESCRIPCION VARCHAR,
	@ESTADO BIT = 1
as
update ARTICULO
set
	IDCATEGORIA = @IDCATEGORIA,
	CODIGO = @CODIGO,
	NOMBRE = @NOMBRE,
	PRECIO_VENTA = @PRECIO_VENTA,
	STOCK = @STOCK,
	DESCRIPCION = @DESCRIPCION,
	ESTADO = @ESTADO

	where IDARTICULO = @IDARTICULO
go