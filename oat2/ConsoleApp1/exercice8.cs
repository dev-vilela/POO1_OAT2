using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice8
    {
        public void Exercice8()
        {
            Console.WriteLine("");
            Console.WriteLine("----- Exercicio 08 -----");
            Console.WriteLine("");

            Console.WriteLine("Informe o primeiro valor inteiro: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo valor inteiro: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o terceiro valor inteiro: ");
            int c = int.Parse(Console.ReadLine());

            int temp;

            if (a < b)
            {
                temp = a;
                a = b;
                b = temp;
            }
            if (a < c)
            {
                temp = a;
                a = c;
                c = temp;
            }

            {
                if (b < c)
                {
                    temp = b;
                    b = c;
                    c = temp;
                }

                {
                    Console.WriteLine("Os valores em ordem decrescente são : " + a + ", " + b + ", " + c);


                }
            }


                    //-----------
                }
            }
}
