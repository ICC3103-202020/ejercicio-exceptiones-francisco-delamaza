using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Excepciones
{
    class ExcepcionCero:ApplicationException
    {
        private readonly int divider;

        public int Divider { get { return divider; } }

        public ExcepcionCero(int d, string message):base(message)
        {
            this.divider = d;
            
            
            
        }
    }
}
