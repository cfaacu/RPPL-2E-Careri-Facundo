using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Venta
    {
        int idVenta;
        Stack<Producto> carrito;
        double precioTotal;
        Cliente cliente;

        public Venta(Stack<Producto> carrito, double precioTotal, Cliente cliente)
        {
            this.carrito = carrito;
            this.precioTotal = precioTotal;
            this.cliente = cliente;
        }
        public Venta()
        {

        }

        public int IdVenta
        {
            get
            {
                return this.idVenta;
            }
            set
            {
                this.idVenta = value;
            }
        }
        public double PrecioTotal
        {
            get
            {
                return this.precioTotal;
            }
            set
            {
                this.precioTotal = value;
            }
        }
        public Stack<Producto> Carrito
        {
            get
            {
                return this.carrito;
            }
        }
        public Cliente Cliente
        {
            get
            {
                return this.cliente;
            }
            set
            {
                this.cliente = value;
            }
        }

        /// <summary>
        /// Muestra los datos del cliente asignado a la  venta
        /// </summary>
        /// <returns>string con los datos de la enta</returns>
        public string DatosCliente()
        {
            return $"Nombre: {Cliente.Nombre}   Apellido: {Cliente.Apellido}   Cuil: {Cliente.Cuil}";
        }
        
    }
}
