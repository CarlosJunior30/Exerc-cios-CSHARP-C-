using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("por favor informe valor total da compra: ");
            string valortotal = Console.ReadLine();
            double valortotalpago = Convert.ToDouble(valortotal);

            Console.WriteLine("por favor informe valor pago pelo cliente: ");
            string valorPagoLciente = Console.ReadLine();
            Double valortotalpagoCLiente = Convert.ToDouble(valorPagoLciente);

            double resultadotroco = (valortotalpagoCLiente - valortotalpago);
            Console.WriteLine("o troco e de : " + resultadotroco);
          
            if (resultadotroco > 0)
            {
                
                Console.WriteLine("tem troco");
            }
            else
            {
                Console.WriteLine("obrigado, volte sempre");
            }




        }
    }
}
