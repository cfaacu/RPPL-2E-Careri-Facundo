﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado : Persona
    {
        string usuario;
        string password;

        /// <summary>
        /// Constructor de Empleado
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        public Empleado(string usuario, string password,string nombre,string apellido,string cuil): base(nombre,apellido,cuil)
        {
            this.usuario = usuario;
            this.password = password;
        }

        public string Usuario
        {
            get
            {
                return this.usuario;
            }
            set
            {
                this.usuario = value;
            }
        }
        public string Password
        {
            get
            {
                return this.password;
            }
            set
            {
                this.password = value;
            }
        }

        /// <summary>
        /// Muestra los datos del empleado
        /// </summary>
        /// <returns>string con todos los datos del empleado</returns>
        public override string MostrarDatos()
        {
            return $"Usuario:{Usuario}     Nombre:{Nombre}     Apellido:{Apellido}     Cuil:{Cuil}";
        }
    }
}
