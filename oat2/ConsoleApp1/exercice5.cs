using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice5
    {
        public void Exercice5()
        {
            Console.WriteLine("");
            Console.WriteLine("Exercicio 05");
            Console.WriteLine("");

            Console.WriteLine("Olá Bem Vindos, a seguir será realizado um questionario, responda!");
            Console.WriteLine("Digite um valor positivo ou negativo");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                int resultado = numero * 2;
                Console.WriteLine("O valor digitado é positivo e o dobro dele é: " + resultado);
            }
            else
            {
                int resultado = numero * 3;
                Console.WriteLine("O valor digitado é negativo e o triplo dele é: " + resultado);
            }


        }
    }
}
