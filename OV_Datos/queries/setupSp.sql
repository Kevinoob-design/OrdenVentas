use OrdenVentasDB
go

create proc guardarCategoria

	@NOMBRE VARCHAR(50),
	@DESCRIPCION VARCHAR(256)
as
insert into CATEGORIA
values(@NOMBRE, @DESCRIPCION, 1)
go

create proc guardarArticulo

	@IDCATEGORIA INT,
	@CODIGO VARCHAR(50),
	@NOMBRE VARCHAR(100),
	@PRECIO_VENTA FLOAT,
	@STOCK INT,
	@DESCRIPCION VARCHAR,
	@ESTADO BIT
as
insert into ARTICULO
values(@IDCATEGORIA, @CODIGO, @NOMBRE, @PRECIO_VENTA, @STOCK, @DESCRIPCION, 1)
go

create proc guardarCliente

	@TIPO_PERSONA VARCHAR,
	@NOMBRE VARCHAR(100),
	@TIPO_DOCUMENTO VARCHAR,
	@NUM_DOCUMENTO VARCHAR,
	@DIRECCION VARCHAR(70),
	@TELEFONO VARCHAR(20),
	@EMAIL VARCHAR(50)
as
insert into ARTICULO
values(@TIPO_PERSONA, @NOMBRE, @TIPO_DOCUMENTO, @NUM_DOCUMENTO, @DIRECCION, @TELEFONO, @EMAIL)
go

create proc guardarRol

	@NOMBRE VARCHAR(100),
	@DESCRIPCION VARCHAR(100)
as
insert into ROL
values(@NOMBRE, @DESCRIPCION, 1)
go

create proc guardarVenta 

    @IDCLIENTE INT,
    @IDUSUARIO INT,
    @TIPO_COMPROBANTE VARCHAR(20),
    @SERIE_COMPROBANTE VARCHAR(7),
    @NUM_COMPROBANTE VARCHAR(10),
    @FECHA_HORA DATETIME,
    @IMPUESTO FLOAT,
    @TOTAL FLOAT,
    @ESTADO VARCHAR(20) 
as
insert into VENTA
values(@IDCLIENTE, @IDUSUARIO, @TIPO_COMPROBANTE, @SERIE_COMPROBANTE, @NUM_COMPROBANTE, @FECHA_HORA, @IMPUESTO, @TOTAL, @ESTADO)
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

create proc consultarUsuario

	@USUARIO VARCHAR(100),
	@PASSWORD VARCHAR(25)

as
	select * from USUARIO where USUARIO = @USUARIO and PASSWORD = CONVERT(VARBINARY, @PASSWORD)
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