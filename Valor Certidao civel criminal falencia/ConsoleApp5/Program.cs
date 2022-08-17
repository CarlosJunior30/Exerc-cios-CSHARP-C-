using System;
using System.Globalization;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"por favor, informe o tipo de certidao que deseja requerer para saber o valor
                1 - certidao civel 
                2 - certidao criminal 
                3 - certidao de falencia");
            
            
            var pedido = Console.ReadLine();

            var emolumentosCivel = 88.35;
            var emolumentosCriminal = 73.15;
            var fetjCivel = 17.67;
            var fetjCriminal = 14.63;
            var funperjCivel = 4.41;
            var funperjCriminal = 3.65;
            var fundperjCivel = 4.41;
            var fundperjCriminal = 3.65;
            var funarpenCivel = 3.53;
            var funarpenCriminal = 2.92;
            var issCivel = 4.41;
            var issCriminal = 3.90;

            var ValorCertidaoCivel = (emolumentosCivel + fetjCivel + funperjCivel + fundperjCivel + funarpenCivel + issCivel);
            var ValorcertidaoCriminal = (emolumentosCriminal + fetjCriminal + funperjCriminal + fundperjCriminal + funarpenCriminal + issCriminal);
            var ValorCertidaoFalencia = (emolumentosCivel + fetjCivel + funperjCivel + fundperjCivel + funarpenCivel + issCivel);

            switch (pedido)
            {
                case "1":
                    
                    Console.WriteLine("sua certidao é modelo civel e o valor é R$" +  Math.Round(ValorCertidaoCivel, 2) );
                    break;

                case "2":
                    Console.WriteLine("sua certidao é modelo criminal é R$" + ValorcertidaoCriminal);
                    break;

                case "3":
                    Console.WriteLine("sua certidao é modelo de falencia é R$" + ValorCertidaoFalencia);
                    break;

                default:
                    Console.WriteLine("opção invalida");
                    return;
            }
        }
    }
}
