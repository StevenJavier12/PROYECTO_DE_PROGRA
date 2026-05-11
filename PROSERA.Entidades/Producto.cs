using System;
using System.Collections.Generic;
using System.Text;

namespace PROSERA.Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; } = "";
        public string? Descripcion { get; set; }
        public decimal PrecioUnitario { get; set; }
        public int IdMarca { get; set; }
        public string Marca { get; set; } = "";
        public string EstadoProducto { get; set; } = "";
        public int IdCategoria { get; set; }
        public string Categoria { get; set; } = "";        
    }
}
/*CREATE TABLE Productos (
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
 */