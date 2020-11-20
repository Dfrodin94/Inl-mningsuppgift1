using System;
using System.Collections.Generic;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            String end = "yes";

            while (end != "no")
            {
                Console.Write("> Enter the first operator: ");
                String o1 = Console.ReadLine();

                Console.Write("> Enter the second operator: ");
                String o2 = Console.ReadLine();

                Console.Write("> Enter the first term: ");
                String t1 = Console.ReadLine();

                Console.Write("> Enter the second term: ");
                String t2 = Console.ReadLine();

                Console.Write("> Enter the third term: ");
                String t3 = Console.ReadLine();

                int t1Int = Convert.ToInt32(t1);
                int t2Int = Convert.ToInt32(t2);
                int t3Int = Convert.ToInt32(t3);
                int sum;

                List<int> sumList = new List<int>();

                if (o1 == "+" && o2 == "+")
                {
                    sum = (t1Int + t1Int) + t3Int;
                    MagicTextEquation(o1, o2, t1, t2, t3, sum);
                    MagicTextSum(sum);
                    sumList.Add(sum);
                }

                else if (o1 == "-" && o2 == "+")
                {
                    sum = (t1Int - t1Int) + t3Int;
                    MagicTextEquation(o1, o2, t1, t2, t3, sum);
                    MagicTextSum(sum);
                    sumList.Add(sum);
                }

                Console.Write("> Do you want to continue? 1. yes 2. no: ");
                end = Console.ReadLine();

            }







        }

        static void MagicTextSum (int s)
        {
            if (s < 100)
            {
                Console.WriteLine("> The sum is less then a hundred");
            }

            else if (s == 100)
            {
                Console.WriteLine("> Cool, know you have a hundred, clap clap");

            }

            else if (s > 100)
            {
                Console.WriteLine("> The sum is more than a hundred");
            }


        }

        static void MagicTextEquation (string o1, string o2, string t1, string t2, string t3, int sum)
        {
            Console.WriteLine("> " + t1 + " " + o1 + " " + t2 + " " + o2 + " " + t3 + " " + "= " + sum);

        }
    }

   
}
