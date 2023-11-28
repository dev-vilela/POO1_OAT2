using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice7
    {
        public void Exercice7()
        {
            Console.WriteLine("");
            Console.WriteLine("----- Exercicio 07 -----");
            Console.WriteLine("");

            Console.WriteLine("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Este numero é par ");
                numero += 5;
            }
            else
            {
                Console.WriteLine("Este numero é impar");
                numero += 8;
            }
            Console.WriteLine("O resultado é: " + numero);




            //-----------
        }
    }
}
