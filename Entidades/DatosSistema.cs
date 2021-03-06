using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class DatosSistema
    {
        static public List<Cliente> listaClientes;
        static public List<Empleado> listaEmpleados;
        static public List<Producto> listaProductos;
        static public List<Producto> listaProductoAux;
        static public Stack<Venta> PilaVentas;
        static private Cliente cliente;
        static private Empleado empleado;
        static private Administrador administrador;
        static private Producto producto;

        static DatosSistema()
        {
            listaClientes = new List<Cliente>();
            listaEmpleados = new List<Empleado>();
            listaProductos = new List<Producto>();
            listaProductoAux = new List<Producto>();
            PilaVentas = new Stack<Venta>();
            CargarDatos();
        }

        /// <summary>
        /// Hardcodea los datos al sistema.
        /// </summary>
        private static void CargarDatos()
        {
            Empleado emp1 = new Empleado("Facu", "asd123", "Facundo", "Careri", "20111111112");
            Empleado emp2 = new Empleado("Pepe1989", "asd12345", "Pepe", "Benitez", "20222222223");
            Administrador admin1 = new Administrador("Admin", "admin", "Admin", "Master", "20333333334");
            Administrador admin2 = new Administrador("Roberto", "robertitopro", "Roberto", "Carlos", "20444444445");
            Cliente cli1 = new Cliente("Nicolas", "Rodriguez", "20555555556", 15000);
            Cliente cli2 = new Cliente("Bruno", "Carlos", "20666666667", 2500);
            Producto pro1 = new Producto(1,"Cama Gatuna", 1000, "Para gatos dormilones","Camas",10,5);
            Producto pro2 = new Producto(2,"Soga", 220, "Para gatos juguetones","Juguetes",20,0.5);
            Producto pro3 = new Producto(3,"Hueso", 200, "Para perros con dientes afilados", "Juguetes",25,0.2);
            Producto pro4 = new Producto(4,"Cama Perruna", 2000, "Para perros dormilones","Camas",12,10);
            Producto pro5 = new Producto(5,"Shampoo Gatuno",600, "Para gatos limpios", "Cuidado",8,1);
            Producto pro6 = new Producto(6,"Shampoo Perruno",600, "Para perros limpios", "Cuidado",6,1);
            Producto pro7 = new Producto(7,"Comida Perruna", 3000, "Para perros hambrientos", "Alimentos",200,35);
            Producto pro8 = new Producto(8,"Comida Gatuna", 2500, "Para gatos hambrientos", "Alimentos",210,39);
            Stack<Producto> carrito1 = new Stack<Producto>();
            Stack<Producto> carrito2 = new Stack<Producto>();
            carrito1.Push(pro1);
            carrito1.Push(pro2);
            carrito1.Push(pro3);
            carrito2.Push(pro3);
            carrito2.Push(pro8);
            Venta venta1 = new Venta(carrito1, 1440, cli1);
            Venta venta2 = new Venta(carrito1, 2700, cli2);
            listaProductos.Add(pro1);
            listaProductos.Add(pro2);
            listaProductos.Add(pro3);
            listaProductos.Add(pro4);
            listaProductos.Add(pro5);
            listaProductos.Add(pro6);
            listaProductos.Add(pro7);
            listaProductos.Add(pro8);
            listaEmpleados.Add(emp1);
            listaEmpleados.Add(emp2);
            listaEmpleados.Add(admin1);
            listaEmpleados.Add(admin2);
            listaClientes.Add(cli1);
            listaClientes.Add(cli2);
            PilaVentas.Push(venta1);
            PilaVentas.Push(venta2);
        }
        /// <summary>
        /// Logica del logueo del usuario
        /// </summary>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>Devuelve al Empleado logueado</returns>
        public static Empleado LoguearUsuario(string usuario, string password)
        {
            if ((!string.IsNullOrEmpty(usuario)) && (!string.IsNullOrEmpty(password)))
            {
                foreach (Empleado item in listaEmpleados)
                {
                    if (item.Usuario.Trim().ToLower() == usuario.Trim().ToLower() && item.Password.Trim() == password.Trim())
                    {
                        return item;
                    }
                }
            }
            UsuarioInvalidoException usuarioInvalido = new UsuarioInvalidoException("Credenciales ingresadas invalidas");
            throw usuarioInvalido;
        }

        /// <summary>
        /// Da de alta un cliente a la lista de clientes
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="saldo"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool AltaCliente(string nombre, string apellido, string cuil, double saldo)
        {
            if (Validaciones.ValidarCampos(nombre, apellido, saldo) && !Validaciones.EstaPersona(cuil))
            {
                cliente = new Cliente(nombre, apellido, cuil, saldo);
                listaClientes.Add(cliente);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Da de alta un empleado a la lista de empleados
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool AltaEmpleado(string nombre, string apellido, string cuil,string usuario, string password)
        {
            if(Validaciones.ValidarCampos(nombre,apellido,password) && !Validaciones.EstaPersona(cuil))
            {
                empleado = new Empleado(usuario, password, nombre, apellido, cuil);
                listaEmpleados.Add(empleado);
                return true;
            }
            return false;
        }
        /// <summary>
        /// DA de alta un administrador a la lista de empleados
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool AltaAdministrador(string nombre, string apellido, string cuil, string usuario, string password)
        {
            if (Validaciones.ValidarCampos(nombre, apellido, password) && !Validaciones.EstaPersona(cuil))
            {
                administrador = new Administrador(usuario, password, nombre, apellido, cuil);
                listaEmpleados.Add(administrador);
                return true;
            }
            return false;
        }
        /// <summary>
        /// Da de alta un producto a la lista de productos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="tipoProducto"></param>
        /// <param name="cantidad"></param>
        /// <returns>true si se pudo o false si no se pudo</returns>
        public static bool AltaProducto(string nombre, string descripcion, double precio, string tipoProducto, int cantidad,double peso)
        {
            if (Validaciones.ValidarCamposProducto(nombre, descripcion, precio, cantidad, tipoProducto))
            {
                producto = new Producto(nombre, precio, descripcion, tipoProducto, cantidad,peso);
                listaProductos.Add(producto);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Modifica un cliente de la lista de clientes
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="saldo"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool ModificarCliente(string nombre,string apellido,string cuil,double saldo)
        {
            if (Validaciones.ValidarCampos(nombre, apellido, saldo))
            {
                for (int i = 0; i < DatosSistema.listaClientes.Count(); i++)
                {
                    if (DatosSistema.listaClientes[i].Cuil.Equals(cuil))
                    {
                        DatosSistema.listaClientes.Remove(DatosSistema.listaClientes[i]);
                        cliente = new Cliente(nombre, apellido, cuil, saldo);
                        DatosSistema.listaClientes.Add(cliente);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Modifica un empleado de la lista de empleados
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool ModificarEmpleado(string nombre, string apellido, string cuil, string usuario, string password)
        {
            if (Validaciones.ValidarCampos(nombre, apellido, cuil,password))
            {
                for (int i = 0; i < DatosSistema.listaEmpleados.Count(); i++)
                {
                    if (DatosSistema.listaEmpleados[i].Cuil.Equals(cuil))
                    {
                        DatosSistema.listaEmpleados.Remove(DatosSistema.listaEmpleados[i]);
                        empleado = new Empleado(usuario, password,nombre, apellido, cuil);
                        DatosSistema.listaEmpleados.Add(empleado);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Modifica un administrador de la lista de empleados
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="cuil"></param>
        /// <param name="usuario"></param>
        /// <param name="password"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool ModificarAdministrador(string nombre,string apellido,string cuil, string usuario, string password)
        {
            if (Validaciones.ValidarCampos(nombre, apellido, cuil, password))
            {
                for (int i = 0; i < DatosSistema.listaEmpleados.Count(); i++)
                {
                    if (DatosSistema.listaEmpleados[i].Cuil.Equals(cuil))
                    {
                        DatosSistema.listaEmpleados.Remove(DatosSistema.listaEmpleados[i]);
                        administrador = new Administrador(usuario, password, nombre, apellido, cuil);
                        DatosSistema.listaEmpleados.Add(administrador);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Modifica un producto de la lista de productos
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="tipoProducto"></param>
        /// <param name="cantidad"></param>
        /// <param name="id"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool ModificarProducto(string nombre, string descripcion, double precio, string tipoProducto, int cantidad, int id,double peso)
        {
            if (Validaciones.ValidarCamposProducto(nombre, descripcion, precio, cantidad, tipoProducto, id))
            {
                for (int i = 0; i < DatosSistema.listaProductos.Count(); i++)
                {
                    if (DatosSistema.listaProductos[i].Id.Equals(id))
                    {
                        DatosSistema.listaProductos.Remove(DatosSistema.listaProductos[i]);
                        producto = new Producto(nombre, precio, descripcion, tipoProducto, cantidad,peso);
                        DatosSistema.listaProductos.Add(producto);
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Da de baja un cliente de la lista de clientes
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool BajaCliente(string cuil)
        {
            if(Validaciones.ValidarCampos(cuil))
            {
                for (int i = 0; i < DatosSistema.listaClientes.Count(); i++)
                {
                    if(DatosSistema.listaClientes[i].Cuil.Equals(cuil))
                    {
                        DatosSistema.listaClientes.Remove(listaClientes[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Da de baja un empleado de la lista de empleados
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool BajaEmpleados(string cuil)
        {
            if (Validaciones.ValidarCampos(cuil))
            {
                for (int i = 0; i < DatosSistema.listaEmpleados.Count(); i++)
                {
                    if (DatosSistema.listaEmpleados[i].Cuil.Equals(cuil) && DatosSistema.listaEmpleados[i].GetType() == typeof(Empleado))
                    {
                        DatosSistema.listaEmpleados.Remove(listaEmpleados[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Da de baja un administrador de la lista de administradores
        /// </summary>
        /// <param name="cuil"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool BajaAdministrador(string cuil)
        {
            if (Validaciones.ValidarCampos(cuil))
            {
                for (int i = 0; i < DatosSistema.listaEmpleados.Count(); i++)
                {
                    if (DatosSistema.listaEmpleados[i].Cuil.Equals(cuil) && DatosSistema.listaEmpleados[i].GetType() == typeof(Administrador))
                    {
                        DatosSistema.listaEmpleados.Remove(listaEmpleados[i]);
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Da de baja un producto de la lista de productos
        /// </summary>
        /// <param name="id"></param>
        /// <returns>true si se pudo o false si no se pudo</returns>
        public static bool BajaProducto(int id)
        {
            if(Validaciones.ValidarCamposProducto(id))
            {
                for (int i = 0; i < DatosSistema.listaProductos.Count(); i++)
                {
                    if (DatosSistema.listaProductos[i].Id.Equals(id))
                    {
                        DatosSistema.listaProductos.Remove(listaProductos[i]);
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Calcula el precio total de un stack de productos recibido
        /// </summary>
        /// <param name="carrito"></param>
        /// <returns>El precio total del stack recibido</returns>
        public static double PrecioTotal(Stack<Producto> carrito)
        {
            double precioTotal = 0;
            if(!(carrito is null))
            {
                foreach (Producto item in carrito)
                {
                    precioTotal += item.Precio;
                }
                return precioTotal;
            }
            return double.MinValue;
        }
        /// <summary>
        /// Resta el dinero al cliente seleccionado para realizar una compra
        /// </summary>
        /// <param name="cuil"></param>
        /// <param name="precioTotal"></param>
        /// <returns>True si se pudo o false si no se pudo</returns>
        public static bool RestarDineroCliente(string cuil, double precioTotal)
        {
            if(Validaciones.IsCuil(cuil) && precioTotal > 0)
            {
                foreach (Cliente item in listaClientes)
                {
                    if (item.Cuil.Equals(cuil) && item.Saldo >= precioTotal)
                    {
                        item.Saldo -= precioTotal;
                        return true;
                    }
                }
            }
            ClienteSinDineroException clienteSinDinero = new ClienteSinDineroException();
            throw clienteSinDinero;
        }
    }
}
