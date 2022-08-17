using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quantidade_de_clientes_que_abasteceu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;

            Console.WriteLine("Por favor digite o produto abastecido no momento:");
            int produto = int.Parse(Console.ReadLine());

            while (produto != 4)
            {
                
                if (produto == 1)
                {
                    Console.WriteLine("Voce abasteceu com ALCOOl");
                    alcool = alcool + 1;
                }

                else if (produto == 2)
                {
                    Console.WriteLine("Voce abasteceu com GASOLINA");
                    gasolina = gasolina + 1;

                }
                else if (produto == 3)
                {
                    Console.WriteLine("Voce abasteceu com DIESEL");
                    diesel = diesel + 1;
                }
                else
                {
                    Console.WriteLine("Opção Invalida, digite novamente:");
                }

                produto = int.Parse (Console.ReadLine());

            }
            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}
