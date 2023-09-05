using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minNumber = 2;
            int maxNumber = 31;
            int multiplier = 2;
            int temporaryResult = 2;
            int result = 0;
            int degree = 1;
            Random random = new Random();
            int value = random.Next(minNumber, maxNumber);
            Console.WriteLine($"Случайное число: {value}");

            while (result < value)
            {
                result = multiplier * temporaryResult;
                temporaryResult = result;
                degree++;
            }

            Console.WriteLine($"Конечное число: {result}");
            Console.WriteLine($"Для числа {value} минимальная степень двойки, превосходящее число {result}, равно {degree}");
        }
    }
}
