using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice6
    {
        public void Exercice6()
        {
            Console.WriteLine("");
            Console.WriteLine("----- Exercicio 06 -----");
            Console.WriteLine("");

            Console.WriteLine("Informe o primeiro  valor booleano: ");
            bool num1 = bool.Parse(Console.ReadLine());


            Console.WriteLine("Informe o segundo valor booleano: ");
            bool num2 = bool.Parse(Console.ReadLine());

            if (num1 && num2)
            {
                Console.WriteLine("Os valores informado são verdadeiros."); 
            }
            else
            {
                Console.WriteLine("Um  dos valores são informado são Falsos.");

            }




            //-----------
        }
    }
}
