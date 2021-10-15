using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioInvalidoException:Exception
    {
        public UsuarioInvalidoException(string mensaje):base(mensaje)
        {

        }
    }
}
