CREATE PROC USUARIO_EDITAR
@id int, @nom varchar(50), @pass varchar(50)
as
BEGIN
	UPDATE USUARIO SET
	NOMBRE = @nom,
	CONTRASEÑA = @pass
	WHERE ID_USUARIO = @id
END