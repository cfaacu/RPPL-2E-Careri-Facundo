using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{    public class Administrador : Empleado
    {
        /// <summary>
        /// Constructor de Administrador
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        public Administrador(string usuario,string password,string nombre,string apellido,string cuil):base(usuario,password,nombre,apellido,cuil)
        {

        }
        /// <summary>
        /// Devuelve los datos del Administrador
        /// </summary>
        /// <returns>String cadena con todos los datos</returns>
        public override string MostrarDatos()
        {
            return base.MostrarDatos();
        }
    }
}
