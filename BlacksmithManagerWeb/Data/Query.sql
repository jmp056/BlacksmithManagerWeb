create database BlacksmithManagerWeb
GO
Use BlacksmithManagerWeb
GO
create table Clientes(
	ClienteId int primary key identity,
	Nombres varchar(25),
	Cedula varchar (13),
	Celular varchar(12),
	Telefono varchar(12),
	Email varchar(50),
	FechaIngreso datetime
)
select * from Clientes
