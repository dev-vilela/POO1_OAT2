using System;

namespace oat2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int validador = 0;

            do
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("Exercicios 1 á 12");
                Console.WriteLine("  -1 Fechar o programa");

                int escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        exercice1 exercice1 = new exercice1();
                        exercice1.Exercice1();
                        break;

                    case 2:
                        exercice2 exercice2 = new exercice2();
                        exercice2.Exercice2();
                        break;

                    case 3:
                        exercice3 exercice3 = new exercice3();
                        exercice3.Exercice3();
                        break;

                    case 4:
                        exercice4 exercice4 = new exercice4();
                        exercice4.Exercice4();
                        break;

                    case 5:
                        exercice5 exercice5 = new exercice5();
                        exercice5.Exercice5();
                        break;

                    case 6:
                        exercice6 exercice6 = new exercice6();
                        exercice6.Exercice6();
                        break;

                    case 7:
                        exercice7 exercice7 = new exercice7();
                        exercice7.Exercice7();
                        break;

                    case 8:
                        exercice8 exercice8 = new exercice8();
                        exercice8.Exercice8();
                        break;

                    case 9:
                        exercice9 exercice9 = new exercice9();
                        exercice9.Exercice9();
                        break;

                    case 10:
                        exercice10 exercice10 = new exercice10();
                        exercice10.Exercice10();
                        break;

                    case 11:
                        exercice11 exercice11 = new exercice11();
                        exercice11.Exercice11();
                        break;

                    case 12:
                        exercice12 exercice12 = new exercice12();
                        exercice12.Exercice12();
                        break;

                    case -1:
                        Console.WriteLine("O programa será fechado");
                        Console.Read();
                        validador = -1;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            } while (validador != -1);
        }
    }
}
