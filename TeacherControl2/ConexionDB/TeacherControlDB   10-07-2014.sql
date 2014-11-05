use master
Drop Database TeacherControlDb
go
Create Database TeacherControlDb
go

 use TeacherControlDB
 go
 
Create table Estudiantes(IdEstudiante int primary key identity(1,1),Matricula varchar(9),
Nombres Varchar(40) not null,Apellidos  Varchar(40) not null,
 Direccion Varchar(100), Genero tinyint, FechaNacimiento date,Email varchar(100), Telefono1 varchar(12)
 , Telefono2 varchar(12) ) 
 go
 --del orbe
 Create Table Profesores(IdProfesor int primary key identity(1,1),
Nombres Varchar(40) not null,Apellidos  Varchar(40) not null,
 Direccion Varchar(100), Genero tinyint, FechaNacimiento date,Email varchar(100), Telefono1 varchar(12)
 , Telefono2 varchar(12))

--CREAR TABLA USUARIOS

go
--Brauny
create table Asignaturas(
	IdAsignatura int identity(1,1) primary key NOT NULL,
	Codigo int NOT NULL,
	Nombre varchar(30) NOT NULL,
	Ceditos int not null,
	Activo bit NOT NULL
)


go
--Jean luis
Create Table Semestres(IdSemestre int identity(1,1) primary key NOT NULL,
Codigo varchar(6),
FechaInicio date,
FechaFin date,
FechaParcial1 date,
FechaParcial2 date,
FechaFinal date,
Activo bit)


 



--go
----JAN LUIS
--Create table Inscripciones(IdInscripcion int identity(1,1) primary key NOT NULL,
--Fecha datetime  not null,
--IdProfesor int  not null,
--IdSemestre int not null,
--IdAsignatura int not null,
--IdSeccion int not null)
--go

--Create table InscripcionesDetalle(Id int identity(1,1) primary key NOT NULL,
--IdInscripcion int not null,
--IdEstudiante int not null)

go
--BRAUNY
Create table Evaluaciones(IdEvaluacion int identity(1,1) primary key NOT NULL,
IdSemestre int not null,
IdAsignatura int  not null,
IdProfesor int not null)

Create Table EvaluacionesDetalle(Id  int identity(1,1) primary key NOT NULL,
IdEvaluacion int,
Descripcion varchar(100) not null,
Puntuacion int not null)

--Del Orbe
create table Asistencias(
	IdAsistencia int identity (1,1) primary key NOT NULL, 
	Fecha date NOT NULL,
	IdSemestre int not null,
	IdAsignatura int NOT NULL,
	IdSeccion int NOT NULL
)

go
Create table AsistenciasDetalle(Id int identity (1,1) primary key NOT NULL,
IdAsistencia int not null,
IdEstudiante Int not null,
Calificacion int not null)--puede ser 0 -no asistio, 0.5 - excusa,1 -asistio.



--Fenir
go
Create Table Tareas( IdTarea int identity(1,1) primary key NOT NULL,
CodigoTarea varchar(10) not null,
Fecha datetime  not null,
Vence datetime not null,
IdSemestre int not null,
IdAsignatura int not null,
IdSeccion int not null,
Descripcion varchar(200)  not null)

go
Create Table TareasDetalle(Id int identity(1,1) primary key NOT NULL,
IdTarea Int  not null,
IdEstudiante int not null,
Calificacion int not null)


--Antony y crear tabla usuarios, hacer el login
go
Create Table Calificaciones(IdCalificacion int identity(1,1) primary key NOT NULL,
Fecha datetime  not null,
IdSemestre int not null,
IdAsignatura int not null,
IdSeccion int not null,
IdEvaluacion int not null)

Create Table CalificacionesDetalle (Id int identity(1,1) primary key NOT NULL,
IdEstudiante int not null,
IdCalificacion int not null,
Calificacion int not null)
go

go
--del orbe
Create table Deudas(IdDeuda int identity(1,1) primary key NOT NULL,
Fecha datetime not null,
Vence Datetime not null,
IdSemestre int not null,
IdEstudiante int not null,
IdAsignatura int not null,
Cantidad int not null,
Balance Int not null)

go
--fenir
Create Table PagosDeudas(IdPago int identity(1,1) primary key NOT NULL,
Fecha datetime not null,
IdEstudiante int not null,
IdAsignatura int not null,
IdDeuda int not null,
CantidadPagada Int not null)


--- RELACIONES ENTRE TABLAS

BEGIN TRANSACTION
GO
ALTER TABLE dbo.Secciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Asignaturas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Tareas ADD CONSTRAINT
	FK_Tareas_Asignaturas FOREIGN KEY
	(
	IdAsignatura
	) REFERENCES dbo.Asignaturas
	(
	IdAsignatura
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Tareas ADD CONSTRAINT
	FK_Tareas_Secciones FOREIGN KEY
	(
	IdSeccion
	) REFERENCES dbo.Secciones
	(
	IdSeccion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Tareas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Profesores SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Evaluaciones ADD CONSTRAINT
	FK_Evaluaciones_Asignaturas FOREIGN KEY
	(
	IdAsignatura
	) REFERENCES dbo.Asignaturas
	(
	IdAsignatura
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Evaluaciones ADD CONSTRAINT
	FK_Evaluaciones_Profesores FOREIGN KEY
	(
	IdProfesor
	) REFERENCES dbo.Profesores
	(
	IdProfesor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Evaluaciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Calificaciones ADD CONSTRAINT
	FK_Calificaciones_Evaluaciones FOREIGN KEY
	(
	IdEvaluacion
	) REFERENCES dbo.Evaluaciones
	(
	IdEvaluacion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Calificaciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.EvaluacionesDetalle ADD CONSTRAINT
	FK_EvaluacionesDetalle_Evaluaciones FOREIGN KEY
	(
	IdEvaluacion
	) REFERENCES dbo.Evaluaciones
	(
	IdEvaluacion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.EvaluacionesDetalle SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Inscripciones ADD CONSTRAINT
	FK_Inscripciones_Secciones FOREIGN KEY
	(
	IdSeccion
	) REFERENCES dbo.Secciones
	(
	IdSeccion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Inscripciones ADD CONSTRAINT
	FK_Inscripciones_Profesores FOREIGN KEY
	(
	IdProfesor
	) REFERENCES dbo.Profesores
	(
	IdProfesor
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Inscripciones ADD CONSTRAINT
	FK_Inscripciones_Asignaturas FOREIGN KEY
	(
	IdAsignatura
	) REFERENCES dbo.Asignaturas
	(
	IdAsignatura
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Inscripciones SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Asistencias SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Estudiantes SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.CalificacionesDetalle ADD CONSTRAINT
	FK_CalificacionesDetalle_Calificaciones FOREIGN KEY
	(
	IdCalificacion
	) REFERENCES dbo.Calificaciones
	(
	IdCalificacion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CalificacionesDetalle ADD CONSTRAINT
	FK_CalificacionesDetalle_Estudiantes FOREIGN KEY
	(
	IdEstudiante
	) REFERENCES dbo.Estudiantes
	(
	IdEstudiante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.CalificacionesDetalle SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.TareasDetalle ADD CONSTRAINT
	FK_TareasDetalle_Tareas FOREIGN KEY
	(
	IdTarea
	) REFERENCES dbo.Tareas
	(
	IdTarea
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.TareasDetalle ADD CONSTRAINT
	FK_TareasDetalle_Estudiantes FOREIGN KEY
	(
	IdEstudiante
	) REFERENCES dbo.Estudiantes
	(
	IdEstudiante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.TareasDetalle SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.PagosDeudas ADD CONSTRAINT
	FK_PagosDeudas_Estudiantes FOREIGN KEY
	(
	IdEstudiante
	) REFERENCES dbo.Estudiantes
	(
	IdEstudiante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.PagosDeudas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.Deudas ADD CONSTRAINT
	FK_Deudas_Estudiantes FOREIGN KEY
	(
	IdEstudiante
	) REFERENCES dbo.Estudiantes
	(
	IdEstudiante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.Deudas SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.InscripcionesDetalle ADD CONSTRAINT
	FK_InscripcionesDetalle_Inscripciones FOREIGN KEY
	(
	IdInscripcion
	) REFERENCES dbo.Inscripciones
	(
	IdInscripcion
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.InscripcionesDetalle ADD CONSTRAINT
	FK_InscripcionesDetalle_Estudiantes FOREIGN KEY
	(
	IdEstudiante
	) REFERENCES dbo.Estudiantes
	(
	IdEstudiante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.InscripcionesDetalle SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
BEGIN TRANSACTION
GO
ALTER TABLE dbo.AsistenciasDetalle ADD CONSTRAINT
	FK_AsistenciasDetalle_Asistencias FOREIGN KEY
	(
	IdAsistencia
	) REFERENCES dbo.Asistencias
	(
	IdAsistencia
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.AsistenciasDetalle ADD CONSTRAINT
	FK_AsistenciasDetalle_Estudiantes FOREIGN KEY
	(
	IdEstudiante
	) REFERENCES dbo.Estudiantes
	(
	IdEstudiante
	) ON UPDATE  NO ACTION 
	 ON DELETE  NO ACTION 
	
GO
ALTER TABLE dbo.AsistenciasDetalle SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
