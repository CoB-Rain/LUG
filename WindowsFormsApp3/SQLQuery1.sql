CREATE PROC TITULO_INSERTAR --crear procedimiento almacenado llamado "TITULO_INSERTAR"
@titulo varchar(50) --parametros que va a recibir mi procedimiento
as
BEGIN
	--declaro la variable @id con la palabra reservada "declare"
	declare @id int
	--para asignarle un valor a mi variable se usa la palabra reservada "set"
	set @id = (select isnull(max(id), 0) + 1 from titulo)

	INSERT INTO TITULO (ID, DESCRIPCION) VALUES (@id, @titulo)
END
