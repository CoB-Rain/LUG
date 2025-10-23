CREATE PROC USUARIO_BUSCAR
@nom varchar(50), @pass varchar(50)
as
BEGIN
	select ID_USUARIO, NOMBRE, CONTRASEÑA from USUARIO
	where NOMBRE = @nom and CONTRASEÑA = @pass
END