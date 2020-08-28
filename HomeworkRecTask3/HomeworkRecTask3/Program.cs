using System;

namespace HomeworkRecTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 3: Написать рекурсивную функцию нахождения степени числа.
            Console.WriteLine("Введите число и степень, в которую его нужно возвести.");
            int number = EnterNum();
            int power = EnterNum();
            int numInPow = FindPower(number, power);
            Console.WriteLine($"Число {number}, возведенное в {power} степень, равно {numInPow}.");
            Console.ReadKey();
        }
        static int EnterNum()
        {
            bool isRight = false;
            int number;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    isRight = true;
                }
                else
                {
                    Console.WriteLine("Введено неверное значение!");
                    Console.WriteLine("Введите еще раз.");
                    isRight = false;
                }
            }
            while (isRight == false);
            return number;
        }
        static int FindPower(int number, int power)
        {
            if (power == 0)
            {
                return 1;
            }
            else
            {
               return number *= FindPower(number, power - 1);
            }
        }
    }
}
