using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class CM
    {
        enum state
        {
            esperando,
            procesando_moneda,
            retirando_producto,
            devolviendo_cambio
        }
        private state;
        public void GetState()
        {
            return state;
        }
    }
}
