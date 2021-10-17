using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        double saldo;

        /// <summary>
        /// Constructor de Clientes
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="saldo"></param>
        public Cliente(string nombre,string apellido,string cuil,double saldo): base(nombre,apellido,cuil)
        {
            this.saldo = saldo;
        }

        public double Saldo
        {
            get
            {
                return this.saldo;
            }
            set
            {
                this.saldo = value;
            }
        }
        /// <summary>
        /// Sobrecarga de operador explicito que devuelve el cliente con mayor saldo
        /// </summary>
        /// <param name="cliente"></param>
        public static explicit operator double(Cliente cliente)
        {
            Cliente clienteAux = null;
            double saldoMaximo = 0;
            foreach (Cliente item in DatosSistema.listaClientes)
            {
                if(item.Saldo >= saldoMaximo)
                {
                    saldoMaximo = item.Saldo;
                    clienteAux = item;
                }
            }
            return clienteAux.Saldo;
        }
        /// <summary>
        /// Sobrecarga del operador +, suma dinero al saldo total
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="dinero"></param>
        /// <returns>Cliente con el nuevo saldo</returns>
        public static Cliente operator +(Cliente cliente, double dinero)
        {
            cliente.Saldo = cliente.Saldo + dinero;
            return cliente;
        }
        /// <summary>
        /// Muestra los datos del cliente
        /// </summary>
        /// <returns>string cadena con todos los datos</returns>
        public override string MostrarDatos()
        {
            return $"Nombre: {Nombre}     Apellido: {Apellido}     Cuil: {Cuil}     Saldo: {Saldo}";
            #region Consultar
            //StringBuilder sb = new StringBuilder();
            //sb.Append($"Nombre:{ this.Nombre}");
            //sb.AppendLine($"Apellido:{ this.Apellido}");
            //sb.AppendLine($"Cuil:{this.Cuil}");
            //sb.AppendLine($"Saldo:{this.Saldo}");
            //return sb.ToString();
            #endregion
        }

    }
}
