CREATE PROC PERSONA_INSERTAR
@nom varchar(50), @ape varchar(50)
as
BEGIN
	declare @id int
	set @id = (select isnull(max(id), 0) +1 from PERSONA)

	insert into PERSONA (ID, NOMBRE, APELLIDO) values (@id,@nom,@ape)
END