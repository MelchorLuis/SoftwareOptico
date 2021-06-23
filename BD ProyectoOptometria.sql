CREATE DATABASE ProyectoOptometria
USE ProyectoOptometria

CREATE TABLE Usuario(
ID_Usuario INT IDENTITY(1,1) NOT NULL PRIMARY KEY ,
Nombre_Usuario VARCHAR(30) NOT NULL,
Apellido_Usuario VARCHAR(30) NOT NULL,
Sexo_Usuario VARCHAR(10) NOT NULL,
Nacimiento_Usuario DATE NOT NULL,
Correo_Usuario VARCHAR(50) NOT NULL,
Contrasena_Usuario VARCHAR(50) NOT NULL
)

CREATE TABLE Pacientes(
ID_Pacientes INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
Nombre_Pacientes VARCHAR(30) NOT NULL,
Apellido_Pacientes VARCHAR(30) NOT NULL,
Edad_Pacientes INT NOT NULL,
Telefono_Pacientes varchar(20) not null,
Correo_Pacientes VARCHAR(50),
Direccion varchar(200)
)

CREATE TABLE Usuario_Pacientes(
ID_Usuario INT NOT NULL Foreign Key REFERENCES Usuario(ID_Usuario),
ID_Pacientes INT NOT NULL Foreign Key REFERENCES Pacientes(ID_Pacientes),
PRIMARY KEY(ID_Usuario, ID_Pacientes)
)

CREATE TABLE Agenda(
Id_Calendario    int identity(1,1) primary key,
Nombre_Pac        varchar(20),
Telefono_Pac    varchar(20),
Nombre_Enc        varchar(20),
Hora            varchar(2),
Fecha            date,
Procedimiento    varchar(50),
ID_Pacientes    INT 
)

Create table Horas(
Id_H        int identity(1,1) primary key,
Hora        int,
ID_Calendario INT,
disponible    char
)

CREATE TRIGGER InsertarHoras ON Agenda
FOR Insert 
AS
 
BEGIN
  INSERT INTO Horas (Hora, ID_Calendario) values
  (1, (select ID_Calendario from inserted)),
  (2, (select Id_Calendario from inserted)),
  (3, (select Id_Calendario from inserted)),
  (4, (select ID_Calendario from inserted)),
  (5, (select ID_Calendario from inserted)),
  (6, (select Id_Calendario from inserted)),
  (7, (select Id_Calendario from inserted))
END

CREATE TABLE Examen(
ID_Examen INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
EsferaLejosDerecho varchar(10),
CilindroLejosDerecho varchar(10),
EjeLejosDerecho varchar(10),
EsferaLejosIzquierdo varchar(10),
CilindroLejosIzquierdo varchar(10),
EjeLejosIzquierdo varchar(10),
EsferaCercaDerecho varchar(10),
CilindroCercaDerecho varchar(10),
EjeCercaDerecho varchar(10),
EsferaCercaIzquierdo varchar(10),
CilindroCercaIzquierda varchar(10),
EjeCercaIzquierdo varchar(10),
DIP varchar(10),
ID_Pacientes varchar(100) not null,
Observaciones varchar(300)
)

CREATE TABLE HistorialPagos(
ID_Pago INT  NOT NULL PRIMARY KEY,
TotalPagar decimal,
Abono_Pago decimal,
Faltante_Pago decimal,
Estado_Pago varchar(10)
)

create procedure sp_MostrarPacientes
as
select * from Pacientes
go

create procedure sp_MostrarPagos
as
select * from HistorialPagos
go

create trigger Operaciones
on HistorialPagos
for insert
as 
begin
declare @TotalPagar decimal
declare @Abono_Pago decimal
declare @Faltante_Pago decimal
declare @Estado_Pago varchar(10)
set @TotalPagar = (select TotalPagar from HistorialPagos)
set @Abono_Pago = (select Abono_Pago from HistorialPagos)
set @Faltante_Pago = (select Faltante_Pago from HistorialPagos)
set @Estado_Pago = (select Estado_Pago from HistorialPagos)
set @Faltante_Pago = @TotalPagar - @Abono_Pago
if @Faltante_Pago = 0
set @Estado_Pago = 'PAGADO'
update HistorialPagos set Faltante_Pago = @Faltante_Pago, Estado_Pago = @Estado_Pago where  ID_Pago = (select ID_Pago from inserted)
end
drop trigger Operaciones

create trigger Operaciones2
on HistorialPagos
for update
as 
begin
declare @TotalPagar decimal
declare @Abono_Pago decimal
declare @Faltante_Pago decimal
declare @Estado_Pago varchar(10)
set @TotalPagar = (select TotalPagar from HistorialPagos)
set @Abono_Pago = (select Abono_Pago from HistorialPagos)
set @Faltante_Pago = (select Faltante_Pago from HistorialPagos)
set @Estado_Pago = (select Estado_Pago from HistorialPagos)
set @Faltante_Pago = @TotalPagar - @Abono_Pago
if @Faltante_Pago = 0
set @Estado_Pago = 'PAGADO'
update HistorialPagos set Faltante_Pago = @Faltante_Pago, Estado_Pago = @Estado_Pago where  ID_Pago = (select ID_Pago from inserted)
end

CREATE TABLE Agenda(
Id_Calendario    int identity(1,1) primary key,
Fecha        date,
ID_Pacientes    INT 
)

select * from Horas
drop table 
Update Horas SET Nombre_Pac='{0}', Telefono_Pac = '{1}', Nombre_Enc= '{2}', Hora='2', Procedimiento= '{4}' where Fecha='2021-06-22' and Hora='2'
select * from horas
Create table Horas(
Id_H        int identity(1,1) primary key,
Nombre_Pac        varchar(20),
Telefono_Pac    varchar(20),
Nombre_Enc        varchar(20),
Hora            varchar(2),
Fecha            date,
Procedimiento    varchar(50),
ID_Calendario INT,
disponible    char
)

CREATE TRIGGER InsertarHoras ON Agenda
FOR Insert 
AS
 
BEGIN
  INSERT INTO Horas (Hora, Fecha) values
  (1, (select Fecha from inserted)),
  (2, (select Fecha from inserted)),
  (3,  (select Fecha from inserted)),
  (4,  (select Fecha from inserted)),
  (5,  (select Fecha from inserted)),
  (6,  (select Fecha from inserted)),
  (7, (select Fecha from inserted))
END


