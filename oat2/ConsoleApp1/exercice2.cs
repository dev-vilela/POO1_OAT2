using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice2
    {
        public void Exercice2()
        {

            Console.WriteLine("");
            Console.WriteLine("Exercicio 02");
            Console.WriteLine("");


            Console.WriteLine("Olá seja Bem-Vindos");
                Console.WriteLine("Por favor,informe seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Agora, nos informa seu sexo (M para masculino, F para feminino): ");
                string sexo = Console.ReadLine();
                Console.WriteLine($"Nos informe seu estado civil {nome}: casada(o) ou solteira(o): ");
                string estadocivil = Console.ReadLine();

                if (sexo == "F" && estadocivil == "Casada") ;
                {
                    Console.WriteLine($"Quantos anos você tem de Casada {nome}? ");
                    int anos = int.Parse(Console.ReadLine());
                    Console.WriteLine("Você é casada há " + anos + " anos!");
                }

            
        }
    }
}