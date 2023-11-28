using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice1
    {
        public void Exercice1()
        {
            Console.WriteLine("");
            Console.WriteLine("Exercicio 01");
            Console.WriteLine("");



            //pra que serve
            //tantos códigos?
            //se a vida
            //não é programada
            //e as melhores coisas
            //não tem lógica.

            Console.WriteLine("Informe  o valor de A: ");
                double A = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor de B: ");
                double B = double.Parse(Console.ReadLine());

                Console.WriteLine("Informe o valor de C: ");
                double C = double.Parse(Console.ReadLine());

                if (A + B < C)
                {
                    Console.WriteLine("O valor de A + B é menor que C. ");
                }
                else
                {
                    Console.WriteLine("O valor de A + B não é menor que C.");
                }
                Console.ReadLine();
            
        }
    }
}
