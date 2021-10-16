using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enumerados
    {
        public enum ERango
        {
            cliente,
            administrador,
            empleado,
            producto
        }
        public enum ETipo
        {
            Alimentos,
            Juguetes,
            Camas,
            Cuidado
        }
        public enum ETipoEnvio
        {
            Moto = 80,
            Miniflete = 120
        }
    }
}
