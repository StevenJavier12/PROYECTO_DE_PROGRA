Create database PROSERADB;
GO

USE PROSERADB;
GO

Create table Categorias(
	Id int primary key identity (1,1),
	Nombre varchar (100)
);

Create table Productos(
	Id int primary key identity (1,1),
	Nombre varchar (100),
	Precio decimal (10,2),
	Stock int not null,
	CategoriaId int foreign key references Categorias (Id)
);