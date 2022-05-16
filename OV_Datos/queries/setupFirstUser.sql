use OrdenVentasDB
go

exec guardarRol 'Admin', 'Vendedor'

insert into USUARIO
values(1, 'Admin', CONVERT(varbinary, 'Admin'), 'Hector', '123456780', 'Calle 1A', '849-123-4567', 'email@hotmail.com', 1)

exec consultarUsuario

select * from DETALLE_VENTA

exec consultarDetalleVentas