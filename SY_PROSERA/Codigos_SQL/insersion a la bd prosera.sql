INSERT INTO Usuarios (username, contraseña, rol, estadoUser)
VALUES 
('admin', '123456', 'Administrador', 'Activo'),
('ventas1', 'ventas123', 'Vendedor', 'Activo'),
('bodega1', 'bodega123', 'Bodega', 'Inactivo');

INSERT INTO Categoria_Productos (nombre, descripcion)
VALUES 
('Fertilizantes', 'Productos para nutrición de cultivos'),
('Herramientas', 'Herramientas manuales y eléctricas');

INSERT INTO Marcas (marca)
VALUES 
('Bayer'),
('Truper');

INSERT INTO Productos (nombre, descripcion, precio_unitario, id_marca, estado_producto, id_categoria)
VALUES 
('Fertilizante Urea', 'Abono para cultivos', 25.50, 1, 'Activo', 1),
('Martillo 16oz', 'Martillo de acero', 8.75, 2, 'Activo', 2);

INSERT INTO Inventario (id_producto, stock, stock_minimo, fecha_actualizacion, tipo_movimiento, DescripcionMovimiento)
VALUES 
(1, 50, 5, GETDATE(), 'Entrada', 'Ingreso inicial de fertilizante'),
(2, 30, 3, GETDATE(), 'Entrada', 'Ingreso inicial de herramientas');

INSERT INTO Clientes (nombre, apellido, telefono, direccion, dui, correo)
VALUES 
('Carlos', 'Pérez', '71234567', 'San Salvador', '01234567-8', 'carlos@mail.com'),
('María', 'López', '72345678', 'Santa Ana', '02345678-9', 'maria@mail.com');

INSERT INTO Empleados (nombre, apellido, cargo, telefono, correo, direccion, dui)
VALUES 
('Luis', 'García', 'Vendedor', '70112233', 'luis@mail.com', 'San Miguel', '03456789-0'),
('Ana', 'Martínez', 'Cajera', '70223344', 'ana@mail.com', 'Sonsonate', '04567890-1');

INSERT INTO Usuarios (username, contraseña, rol, estadoUser, id_empleado)
VALUES 
('luisv', '1234', 'Vendedor', 'Activo', 1),
('anac', '1234', 'Cajero', 'Activo', 2);

INSERT INTO Factura_Ventas (fecha, id_cliente, id_usuario, total, descuento, metodo_pago, estado_factura)
VALUES 
(GETDATE(), 1, 1, 50.00, 0, 'Efectivo', 'Pagada'),
(GETDATE(), 2, 2, 25.50, 2.00, 'Tarjeta', 'Pendiente');


INSERT INTO Detalle_Ventas (id_factura, id_producto, cantidad, precio_unitario, subtotal)
VALUES 
(1, 1, 2, 25.50, 51.00),
(2, 2, 1, 8.75, 8.75);

INSERT INTO Proveedores (nombre_empresa, contacto, telefono, direccion, correo)
VALUES 
('AgroCentro', 'Juan Ruiz', '70001111', 'San Salvador', 'agro@mail.com'),
('FerreMax', 'Pedro López', '70002222', 'Santa Ana', 'ferre@mail.com');

INSERT INTO Factura_Compras (fecha, id_proveedor, total, tipo_comprobante)
VALUES 
(GETDATE(), 1, 100.00, 'Factura'),
(GETDATE(), 2, 200.00, 'Consumidor final');

INSERT INTO Detalle_Compras (id_compra, id_producto, cantidad, costo_unitario, subtotal)
VALUES 
(1, 1, 3, 20.00, 60.00),
(2, 2, 5, 10.00, 50.00);

INSERT INTO Dispositivos_Electronicos (tipo, marca, modelo, estado, unidadDeMedida, descripcion)
VALUES 
('Celular', 'Samsung', 'A12', 'Bueno', 1, 'Teléfono para recepción'),
('Tablet', 'Lenovo', 'Tab M10', 'Regular', 1, 'Uso en inventario');


INSERT INTO Recepcion_Dispositivos (fecha, id_cliente, id_usuario, observaciones)
VALUES 
(GETDATE(), 1, 1, 'Dispositivo recibido en buen estado'),
(GETDATE(), 2, 2, 'Pantalla dañada');

INSERT INTO Detalles_Recepcion (id_recepcion, id_dispositivo, cantidad)
VALUES 
(1, 1, 1),
(2, 2, 1);

select*from Proveedores