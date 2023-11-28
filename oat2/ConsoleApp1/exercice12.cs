using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice12
    {
        public void Exercice12()
        {
            Console.WriteLine("");
            Console.WriteLine("----- Exercicio 12 -----");
            Console.WriteLine("");

            Console.WriteLine("Informe o nome do Aluno: ");
            string nome = Console.ReadLine();
            Console.Write("Informe o número de identificação do aluno: ");
            int idAluno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a primeira nota do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota do aluno: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Digite a terceira nota do aluno: ");
            double nota3 = double.Parse(Console.ReadLine());

            Console.Write("Informe a média dos exercícios do aluno: ");
            double mediaExercicios = double.Parse(Console.ReadLine());

            double mediaAproveitamento = (nota1 + nota2 * 2 + nota3 * 3 + mediaExercicios) / 7;

            Console.WriteLine($"A média  do aluno {nome} da idetificação {idAluno} é : {mediaAproveitamento:F2}");


            Console.ReadLine();


            //-----------
        }
    }
}
