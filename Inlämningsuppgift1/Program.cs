using System;
using System.Collections.Generic;
using System.Linq;

namespace Inlämningsuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "MagicCalculator";

            String end = "yes";
            List<int> sumList = new List<int>();

            while (end != "no")
            {
                Console.Write("> Enter the first operator: ");
                String o1 = Console.ReadLine();

                Console.Write("> Enter the second operator: ");
                String o2 = Console.ReadLine();

                Console.Write("> Enter the first term: ");
                String nbr1 = Console.ReadLine();

                Console.Write("> Enter the second term: ");
                String nbr2 = Console.ReadLine();

                Console.Write("> Enter the third term: ");
                String nbr3 = Console.ReadLine();

                int nbr1Int = Convert.ToInt32(nbr1);
                int nbr2Int = Convert.ToInt32(nbr2);
                int nbr3Int = Convert.ToInt32(nbr3);
                int partSum; // första uträkningen 
                int sum; // slutgiltga summan 

                partSum = Operator1(nbr1Int, nbr2Int, o1); 
                sum = Operator2(partSum, nbr3Int, o2);
                MagicTextEquation(o1, o2, nbr1, nbr2, nbr3, sum); 
                MagicTextSum(sum);
                sumList.Add(sum);

                Console.Write("> Do you want to continue? 1. yes 2. no: ");
                end = Console.ReadLine();

            }

            Console.WriteLine("> the value of all your equations is: " + sumList.Sum());


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

        static int Operator1(int nbr1, int nbr2, string op1)
        {
            if (op1 == "+") return nbr1 + nbr2;
            else if (op1 == "-") return nbr1 - nbr2;
            else if (op1 == "*") return nbr1 * nbr2;
            else if (op1 == "/") return nbr1 / nbr2;

           throw new ArgumentException("> Specify a valid operator", "op");
        }

        static int Operator2(int sum, int nbr3, string op2)
        {
            if (op2 == "+") return sum + nbr3;
            else if (op2 == "-") return sum - nbr3;
            else if (op2 == "*") return sum * nbr3;
            else if (op2 == "/") return sum / nbr3;

            throw new ArgumentException("> Specify a valid operator", "op");
        }
    }

   
}
