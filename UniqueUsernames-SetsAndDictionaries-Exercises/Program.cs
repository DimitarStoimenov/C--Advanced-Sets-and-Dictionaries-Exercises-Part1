using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop_Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            HashSet<string> first = new HashSet<string>();


            for (int i = 0; i < num; i++)
            {


                first.Add(Console.ReadLine());

            }




            Console.WriteLine(string.Join(Environment.NewLine, first));
        }
    }
}
