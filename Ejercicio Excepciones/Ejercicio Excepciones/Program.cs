using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            
            Console.WriteLine("Ingrese un numero entero para el dividendo");
            
            string x = Console.ReadLine();
            Console.WriteLine("Ingrese un numero entero para el divisor");
            string y = Console.ReadLine();
            
            try
            {
                int x1 = Convert.ToInt32(x);
                int y2 = Convert.ToInt32(y);
                c.Divivir(x1, y2);
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
                
            }
            
            
            Console.ReadKey();
        }
    }
}
