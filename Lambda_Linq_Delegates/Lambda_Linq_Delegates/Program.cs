﻿using System;
using Entities;
using System.Collections.Generic;
using System.Linq;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Product> list = new List<Product>();

            list.Add(new Product("Tv", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            /* list.ForEach(UpdatePrice);
             foreach(Product p in list)
             {
                 Console.WriteLine(p);
             }
         }*/
            List<string> result = list.Select(NameUpper).ToList();
            foreach(string s in result)
            {
                Console.WriteLine(s);
            }


        }
        static string NameUpper(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}