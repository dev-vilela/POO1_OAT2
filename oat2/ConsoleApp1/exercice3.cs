using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice3
    {
        public void Exercice3()
        {
            Console.WriteLine("");
            Console.WriteLine("Exercicio 03");
            Console.WriteLine("");

            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Este numero é par ");
            }
            else
            {
                Console.WriteLine("Este numero é impar");
            }


        }
    }
}
