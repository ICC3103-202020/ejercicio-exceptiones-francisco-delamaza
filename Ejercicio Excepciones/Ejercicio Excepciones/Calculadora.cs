using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Excepciones
{
    class Calculadora
    {
        public void Divivir(int x, int y)
        {
            try
            {
                int ssss = x / y;
                var resultado = Convert.ToDouble(x) / Convert.ToDouble(y);
                
                Console.WriteLine(resultado);
                Console.WriteLine("El resuldado es {0}", resultado);
            }
            catch
            {

                throw new ExcepcionCero(Convert.ToInt32(x),"Trato de dividir por 0");
            }
        }
    }
}
