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
            
            Console.WriteLine("Введите число");
            userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber >=1 && userNumber <=27)
            {

                while (numberSum < 1000 - userNumber)
                {
                    numberSum += userNumber;
                    if (numberSum > 100)
                        numberMultiples++;

                }

                Console.WriteLine("Количество кратных чисел:" + numberMultiples);
                Console.WriteLine("Самое большое число:" + numberSum);
            }
            else
            {
                Console.WriteLine("Введите нормальное число");
            }

            Console.ReadKey();
        }
    }
}
