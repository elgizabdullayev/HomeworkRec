using System;

namespace HomeworkRecTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 4: Написать функцию, которая получает в качестве параметров 2 целых числа и возвращает сумму чисел из диапазона между ними. Рекурсия. 
            Console.WriteLine("Введите 2 целых числа, сумма диапазона чисел между которыми должна быть рассчитана.");
            int number1 = EnterNum();
            int number2 = EnterNum();
            int maxValue = MaxValue(number1, number2);
            int minValue = MinValue(number1, number2);
            int sum = CalculateSum(maxValue, minValue);
            Console.WriteLine($"Сумма диапазона чисел между {number1} и {number2} равно {sum}");
        }

        static int CalculateSum(int maxValue, int minValue)
        {
            if (maxValue == minValue)
            {
                return 0;
            }
            else 
            {
                return  minValue + CalculateSum(maxValue, minValue+1); 
            }
        }

        
        static int EnterNum()
        {
            int number;
            bool isRight = false;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                { 
                    if (number > 0)
                    {
                        isRight = true;
                    }
                    else
                    {
                        Console.WriteLine("Число меньше 0. Попробуйте другое число.");
                    }
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
        static int MaxValue(int number1,int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }

        }
        static int MinValue(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1+1;
            }
            else
            {
                return number2+1;
            }

        }
    }
}
