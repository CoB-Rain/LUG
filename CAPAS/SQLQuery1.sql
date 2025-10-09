CREATE PROC producto_insertar
@Nombre varchar(50), @precio float
as
begin

	declare @id int = (select isnull(max(id_producto), 0) +1 from producto)

	insert into PRODUCTO values (@id,@Nombre,@precio)

end

go

CREATE PROC producto_editar
@id int, @Nombre varchar(50), @precio float
as
begin

	update PRODUCTO set
	NOMBRE = @Nombre,
	PRECIO = @precio
	where ID_PRODUCTO = @id

end

go

CREATE PROC producto_borrar
@id int
as
begin

	delete from PRODUCTO
	where ID_PRODUCTO = @id

end

go

CREATE PROC producto_listar
as
begin

	select * from PRODUCTO

end
