using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice4
    {
        public void Exercice4()
        {
            Console.WriteLine("");
            Console.WriteLine("Exercicio 04");
            Console.WriteLine("");

            int soma = 0;
            int mult = 0;
            int C = 0;

            Console.WriteLine("Digite o valor de A:");
            int A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B:");
            int B = int.Parse(Console.ReadLine());

            if (A == B)
            {
                soma = A + B;
                C = soma;
                Console.WriteLine("O Resultado da soma de A + B é :" + C);
            }
            else
            {
                mult = A * B;
                C = mult;
                Console.WriteLine("O Resultado da Multiplicação de A * B é:" + C);
            }


        }
    }
}
