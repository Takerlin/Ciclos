using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numero, exponente, i;
            double resultado = 1, resultadonegativo;

            Console.Write("ingresa la base ");
            numero = Convert.ToDecimal(Console.ReadLine());

            Console.Write("ingresa el exponente");
            exponente = Convert.ToDecimal(Console.ReadLine());

            if (exponente < 0)
            {
                i = 1;

            }
            if (exponente > 0)
            {
                exponente = exponente * -1;
                i = 1;

            }
        }
    }
}
