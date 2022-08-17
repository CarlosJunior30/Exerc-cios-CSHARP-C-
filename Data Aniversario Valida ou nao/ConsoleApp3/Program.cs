using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*             
             Escreva um programa que pergunte o dia, 
             mês e ano do aniversário de uma pessoa e 
             diga se a data é válida ou não. 
             Caso não seja, diga o motivo. 
             Suponha que todos os meses tem 31 dias e que estejamos no ano de 2013.             
              */

            Console.WriteLine("informe o dia de seu nascimento: ");
            string dianascimento = Console.ReadLine();
            int dianascimentodigitado = Convert.ToInt32(dianascimento);

            Console.WriteLine("informe o mes de seu nascimento: ");
            string mesnascimento = Console.ReadLine();
            int mesnascimentodigitado = Convert.ToInt32(mesnascimento);

            Console.WriteLine("informe o ano de seu nascimento: ");
            string anonascimento = Console.ReadLine();
            int anonascimentodigitado = Convert.ToInt32(anonascimento);
                                    
            if(dianascimentodigitado >= 1 && dianascimentodigitado <= 31 && mesnascimentodigitado >= 1 && mesnascimentodigitado <= 12 
               && anonascimentodigitado >= 1 && anonascimentodigitado <= 2013)
            {
                Console.WriteLine("data valida:" + dianascimentodigitado + "/" + mesnascimentodigitado + "/" + anonascimentodigitado);
            }
                       
            else
            {
                Console.WriteLine("data invalida");
            }



        }
    }
}
