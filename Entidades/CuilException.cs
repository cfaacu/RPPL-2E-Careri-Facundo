using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CuilException:Exception
    {
        public CuilException(string mensaje) : base(mensaje)
        {

        }
    }
}
