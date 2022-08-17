using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Controle_de_numero_e_salario_funcionario
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Por favor informe o numero do funcionario: ");
            int NumeroFunc = int.Parse (Console.ReadLine());
            Console.WriteLine("Por favor informe o numero de horas trabalhados: ");
            int NumeroHoras=int.Parse (Console.ReadLine());
            Console.WriteLine("Por favor informe o valor que o funcionario recebe por horas: ");
            double ValorHoras= double.Parse (Console.ReadLine(), CultureInfo.InvariantCulture);

            double SalarioFunc =   (NumeroHoras * ValorHoras);

            Console.WriteLine("O numero do funcionario é " + NumeroFunc);
            Console.WriteLine("O salario de o funcionaro é R$" + SalarioFunc.ToString ("F2",CultureInfo.InvariantCulture));

            Console.ReadLine(); 




        }
    }
}
