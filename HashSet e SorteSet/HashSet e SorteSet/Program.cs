﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet_e_SorteSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* HashSet<string> set = new HashSet<string>();

             set.Add("Tv");
             set.Add("Computador");
             set.Add("Tablet");

             Console.WriteLine(set.Contains("Notebook"));

             foreach(string p in set)
             {
                 Console.WriteLine(p);
             } */


            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int> (){ 5, 6, 7, 8, 9, 10 };

            //union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);
            PrintCollection(c);

            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);
            PrintCollection(d);

            //DIFFERENCE
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);

        }

        static void PrintCollection <T>(IEnumerable <T> collection)
            {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            
            
            }
    }
}
