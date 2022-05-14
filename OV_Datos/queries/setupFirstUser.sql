use OrdenVentasDB
go

exec guardarRol 'Admin', 'Usuario Maestro'

insert into USUARIO
values(1, 'Admin', CONVERT(VARBINARY, 'Admin'), '402-1234567-8', 'Calle 1 A', '809-123-4567', 'admin@email.com', 1)

exec guardarCategoria 'Prueba 2', 'Categoria 1', 0

