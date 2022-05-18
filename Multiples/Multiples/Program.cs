using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber;
            int numberMultiples= 0;
            int numberSum =0;
            int maxMultiples;

            Random random = new Random();

            userNumber = random.Next(1, 28);
            maxMultiples = 1000 - userNumber;

            for (int i = 0; numberSum < maxMultiples; i++)
            {
                numberSum += userNumber;

                if (numberSum > 100)
                    numberMultiples++;
            }

            Console.WriteLine("N = " + userNumber);
            Console.WriteLine("Количество кратных чисел:" + numberMultiples);
            Console.WriteLine("Самое большое число:" + numberSum);
           
            Console.ReadKey();
        }
    }
}
