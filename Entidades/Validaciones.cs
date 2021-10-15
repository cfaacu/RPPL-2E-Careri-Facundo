namespace Entidades
{
    public static class Validaciones
    {
        /// <summary>
        /// Valida que la cadena recibida sea solo letras
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool IsStringOnlyLetters(string nombre)
        {
            nombre = nombre.ToLower();
            for (int i = 0; i < nombre.Length; i++)
            {
                if (!(nombre[i] >= 'a' && nombre[i] <= 'z' || nombre[i] == ' '))
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Valida que el cuil sea correcto
        /// </summary>
        /// <param name="cuils"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool IsCuil(string cuils)
        {
            double.TryParse(cuils, out double cuil);
            char[] ponderador = { '5', '4', '3', '2', '7', '6', '5', '4', '3', '2' };
            int i;
            double suma = 0;
            char[] numero = cuil.ToString("00000000000").ToCharArray();
            for (i = 0; i < 10; i++)
            {
                suma += (int.Parse(ponderador[i].ToString()) * int.Parse(numero[i].ToString()));
            }

            suma = suma % 11;
            suma = 11 - suma;

            suma = suma == 10 ? 0 : suma == 11 ? 1 : suma;


            return suma == int.Parse(numero[10].ToString());

        }
        /// <summary>
        /// Valida que los campos ingresados sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="saldo"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool ValidarCampos(string nombre, string apellido, string cuil, double saldo)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.IsStringOnlyLetters(nombre))
            {
                if (!string.IsNullOrEmpty(apellido) && Validaciones.IsStringOnlyLetters(apellido))
                {
                    if (!string.IsNullOrEmpty(cuil) && Validaciones.IsCuil(cuil))
                    {
                        if (saldo > 0)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que los campos ingresados sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="saldo"></param>
        /// <returns>true si es correcto o false si los datos son incorrectos</returns>
        public static bool ValidarCampos(string nombre, string apellido, double saldo)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.IsStringOnlyLetters(nombre))
            {
                if (!string.IsNullOrEmpty(apellido) && Validaciones.IsStringOnlyLetters(apellido))
                {
                    if (saldo > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que los campos ingresados sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <returns>Devuelve true si son correctos o false si son incorrectos</returns>
        public static bool ValidarCampos(string nombre, string apellido, string cuil, string password)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.IsStringOnlyLetters(nombre))
            {
                if (!string.IsNullOrEmpty(apellido) && Validaciones.IsStringOnlyLetters(apellido))
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        if (!string.IsNullOrEmpty(cuil) && Validaciones.IsCuil(cuil))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que los campos ingresados sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="password"></param>
        /// <returns>true si son correctos, false si son incorrectos</returns>
        public static bool ValidarCampos(string nombre, string apellido, string password)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.IsStringOnlyLetters(nombre))
            {
                if (!string.IsNullOrEmpty(apellido) && Validaciones.IsStringOnlyLetters(apellido))
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                       return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que los campos ingresados sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool ValidarCampos(string nombre, string apellido, string cuil, string usuario, string password)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.IsStringOnlyLetters(nombre))
            {
                if (!string.IsNullOrEmpty(apellido) && Validaciones.IsStringOnlyLetters(apellido))
                {
                    if (!string.IsNullOrEmpty(cuil) && Validaciones.IsCuil(cuil))
                    {
                        if (!string.IsNullOrEmpty(usuario))
                        {
                            if (!string.IsNullOrEmpty(password))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que los campos ingresados sean correctos
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool ValidarCampos(string cuil)
        {
            if (!string.IsNullOrEmpty(cuil) && Validaciones.IsCuil(cuil))
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que los campos ingresados sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="precio"></param>
        /// <param name="descripcion"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool ValidarCampos(string nombre, double precio, string descripcion)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.IsStringOnlyLetters(nombre))
            {
                if (!string.IsNullOrEmpty(descripcion))
                {
                    if (precio > 0)
                    {
                        return true;
                    }

                }
            }
            return false;
        }
        /// <summary>
        /// Valida que los campos del producto sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="tipoProducto"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool ValidarCamposProducto(string nombre, string descripcion, double precio, double cantidad, string tipoProducto)
        {
            if (!string.IsNullOrEmpty(nombre) && Validaciones.IsStringOnlyLetters(nombre))
            {
                if (!string.IsNullOrEmpty(descripcion))
                {
                    if (precio > 0)
                    {
                        if (precio > 0)
                        {
                            if (!string.IsNullOrEmpty(tipoProducto))
                            {
                                return true;
                            }
                        }
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que los campos del producto sean correctos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="cantidad"></param>
        /// <param name="tipoProducto"></param>
        /// <param name="id"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool ValidarCamposProducto(string nombre, string descripcion, double precio, double cantidad, string tipoProducto, int id)
        {
            if (ValidarCamposProducto(nombre, descripcion, precio, cantidad, tipoProducto))
            {
                if (id > 0)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que el id del producto sea correcto
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool ValidarCamposProducto(int id)
        {
            if (id > 0)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// Valida que la persona del cuil ingresado este en la lista
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool EstaPersona(string cuil)
        {
            if (Validaciones.ValidarCampos(cuil))
            {
                foreach (Cliente item in DatosSistema.listaClientes)
                {
                    if (item.Cuil.Equals(cuil))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que la persona del cuil ingresado este en la lista
        /// </summary>
        /// <param name="cuil"></param>
        /// <param name="cliente"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool EstaPersona(string cuil, out Cliente cliente)
        {
            if (Validaciones.ValidarCampos(cuil))
            {
                foreach (Cliente item in DatosSistema.listaClientes)
                {
                    if (item.Cuil.Equals(cuil))
                    {
                        cliente = item;
                        return true;
                    }
                }
            }
            cliente = null;
            return false;
        }
        /// <summary>
        /// Valida que el usuario ingresado este en la lista
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool EstaUsuario(string usuario)
        {
            if (!(usuario is null))
            {
                foreach (Empleado item in DatosSistema.listaEmpleados)
                {
                    if (item.Usuario.ToLower().Trim().Equals(usuario.ToLower().Trim()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Valida que el id ingresado este en la lista
        /// </summary>
        /// <param name="id"></param>
        /// <returns>True si es correcto o false si es incorrecto</returns>
        public static bool EstaId(int id)
        {
            if (id > 0)
            {
                foreach (Producto item in DatosSistema.listaProductos)
                {
                    if (item.Id == id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
