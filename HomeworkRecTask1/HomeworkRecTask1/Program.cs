using System;

namespace HomeworkRecTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 1: Найти сумму 22 + 23 + 24 + … +210.Операцию возведения в степень не использовать.
            int multiple = 10;
            int summ = MakeSum(multiple);
            Console.WriteLine($"Сумма 22 + 23 + 24 + … +210 равна {summ}");
            Console.ReadKey();
        }
        static int MakeSum(int multiple)
        {
            int x = 2;

            for (int i = 2; i <= multiple; i++)
            {
                x *= 2;
            }
            if ( multiple== 2 )
            {
                return 4;
            }
            else
            {
                return x + MakeSum(multiple - 1);
            }
        }
    }
}
