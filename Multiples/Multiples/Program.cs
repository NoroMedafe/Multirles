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
            int sumOfNumber;
            int maxMultiples;
            int minLimitRandomNumber = 1;
            int maxLimitRandomNumber = 27;
            int maxLimitMultiples = 1000;
            int minLimitMultiples = 100;

            Random randomNumber = new Random();

            userNumber = randomNumber.Next(minLimitRandomNumber, maxLimitRandomNumber + 1);
            maxMultiples = maxLimitMultiples - userNumber;

            for (sumOfNumber = 0; sumOfNumber < maxMultiples; sumOfNumber += userNumber)
            {
                if (sumOfNumber > minLimitMultiples)
                    numberMultiples++;
            }

            Console.WriteLine("N = " + userNumber);
            Console.WriteLine("Количество кратных чисел:" + numberMultiples);
            Console.WriteLine("Самое большое число:" + sumOfNumber);
           
            Console.ReadKey();
        }
    }
}
