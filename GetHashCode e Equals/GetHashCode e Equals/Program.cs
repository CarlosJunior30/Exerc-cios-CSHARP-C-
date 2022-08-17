using System;
using Entities;

namespace GetHashCode_e_Equals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client{ Name = "Maria", Email = "Maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "Alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b );
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode()); 


        }
    }
}
