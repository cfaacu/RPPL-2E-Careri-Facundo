using System;

namespace Entidades
{
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private string cuil;

        /// <summary>
        /// Constructor de Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        protected Persona(string nombre, string apellido, string cuil)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.cuil = cuil;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if(Validaciones.IsStringOnlyLetters(value))
                {
                    this.nombre = value;
                }
            }
        }
        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (Validaciones.IsStringOnlyLetters(value))
                {
                    this.apellido = value;
                }
            }
        }
        public string Cuil
        {
            get
            {
                return this.cuil;
            }
            set
            {
                if(Validaciones.IsCuil(value))
                {
                    this.cuil = value;
                }
            }
        }

        /// <summary>
        /// Muestra los datos de la persona
        /// </summary>
        /// <returns>String con los datos de la persona</returns>
        public virtual string MostrarDatos()
        {
            return $"Nombre:{Nombre}, Apellido:{Apellido}, Cuil:{Cuil}";
        }
    }
}
