using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice10
    {
        public void Exercice10()
        {
            Console.WriteLine("");
            Console.WriteLine("----- Exercicio 10 -----");
            Console.WriteLine("");

            Console.WriteLine("Qual é o seu Nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Informe seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine($"Olá {nome} seu  IMC é: {imc:F2}");

            if (imc < 18.5)
            {
                Console.WriteLine("Condição: Abaixo do peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Condição: Peso normal");
            }
            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("ALERTA: Acima do peso");
            }
            else
            {
                Console.WriteLine("ALERTA: Obeso");
            }
            Console.ReadLine();


            //-----------
        }
    }
}
