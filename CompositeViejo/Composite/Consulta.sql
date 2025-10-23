--TODOS LOS PERMISOS

SELECT * FROM PERMISO

-- SOLO LOS PERMISOS

SELECT * FROM PERMISO p
LEFT JOIN GRUPO g on g.ID_GRUPO = p.ID_PERMISO 
WHERE ID_GRUPO is null


-- SOLO LOS GRUPOS

SELECT distinct p.ID_PERMISO,p.NOMBRE FROM PERMISO p
INNER JOIN GRUPO g on g.ID_GRUPO = p.ID_PERMISO 

--GLOBAL

select distinct p.id_permiso, p.NOMBRE, 
		'GRUPO' = case when g.ID_GRUPO is null then
			'NO'
			else
			'SI'
			END
from PERMISO p
Left join GRUPO g on g.ID_GRUPO = p.ID_PERMISO


--GLOBAL MASIVA

select p.id_permiso, p.NOMBRE, 
		'GRUPO' = case when g.ID_GRUPO is null then
			'NO'
			else
			'SI'
			END,
		ph.ID_PERMISO,
		ph.NOMBRE
from PERMISO p
Left join GRUPO g on g.ID_GRUPO = p.ID_PERMISO
LEFT JOIN PERMISO ph on g.ID_HIJO = ph.ID_PERMISO