CREATE PROC USUARIO_AÑADIR_JUGADOR
@id int
as
BEGIN
	declare @id_j int
	set @id_j = (select isnull(max(ID_JUGADOR), 0) + 1 FROM JUGADOR)
	exec JUGADOR_INSERTAR @id_j
	INSERT INTO USUARIO_JUGADOR (ID_U, ID_J) VALUES (@id, @id_j)
END