INSERT INTO BECA (ID_BECA,DESCRIPCION) VALUES (1, '50%')
INSERT INTO BECA (ID_BECA,DESCRIPCION) VALUES (2, '70%')
INSERT INTO BECA (ID_BECA,DESCRIPCION) VALUES (3, '100%')

SELECT * FROM BECA

INSERT INTO	ALUMNO (ID_ALUMNO,NOMBRE) VALUES (1,'Christian')
INSERT INTO	ALUMNO (ID_ALUMNO,NOMBRE) VALUES (2,'Gael')
INSERT INTO	ALUMNO (ID_ALUMNO,NOMBRE) VALUES (3,'Cloe')
INSERT INTO	ALUMNO (ID_ALUMNO,NOMBRE) VALUES (4,'Susy')
INSERT INTO	ALUMNO (ID_ALUMNO,NOMBRE) VALUES (5,'Ana')
INSERT INTO	ALUMNO (ID_ALUMNO,NOMBRE) VALUES (6,'Gaston')

--INNER JOIN: incluye los registros que tienen un valor coincidente en ambas tablas
SELECT a.ID_ALUMNO, a.NOMBRE, b.ID_BECA, b.DESCRIPCION FROM ALUMNO a
INNER JOIN ALUMNO_BECA ab on a.ID_ALUMNO = ab.ID_ALUMNO
INNER JOIN BECA b on ab.ID_BECA = b.ID_BECA
WHERE a.NOMBRE like 'SU%'--criterio de busqueda

SELECT * FROM VISTA_ALUMNOBECADO
WHERE NOMBRE like 'SU%'

--LEFT JOIN: Devuelve todos los registros de la tabla izquierda
--(la que se menciona primero en la consulta),
--y los registros correspondientes de la tabla derecha.
--Si no hay una coincidencia en la tabla derecha,
--se rellenan las columnas de esa tabla con valores NULL
SELECT a.ID_ALUMNO, a.NOMBRE, b.ID_BECA, b.DESCRIPCION FROM ALUMNO a
LEFT JOIN ALUMNO_BECA ab on a.ID_ALUMNO = ab.ID_ALUMNO
LEFT JOIN BECA b on ab.ID_BECA = b.ID_BECA

--CAMPOS FICTICIOS (COLUMNA FAKE)
SELECT a.ID_ALUMNO,
a.NOMBRE,
'CODIGO BECA' = case when b.ID_BECA is null then
				0
			else
				b.ID_BECA
			end,
'DESCRIPCION' = case when b.DESCRIPCION is null then
					''
				else
					b.DESCRIPCION
				end
FROM ALUMNO a
LEFT JOIN ALUMNO_BECA ab on a.ID_ALUMNO = ab.ID_ALUMNO
LEFT JOIN BECA b on ab.ID_BECA = b.ID_BECA