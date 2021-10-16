using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Envio
    {
        double precio;
        Enumerados.ETipoEnvio tipoEnvio;
        double distancia;

        public Envio(double precio, Enumerados.ETipoEnvio tipoEnvio)
        {
            this.precio = precio;
            this.tipoEnvio = tipoEnvio;
            this.distancia = GenerarNumeroRandom();
        }
        public Envio()
        {
            this.distancia = GenerarNumeroRandom();
        }
        public double Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if(value > 0)
                this.precio = value;
            }
        }

        public Enumerados.ETipoEnvio TipoEnvio
        {
            get
            {
                return this.tipoEnvio;
            }
            set
            {
                this.tipoEnvio = value;
            }
        }

        public double Distancia
        {
            get
            {
                return this.distancia;
            }
        }

        private double GenerarNumeroRandom()
        {
            Random r = new Random();
            return r.Next(1, 300);
        }
        public double CalcularPrecio(Venta venta)
        {
            double precioEnvio = 200;
            if(Distancia >= 100 && Distancia <= 199)
            {
                precioEnvio = 300;
            }
            else if (Distancia >= 200 && Distancia > 250)
            {
                precioEnvio = 350;
            }
            else if(Distancia > 250)
            {
                precioEnvio = 380;
            }

            if(venta.Carrito.Count() >= 10 || Enumerados.ETipoEnvio.Miniflete == CalcularTipoTransporte(venta))
            {
                precioEnvio = precioEnvio + 150;
                return precioEnvio;
            }
            else
            {
                return precioEnvio;
            }
        }

        private Enumerados.ETipoEnvio CalcularTipoTransporte(Venta venta)
        {
            double pesoTotal = 0;
            foreach (Producto item in venta.Carrito)
            {
                pesoTotal = pesoTotal + item.Peso;
            }

            if(pesoTotal >= 10)
            {
                return Enumerados.ETipoEnvio.Miniflete;
            }
            else
            {
                return Enumerados.ETipoEnvio.Moto;
            }
        }
    }
}
