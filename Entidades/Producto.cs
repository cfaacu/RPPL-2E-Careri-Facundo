using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        string nombre;
        double precio;
        string descripcion;
        int cantidad;
        string tipoProducto;
        int id;
        static int ultimoId;
        double peso;

        public Producto(string nombre, double precio, string descripcion, string tipoProducto, int cantidad,double peso) : this()
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Cantidad = cantidad;
            this.Descripcion = descripcion;
            this.TipoProducto = tipoProducto;
            this.Peso = peso;
        }
        public Producto(int id, string nombre, double precio, string descripcion, string tipoProducto, int cantidad,double peso):this(nombre,precio,descripcion,tipoProducto,cantidad,peso)
        {
            this.id = id;
        }
        static Producto()
        {
            ultimoId = 8;
        }
        private Producto()
        {
            ultimoId++;
            this.id = ultimoId;
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return this.descripcion;
            }
            set
            {
                this.descripcion = value;
            }
        }
        public string TipoProducto
        {
            get
            {
                return this.tipoProducto;
            }
            set
            {
                this.tipoProducto = value;
            }
        }
        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }
        public int Id
        {
            get
            {
                return this.id;
            }
        }
        public double Peso
        {
            get
            {
                return this.peso;
            }
            set
            {
                if(value >= 0)
                {
                    this.peso = value;
                }
            }
        }

        /// <summary>
        /// Muestra el nombre, descripcion y tipo del producto
        /// </summary>
        /// <returns>String con los datos del producto</returns>
        public string MostrarDatos()
        {
            return $"Nombre: {Nombre}   Descripcion: {Descripcion}   Tipo: {TipoProducto}";
        }
        /// <summary>
        /// Muestra el id, cantidad y precio del producto
        /// </summary>
        /// <returns>String con los datos del producto</returns>
        public string MostrarPrecioCant()
        {
            return $"ID: {Id}   Cantidad: {Cantidad}   Precio: {Precio}";
        }
        /// <summary>
        /// Muestra los datos necesarios para el momento de la venta, nombre, cantidad y precio
        /// </summary>
        /// <returns>string con los datos necesarios para la venta</returns>
        public string MostrarDatosVenta()
        {
            return $"Nombre: {Nombre}   Cantidad: {1}   Precio: {Precio}";
        }

    }
}
