USE LOPO;
CREATE TABLE ALUMNO
(
	LEGAJO INT,
	NOMBRE VARCHAR(100)
)
GO
CREATE TABLE ASIGNATURA
(
	ID INT,
	DENOMINACION VARCHAR(100)
)
GO
CREATE TABLE ALUM_ASIG
(
	LEGAJO INT,
	ID INT,
	NOTA INT
)
GO
USE LOPO;
GO

-- Limpiar si ya existen
DELETE FROM ALUM_ASIG;
DELETE FROM ALUMNO;
DELETE FROM ASIGNATURA;

-- ======================
-- 1. Alumnos
-- ======================
INSERT INTO ALUMNO (LEGAJO, NOMBRE) VALUES
(1001, 'Juan Pérez'),
(1002, 'María López'),
(1003, 'Carlos Gómez'),
(1004, 'Ana Torres'),
(1005, 'Luis Fernández');

-- ======================
-- 2. Asignaturas
-- ======================
INSERT INTO ASIGNATURA (ID, DENOMINACION) VALUES
(1, 'Matemática'),
(2, 'Historia'),
(3, 'Lengua'),
(4, 'Física'),
(5, 'Química');

-- ======================
-- 3. Relación Alumno–Asignatura (Alum_Asig)
-- Cada alumno cursa materias distintas, sin repetir materia
-- ======================
INSERT INTO ALUM_ASIG (LEGAJO, ID, NOTA) VALUES
(1001, 1, '8'),   -- Juan - Matemática
(1001, 2, '7'),   -- Juan - Historia
(1002, 3, '9'),   -- María - Lengua
(1002, 4, '10'),  -- María - Física
(1003, 5, '6'),   -- Carlos - Química
(1003, 1, '7'),   -- Carlos - Matemática
(1004, 2, '8'),   -- Ana - Historia
(1004, 3, '9'),   -- Ana - Lengua
(1005, 4, '6'),   -- Luis - Física
(1005, 5, '7');   -- Luis - Química
