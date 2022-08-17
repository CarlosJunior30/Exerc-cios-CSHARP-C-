using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace calcule_e_mostre_o_valor_pago_na_peça
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, informe o codigo da peça 1 :");
            int codigo1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, informe a quantidade de peças:");
            int Quantpecas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, informe o valor da peça 1: ");
            double Valorpeca1 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Por favor, informe o codigo da peça 2 :");
            int codigo2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, informe a quantidade de peças:");
            int Quantpecas2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor, informe o valor da peça 2: ");
            double Valorpeca2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double ValorTotal = (Quantpecas1 * Valorpeca1) + (Quantpecas2 * Valorpeca2);

            Console.WriteLine("O valor total a ser pago é de R$ " + ValorTotal.ToString("F2",CultureInfo.InvariantCulture));

            Console.ReadLine();








        }
    }
}
