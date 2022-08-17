using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercado_horario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horario = 7;
            while (horario >= 7 && horario <=17)
            {
                Console.WriteLine("horario de funcionamento do mercado " + horario++ + "horas" + "estamos abertos!");
                

            }
            Console.WriteLine("o mercado fechour" + "horario de funcinamento de 7 as 17hrs");
            Console.ReadLine(); 
           



        }
    }
}
