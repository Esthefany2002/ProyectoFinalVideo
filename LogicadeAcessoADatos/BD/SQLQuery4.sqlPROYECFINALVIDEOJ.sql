CREATE DATABASE ProyectoFinalVJ;
GO
USE ProyectoFinalVJ;
GO
-----TABLA GENERO-----
CREATE TABLE Genero (
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50)
);
GO
------TABLA DE PLATAFORMA-----
CREATE TABLE Plataforma (
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50)
);
GO
------TABLA DE CATEGORIA--------
CREATE TABLE Categoria(
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50)
);
GO
------TABLA DE PROVEEDOR--------
CREATE TABLE Proveedor (
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50),
Apellido VARCHAR(50),
NumerodeCel VARCHAR(50),
CorreoElectronico VARCHAR(50),
Direccion VARCHAR(50)
);
GO
-------TABLA DE VIDEOJUEGOS----------
CREATE TABLE VideoJuegos (
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50),
IdPlataforma INT,
IdGenero INT,
IdCategoria INT,
IdProveedor INT,
PrecioUnitario DECIMAL(10,2),
FOREIGN KEY (IdPlataforma) REFERENCES Plataforma(Id),
FOREIGN KEY (IdGenero) REFERENCES Genero(Id),
FOREIGN KEY (IdCategoria) REFERENCES Categoria(Id),
FOREIGN KEY (IdProveedor) REFERENCES Proveedor(Id)
);
GO
------TABLA DE ESTADOVENTA--------
CREATE TABLE EstadoVenta (
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50)
);
GO
------TABLA DE CARGO-----
CREATE TABLE Cargo (
Id INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50)
);
GO
-----TABLA DE EMPLEADO-----
CREATE TABLE Empleado (
Id INT PRIMARY KEY IDENTITY(1,1),
Cargo VARCHAR(50),
Celular VARCHAR(15),
CorreoElectronico VARCHAR(50),
Nombre VARCHAR(50),
Apellido VARCHAR(50),
Direccion VARCHAR(50)
);
GO
--------TABLA DE INVENTARIO--------
CREATE TABLE Inventario (
Id INT PRIMARY KEY IDENTITY(1,1),
IdVideoJuegos INT,
PrecioVenta DECIMAL(10,2),
PorcentajeGanancia DECIMAL(5,2),
StockInicial INT,
Vendido INT,
StockActual INT,
IdEstadoVenta INT,
IdEmpleado INT,
FOREIGN KEY (IdVideoJuegos) REFERENCES VideoJuegos(Id),
FOREIGN KEY (IdEstadoVenta) REFERENCES EstadoVenta(Id),
FOREIGN KEY (IdEmpleado) REFERENCES Empleado(Id)
);
GO
---------------TABLA DE USUARIO------------
Create TABLE Usuario  (
Id INT NOT NULL PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(80) NOT NULL,
Clave VARCHAR(25) NOT NULL,
Cargo VARCHAR(50) NOT NULL
);
GO
----------------------------------------------------------------------------------------
-----------------PROCEDIMIENTOS ALMACENADOS-------------------------------
------------MOSTRAR GENERO---------------------------
CREATE PROCEDURE MostrarGenero
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
    SELECT 
	Id,
	Nombre
FROM
    Genero
WHERE
     (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
END;
GO
---------GUARDAR GENERO-------
CREATE PROCEDURE GuardarGenero
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
INSERT INTO Genero(Nombre) VALUES
(@Nombre)
END;
GO
--------ELIMINAR GENERO--------
CREATE PROCEDURE EliminarGenero
@Id INT = NULL
AS
BEGIN
DELETE FROM Genero
WHERE Id = @Id;

END;
GO
--------MODIFICAR GENERO----------
CREATE PROCEDURE ModificarGenero
@Id INT = NULL,
@Nombre VARCHAR (50) = NULL
AS
BEGIN
UPDATE Genero
SET Nombre = @Nombre
WHERE Id = @Id;
END;
GO
--------------------------------------------------------------------------------
--------------PROCEDIMIENTO ALMACENADO PARA PLATAFORMA-------------------------
-------MOSTRAR PLATAFORMA-----
CREATE PROCEDURE MostrarPlataforma
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
    SELECT 
	Id,
	Nombre
FROM
    Plataforma
WHERE
     (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
END;
GO

---------GUARDAR PLATAFORMA-------
CREATE PROCEDURE GuardarPlataforma
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
INSERT INTO Plataforma(Nombre) VALUES
(@Nombre)
END;
GO
--------ELIMINAR PLATAFORMA--------
CREATE PROCEDURE EliminarPlataforma
@Id INT 
AS
BEGIN
DELETE FROM Plataforma
WHERE Id = @Id;

END;
GO
--------MODIFICAR PLATAFORMA----------
CREATE PROCEDURE ModificarPlataforma
@Id INT,
@Nombre VARCHAR (50)
AS
BEGIN
UPDATE Plataforma
SET Nombre = @Nombre
WHERE Id = @Id;
END;
GO
--------------------------------------------------------------------------------------
----------------PROCEDIMIENTO ALMACENADO PARA CATEGORIA-------------
---------MOSTRAR CATEGORIA-----
CREATE PROCEDURE MostrarCategoria
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
    SELECT 
	Id,
	Nombre
FROM
    Categoria
WHERE
     (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
END;
GO
---------GUARDAR CATEGORIA-------
CREATE PROCEDURE GuardarCategoria
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
INSERT INTO Categoria(Nombre) VALUES
(@Nombre)
END;
GO
--------ELIMINAR CATEGORIA--------
CREATE PROCEDURE EliminarCategoria
@Id INT 
AS
BEGIN
DELETE FROM Categoria
WHERE Id = @Id;

END;
GO
--------MODIFICAR CATEGORIA----------
CREATE PROCEDURE ModificarCategoria
@Id INT,
@Nombre VARCHAR (50)
AS
BEGIN
UPDATE Categoria
SET Nombre = @Nombre
WHERE Id = @Id;
END;
GO
----------------------------------------------------------------------------------
----------------PROCEDIMIENTO ALMACENADO DE PROVEEDOR---------
-------MOSTRAR PROVEEDOR----------
CREATE PROCEDURE MostrarProveedor
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL,
@Apellido VARCHAR(50)= NULL,
@NumerodeCel VARCHAR(50) = NULL,
@CorreoElectronico VARCHAR(50) = NULL,
@Direccion VARCHAR(50) = NULL
AS
BEGIN
    SELECT 
	Id,
	Nombre,
	Apellido,
	NumerodeCel,
	CorreoElectronico,
	Direccion
FROM
    Proveedor
WHERE
     (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%') AND
	 (@Apellido IS NULL OR Apellido LIKE '%' + @Apellido + '%') AND
	 (@NumerodeCel IS NULL OR NumerodeCel LIKE '%' + @NumerodeCel + '%') AND
	 (@CorreoElectronico IS NULL OR CorreoElectronico LIKE '%' + @CorreoElectronico + '%') AND
	 (@Direccion IS NULL OR Direccion LIKE '%' + @Direccion + '%')
END;
GO
------GUARDAR PROVEEDOR------
CREATE PROCEDURE GuardarProveedor
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL,
@Apellido VARCHAR(50)= NULL,
@NumerodeCel VARCHAR(50) = NULL,
@CorreoElectronico VARCHAR(50) = NULL,
@Direccion VARCHAR(50) = NULL
AS
BEGIN
INSERT INTO Proveedor(Nombre, Apellido, NumerodeCel, CorreoElectronico,Direccion) VALUES
(@Nombre, @Apellido, @NumerodeCel, @CorreoElectronico, @Direccion)
END;
GO
---------ELIMINAR PROVEEDOR-------
CREATE PROCEDURE EliminarProveedor
@Id INT = NULL
AS
BEGIN
DELETE FROM Proveedor
WHERE Id = @Id;
END;
GO
------MODIFICAR PROVEEDOR----
CREATE PROCEDURE ModificarProveedor
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL,
@Apellido VARCHAR(50)= NULL,
@NumerodeCel VARCHAR(50) = NULL,
@CorreoElectronico VARCHAR(50) = NULL,
@Direccion VARCHAR(50) = NULL
AS
BEGIN
UPDATE Proveedor
SET Nombre = @Nombre,
Apellido = @Apellido,
NumerodeCel = @NumerodeCel,
CorreoElectronico = @CorreoElectronico,
Direccion = @Direccion
WHERE Id = @Id;
END;
GO
--------------------------------------------------------------------------------------
---------PROCEDIMIENTO ALMACENADO PARA VIDEOJUEGO-----------
------MOSTRAR VIDEOJUEGOS-------
CREATE PROCEDURE MostrarVideoJuegos
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL,
@IdPlataforma INT = NULL,
@IdGenero INT = NULL,
@IdCategoria INT = NULL,
@IdProveedor INT = NULL,
@PrecioUnitario DECIMAL(10,2) = NULL
AS
BEGIN
    SELECT 
	Id,
	Nombre,
	IdPlataforma,
	IdGenero,
	IdCategoria,
	IdProveedor,
	PrecioUnitario
FROM
    VideoJuegos
END;
GO
------GUARDAR VIDEOJUEGOS---
CREATE PROCEDURE GuardarVideoJuegos
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL,
@IdPlataforma INT = NULL,
@IdGenero INT = NULL,
@IdCategoria INT = NULL,
@IdProveedor INT = NULL,
@PrecioUnitario DECIMAL(10,2) = NULL
AS
BEGIN
INSERT INTO VideoJuegos(Nombre, IdPlataforma, IdGenero, IdCategoria,IdProveedor, PrecioUnitario) VALUES
(@Nombre, @IdPlataforma, @IdGenero, @IdCategoria, @IdProveedor,@PrecioUnitario )
END;
GO
---------ELIMINAR VIDEOJUEGOS-------
CREATE PROCEDURE EliminarVideoJuegos
@Id INT = NULL
AS
BEGIN
DELETE FROM VideoJuegos
WHERE Id = @Id;
END;
GO
-----MODIFICAR VIDEOJUEGOS----
CREATE PROCEDURE ModificarVideoJuegos
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL,
@IdPlataforma INT = NULL,
@IdGenero INT = NULL,
@IdCategoria INT = NULL,
@IdProveedor INT = NULL,
@PrecioUnitario DECIMAL(10,2) = NULL
AS
BEGIN
UPDATE VideoJuegos
SET Nombre = @Nombre,
IdPlataforma = @IdPlataforma,
IdGenero = @IdGenero,
IdCategoria = @IdCategoria,
IdProveedor = @IdProveedor,
PrecioUnitario = @PrecioUnitario
WHERE Id = @Id;
END;
GO
-------------------------------------------------------------------------------------
---------------PROCEDIMIENTO ALMACENADO PARA ESTADO VENTA-----------
-----MOSTRAR ESTADOVENTA----
CREATE PROCEDURE MostrarEstadoVenta
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
    SELECT 
	Id,
	Nombre
FROM
    EstadoVenta
WHERE
     (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
END;
GO
---------GUARDAR ESTADOVENTA-------
CREATE PROCEDURE GuardarEstadoVenta
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
INSERT INTO EstadoVenta(Nombre) VALUES
(@Nombre)
END;
GO
--------ELIMINAR ESTADOVENTA--------
CREATE PROCEDURE EliminarEstadoVenta
@Id INT 
AS
BEGIN
DELETE FROM EstadoVenta
WHERE Id = @Id;

END;
GO
--------MODIFICAR ESTADOVENTA----------
CREATE PROCEDURE ModificarEstadoVenta
@Id INT,
@Nombre VARCHAR (50)
AS
BEGIN
UPDATE EstadoVenta
SET Nombre = @Nombre
WHERE Id = @Id;
END;
GO
-----------------------------------------------------------------------------------
----------PROCEDIMIENTOS ALMACENADOS PARA CARGO---------
------MOSTRAR CARGO------
CREATE PROCEDURE MostrarCargo
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
    SELECT 
	Id,
	Nombre
FROM
    Cargo
WHERE
     (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
END;
GO
---------GUARDAR CARGO-------
CREATE PROCEDURE GuardarCargo
@Id INT = NULL,
@Nombre VARCHAR(50) = NULL
AS
BEGIN
INSERT INTO Cargo(Nombre) VALUES
(@Nombre)
END;
GO
--------ELIMINAR CARGO--------
CREATE PROCEDURE EliminarCargo
@Id INT 
AS
BEGIN
DELETE FROM Cargo
WHERE Id = @Id;

END;
GO
--------MODIFICAR CARGO----------
CREATE PROCEDURE ModificarCargo
@Id INT,
@Nombre VARCHAR (50)
AS
BEGIN
UPDATE Cargo
SET Nombre = @Nombre
WHERE Id = @Id;
END;
GO
-----------------------------------------------------------------------------------
--------PROCEDIMIENTO ALMACENADO PARA EMPLEADO-----------
-----MOSTRAR EMPLEADO---------
CREATE PROCEDURE MostrarEmpleado
@Id INT = NULL,
@Cargo INT = NULL,
@Celular VARCHAR(15) = NULL,
@CorreoElectronico VARCHAR(50) = NULL,
@Nombre VARCHAR(50) = NULL,
@Apellido VARCHAR(50) = NULL,
@Direccion VARCHAR(50) = NULL
AS
BEGIN
    SELECT 
        Id,
        Cargo,
        Celular,
        CorreoElectronico,
		Nombre,
		Apellido,
		Direccion
    FROM 
        Empleado
    WHERE
	       (@Cargo IS NULL OR Cargo = @Cargo )
       AND (@Celular IS NULL OR Celular LIKE '%' + @Celular + '%')
        AND (@CorreoElectronico IS NULL OR CorreoElectronico LIKE '%' + @CorreoElectronico + '%')
		AND (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%')
		AND (@Apellido IS NULL OR Apellido LIKE '%' + @Apellido + '%')
		AND (@Direccion IS NULL OR Direccion LIKE '%' + @Direccion + '%')
END;
GO
-----------GUARDAR EMPLEADO-------------
CREATE PROCEDURE GuardarEmpleado
@Id INT = NULL,
@Cargo INT = NULL,
@Celular VARCHAR(15) = NULL,
@CorreoElectronico VARCHAR(50) = NULL,
@Nombre VARCHAR(50) = NULL,
@Apellido VARCHAR(50) = NULL,
@Direccion VARCHAR(50) = NULL
AS
BEGIN
INSERT INTO Empleado(Cargo, Celular, CorreoElectronico, Nombre, Apellido, Direccion) VALUES
(@Cargo, @Celular, @CorreoElectronico,@Nombre, @Apellido, @Direccion )
END;
GO
----------ELIMINAR EMPLEADO---------------
CREATE PROCEDURE EliminarEmpleado
@Id INT = NULL
AS
BEGIN
DELETE FROM Empleado
WHERE Id = @Id;

END;
GO
-----------MODIFICAR EMPLEADO------
CREATE PROCEDURE ModificarEmpleado
@Id INT = NULL,
@Cargo INT = NULL,
@Celular VARCHAR(15) = NULL,
@CorreoElectronico VARCHAR(50) = NULL,
@Nombre VARCHAR(50) = NULL,
@Apellido VARCHAR(50) = NULL,
@Direccion VARCHAR(50) = NULL
AS
BEGIN
UPDATE Empleado
SET Cargo = @Cargo,
Celular = @Celular,
CorreoElectronico = @CorreoElectronico,
Nombre = @Nombre,
Apellido = @Apellido,
Direccion =  @Direccion
WHERE Id = @Id;
END;
GO
------------------------------------------------------------------------------------------
----------PROCEDIMIENTOS ALMACENADOS PARA INVENTARIO------
---MOSTRAR INVENTARIO----
CREATE PROCEDURE MostrarInventario
@Id INT = NULL,
@IdVideoJuegos INT = NULL,
@PrecioVenta DECIMAL(10,2) = NULL,
@PorcentajeGanancia DECIMAL(5,2) = NULL,
@StockInicial INT = NULL,
@Vendido INT = NULL,
@StockActual INT = NULL,
@IdEstadoVenta INT = NULL,
@IdEmpleado INT = NULL
AS
BEGIN
    SELECT 
	Id,
	IdVideoJuegos,
    PrecioVenta,
    PorcentajeGanancia,
    StockInicial,
    Vendido,
    StockActual,
    IdEstadoVenta,
    IdEmpleado 
FROM
    Inventario
END;
GO
----GUARDAR INVENTARIO---
CREATE PROCEDURE GuardarInventario
@Id INT = NULL,
@IdVideoJuegos INT = NULL,
@PrecioVenta DECIMAL(10,2) = NULL,
@PorcentajeGanancia DECIMAL(5,2) = NULL,
@StockInicial INT = NULL,
@Vendido INT = NULL,
@StockActual INT = NULL,
@IdEstadoVenta INT = NULL,
@IdEmpleado INT = NULL
AS
BEGIN
INSERT INTO Inventario(IdVideoJuegos, PrecioVenta, PorcentajeGanancia, StockInicial,Vendido, StockActual, IdEstadoVenta, IdEmpleado ) VALUES
(@IdVideoJuegos, @PrecioVenta, @PorcentajeGanancia, @StockInicial, @Vendido,@StockActual, @IdEstadoVenta, @IdEmpleado   )
END;
GO
---------ELIMINAR INVENTARIO-------
CREATE PROCEDURE EliminarInventario
@Id INT = NULL
AS
BEGIN
DELETE FROM Inventario
WHERE Id = @Id;
END;
GO
-----MODIFICAR INVENTARIO----
CREATE PROCEDURE ModificarInventario
@Id INT = NULL,
@IdVideoJuegos INT = NULL,
@PrecioVenta DECIMAL(10,2) = NULL,
@PorcentajeGanancia DECIMAL(5,2) = NULL,
@StockInicial INT = NULL,
@Vendido INT = NULL,
@StockActual INT = NULL,
@IdEstadoVenta INT = NULL,
@IdEmpleado INT = NULL
AS
BEGIN
UPDATE Inventario
SET IdVideoJuegos = @IdVideoJuegos,
PrecioVenta = @PrecioVenta,
PorcentajeGanancia = @PorcentajeGanancia,
StockInicial = @StockInicial,
Vendido = @Vendido,
StockActual = @StockActual,
IdEstadoVenta  = @IdEstadoVenta,
IdEmpleado  =  @IdEmpleado
WHERE Id = @Id;
END;
GO
---------------------------------------------------------------------------------
----------PROCEDIMIENTOS ALMACENADOS PARA USUARIO------------------------------------
------- VERIFICAR USUARIO----
CREATE PROCEDURE VerificarUsuario
    @Nombre VARCHAR(80),
    @Clave VARCHAR(25),
    @Cargo VARCHAR(50)
AS
BEGIN
    -- Retorna 1 si existe, 0 si no
    SELECT ISNULL(
        (SELECT 1 FROM Usuario 
         WHERE Nombre = @Nombre 
         AND Clave = @Clave 
         AND Cargo = @Cargo), 
    0) AS UserExiste
END;
GO

------- MOSTRAR USUARIO------
CREATE PROCEDURE MostrarUsuario
    @Nombre VARCHAR(80) = NULL,
    @Clave VARCHAR(25) = NULL,
    @Cargo VARCHAR(50) = NULL
AS
BEGIN
    SELECT 
        Id,
        Nombre,
        Clave,
        Cargo
    FROM 
        Usuario
    WHERE
        (@Nombre IS NULL OR Nombre LIKE '%' + @Nombre + '%') AND
        (@Clave IS NULL OR Clave = @Clave) AND
        (@Cargo IS NULL OR Cargo LIKE '%' + @Cargo + '%')
END;
GO

------- GUARDAR USUARIO------
CREATE PROCEDURE GuardarUsuario
    @Id INT = NULL,
    @Nombre VARCHAR(80) = NULL,
    @Clave VARCHAR(25) = NULL,
    @Cargo VARCHAR(50) = NULL
AS
BEGIN
    INSERT INTO Usuario (Nombre, Clave, Cargo)
    VALUES (@Nombre, @Clave, @Cargo)
END;
GO

------- ELIMINAR USUARIO------
CREATE  PROCEDURE EliminarUsuario
    @Id INT = NULL
AS
BEGIN
    DELETE FROM Usuario
    WHERE Id = @Id
END;
GO

------- MODIFICAR USUARIO----------
CREATE OR ALTER PROCEDURE ModificarUsuario
    @Id TINYINT,
    @Nombre VARCHAR(80) = NULL,
    @Clave VARCHAR(25) = NULL,
    @Cargo VARCHAR(50) = NULL
AS
BEGIN
    UPDATE Usuario
    SET Nombre = @Nombre,
        Clave = @Clave,
        Cargo = @Cargo
    WHERE Id = @Id
END;
GO
------------------------------------------------------------------------------------------------------------
----------PROCEDIMIENTO ALMACENADO ESPECIAL------------------------------------
-------MOSTRAR TOP VENTAS DE PRODUCTOS----
CREATE PROCEDURE TopVentas


AS
BEGIN
SELECT * FROM Inventario

END;
GO
