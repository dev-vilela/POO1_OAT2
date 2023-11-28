using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oat2
{
    public class exercice11
    {
        public void Exercice11()
        {
            Console.WriteLine("");
            Console.WriteLine("----- Exercicio 11  -----");
            Console.WriteLine("");

            Console.WriteLine("Informe o valor normal do produto: ");
            double precoN = double.Parse(Console.ReadLine());


            Console.WriteLine("Informa a forma  de pagamento (1, 2, 3 ou 4): ");
            int formaPagamento = Convert.ToInt32(Console.ReadLine());

           
            double valorPago = 0;

            switch (formaPagamento)
            {
                case 1:
                
                    valorPago = precoN - (precoN * 0.10);
                    break;

                case 2:
                    
                    valorPago = precoN - (precoN * 0.15);
                    break;

                case 3:
                 
                    valorPago = precoN;
                    break;

                case 4:
                    // Em duas vezes, preço normal de etiqueta mais juros de 10%
                    valorPago = precoN + (precoN * 0.10);
                    break;

                default:
                    Console.WriteLine("Opção não encotrado.");
                    return;
            }

            // Exibe o valor a ser pago
            Console.WriteLine($"Valor do produto a ser pago é : R$ {valorPago:C}");



            //-----------
        }
    }
}
