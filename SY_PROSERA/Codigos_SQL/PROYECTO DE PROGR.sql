CREATE DATABASE PROSERADB;
GO

USE PROSERADB;
GO

-- =========================================
-- 1. CATEGORIA_PRODUCTO
-- =========================================
CREATE TABLE Categoria_Productos (
    id_categoria INT PRIMARY KEY IDENTITY (1,1),
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(200) NOT NULL,
);

-- =========================================
-- 2 MARCA
-- =========================================
CREATE TABLE Marcas (
    id_marca int primary key identity (1,1),
    marca varchar (100) NOT NULL,
);

-- =========================================
-- 3. PRODUCTO
-- =========================================
CREATE TABLE Productos (
    id_producto INT PRIMARY KEY IDENTITY (1,1),
    nombre VARCHAR(100) NOT NULL,
    descripcion VARCHAR(200),
    precio_unitario DECIMAL(10,2) NOT NULL,
    --unidad_medida VARCHAR(50),
    id_marca INT NOT NULL, -- not null porque se garegara una marca general de productos sin marca
    estado_producto VARCHAR(20) CHECK (estado_producto IN ('Activo','Inactivo')) NOT NULL, --Campo para indicar si aun se vende este producto en la tienda o ya no
    id_categoria INT NOT NULL,    


    CONSTRAINT FK_Producto_Categorias
    FOREIGN KEY (id_categoria) REFERENCES Categoria_Productos(id_categoria),

    CONSTRAINT FK_Marcas
    FOREIGN KEY (id_marca) REFERENCES Marcas(id_marca)
);



-- =========================================
-- 4. INVENTARIO
-- =========================================
CREATE TABLE Inventario (
    id_inventario INT PRIMARY KEY IDENTITY (1,1),
    id_producto INT NOT NULL,
    stock INT NOT NULL,
    stock_minimo INT NOT NULL, -- mandara una alerta cuando eje. stock =<2
    fecha_actualizacion DATETIME NOT NULL,
    tipo_movimiento VARCHAR(20) CHECK (tipo_movimiento in ('Entrada','Salida')) NOT NULL,
    DescripcionMovimiento Varchar (200) NOT NULL,


    CONSTRAINT FK_Inventario_Productos
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);


-- =========================================
-- 5. CLIENTE
-- ========================================= la entidad cliente solo se utilizara con los que tengan descuentos para los demas como ni
CREATE TABLE Clientes (
    id_cliente INT PRIMARY KEY IDENTITY,
    nombre VARCHAR(100) NOT NULL,
    apellido VARCHAR(100) NOT NULL,
    telefono VARCHAR(10) NOT NULL,
    direccion VARCHAR(200) NOT NULL,
    dui VARCHAR(12) NOT NULL UNIQUE,
    correo VARCHAR(100) NULL,
);

-- =========================================
-- 6. EMPLEADO
-- =========================================
CREATE TABLE Empleados (
    id_empleado INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(100) not null,
    apellido VARCHAR(100) not null,
    cargo VARCHAR(50) not null,
    telefono VARCHAR(10) not null,
    correo VARCHAR(100) not null,
    direccion VARCHAR(150) not null,
    dui VARCHAR(12) not null UNIQUE

);

-- =========================================
-- 7. USUARIO 
-- =========================================
CREATE TABLE Usuarios (
    id_usuario INT PRIMARY KEY IDENTITY (1,1),
    username VARCHAR(50) NOT NULL UNIQUE,
    contraseña VARCHAR(100) NOT NULL,
    rol VARCHAR(50) NOT NULL,
    estadoUser VARCHAR(20) CHECK (estadoUser in ('Activo','Inactivo')) NOT NULL,
    id_empleado INT FOREIGN KEY (id_empleado) REFERENCES Empleados(id_empleado) null
);

-- =========================================
-- 8. FACTURA_VENTA
-- =========================================
CREATE TABLE Factura_Ventas (
    id_factura INT PRIMARY KEY IDENTITY (1,1),
    fecha DATETIME NOT NULL,
    id_cliente INT NOT NULL,
    id_usuario INT NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    descuento DECIMAL(10,2) NOT NULL DEFAULT 0,
    metodo_pago VARCHAR(50) NOT NULL,
    estado_factura VARCHAR(50) NOT NULL,


    CONSTRAINT FK_Factura_Clientes
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente),

    CONSTRAINT FK_Factura_Usuarios
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario)
);

-- =========================================
-- 9. DETALLE_VENTA
-- =========================================
CREATE TABLE Detalle_Ventas (
    id_detalle INT PRIMARY KEY IDENTITY (1,1),
    id_factura INT NOT NULL,
    id_producto INT NOT NULL,
    cantidad INT NOT NULL,
    precio_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_DetalleVenta_Facturas
    FOREIGN KEY (id_factura) REFERENCES Factura_Ventas(id_factura),

    CONSTRAINT FK_DetalleVenta_Productos
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

-- =========================================
-- 10. PROVEEDOR
-- =========================================
CREATE TABLE Proveedores (
    id_proveedor INT PRIMARY KEY IDENTITY (1,1),
    nombre_empresa VARCHAR(100) NOT NULL, --SE PUEDE AGREGAR UNA CATEGORIA DE VENDEDOR INDEPENDIENTE
    contacto VARCHAR(100) NOT NULL,
    telefono VARCHAR(20) NOT NULL,
    direccion VARCHAR(200) NOT NULL,
    correo VARCHAR(100) NOT NULL
);

-- =========================================
-- 11. FACTURA_COMPRA
-- =========================================
CREATE TABLE Factura_Compras (
    id_compra INT PRIMARY KEY IDENTITY (1,1),
    fecha DATETIME NOT NULL,
    id_proveedor INT NOT NULL,
    total DECIMAL(10,2) NOT NULL,
    tipo_comprobante VARCHAR(50) NOT NULL DEFAULT 'Consumidor final',

    CONSTRAINT FK_Compra_Proveedores
    FOREIGN KEY (id_proveedor) REFERENCES Proveedores(id_proveedor)
);

-- =========================================
-- 12. DETALLE_COMPRA
-- =========================================
CREATE TABLE Detalle_Compras (
    id_detalle_compra INT PRIMARY KEY IDENTITY (1,1),
    id_compra INT NOT NULL,
    id_producto INT NOT NULL,
    cantidad INT NOT NULL,
    costo_unitario DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,

    CONSTRAINT FK_DetalleCompra_Compras
    FOREIGN KEY (id_compra) REFERENCES Factura_Compras(id_compra),

    CONSTRAINT FK_DetalleCompra_Productos
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

-- =========================================
-- 13. DISPOSITIVO_ELECTRONICO
-- =========================================
CREATE TABLE Dispositivos_Electronicos (
    id_dispositivo INT PRIMARY KEY IDENTITY (1,1),
    tipo VARCHAR(50) NOT NULL,
    marca VARCHAR(50) NOT NULL,
    modelo VARCHAR(50) NOT NULL,
    estado VARCHAR(50) NOT NULL,
    unidadDeMedida int NOT NULL,
    descripcion VARCHAR(200) NOT NULL
);

-- =========================================
-- 14. RECEPCION_DISPOSITIVO
-- =========================================
CREATE TABLE Recepcion_Dispositivos (
    id_recepcion INT PRIMARY KEY IDENTITY (1,1),
    fecha DATETIME NOT NULL,
    id_cliente INT NOT NULL,
    id_usuario INT NOT NULL,
    observaciones VARCHAR(200) NOT NULL,

    CONSTRAINT FK_Recepcion_Clientes
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente),

    CONSTRAINT FK_Recepcion_Usuario
    FOREIGN KEY (id_usuario) REFERENCES Usuarios(id_usuario)
);

-- =========================================
-- 15. DETALLE_RECEPCION
-- =========================================
CREATE TABLE Detalles_Recepcion (
    id_detalle INT PRIMARY KEY IDENTITY (1,1),
    id_recepcion INT NOT NULL, -- indica el numero de recepcion donde pertetece
    id_dispositivo INT NOT NULL,
    cantidad INT NOT NULL,

    CONSTRAINT FK_DetallesRecepcion_Recepcion
    FOREIGN KEY (id_recepcion) REFERENCES Recepcion_Dispositivos(id_recepcion),

    CONSTRAINT FK_DetalleRecepcion_Dispositivo
    FOREIGN KEY (id_dispositivo) REFERENCES Dispositivos_Electronicos(id_dispositivo)
);