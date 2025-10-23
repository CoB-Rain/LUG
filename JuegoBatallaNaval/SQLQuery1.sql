CREATE PROC USUARIO_INSERTAR
@nom varchar(50), @pass varchar(50)
as
BEGIN
	declare @id int
	set @id = (select isnull(max(ID_USUARIO), 0) + 1 from USUARIO)

	 INSERT INTO USUARIO (ID_USUARIO, NOMBRE, CONTRASEÑA) VALUES (@id, @nom, @pass)
END