using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop_Dictionaries_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(input.Split()[0]);
            int num2 = int.Parse(input.Split()[1]);
            HashSet<double> first = new HashSet<double>();
            HashSet<double> second = new HashSet<double>();

            for (int i = 0; i < num1; i++)
            {
                double inp1 = double.Parse(Console.ReadLine());
                first.Add(inp1);

            }
            for (int i = 0; i < num2; i++)
            {

                double inp2 = double.Parse(Console.ReadLine());
                second.Add(inp2);

            }

            first.IntersectWith(second);

            Console.WriteLine(string.Join(" ", first));
        }
    }
}
