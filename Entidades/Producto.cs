﻿using System;
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

        public Producto(string nombre, double precio, string descripcion, string tipoProducto, int cantidad) : this()
        {
            this.nombre = nombre;
            this.precio = precio;
            this.cantidad = cantidad;
            this.descripcion = descripcion;
            this.tipoProducto = tipoProducto;
        }
        public Producto(int id, string nombre, double precio, string descripcion, string tipoProducto, int cantidad):this(nombre,precio,descripcion,tipoProducto,cantidad)
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
