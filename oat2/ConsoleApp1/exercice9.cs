using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice9
    {
        public void Exercice9()
        {
            Console.WriteLine("");
            Console.WriteLine("----- Exercicio 09 -----");
            Console.WriteLine("");

            Console.WriteLine("Informe sua Altura: ");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Agora, nos informa seu sexo (M para masculino, F para feminino):  ");
            string sexo = Console.ReadLine();

            if (sexo == "Masculino")

            {
                double pesoIdeal = (72.7 * altura) - 58;
                Console.WriteLine("Peso ideal para o sexo Masculino é de : " + pesoIdeal);
            }
            else
            {
                double pesoIdeal = (62.1 * altura) - 44.7;
                Console.WriteLine("Peso ideal para o sexo Feminino é de :" + pesoIdeal);
            }


            //-----------******-----------
        }
    }
}
