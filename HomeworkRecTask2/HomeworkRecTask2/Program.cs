using System;

namespace HomeworkRecTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Задание 2: Написать рекурсивную функцию нахождения наибольшего общего делителя двух целых чисел.
            Console.WriteLine("Введите два числа.");
            int number1 = EnterNum();
            int number2 = EnterNum();
            int highNum = HighNum(number1, number2);
            int lowNum = LowNum(number1, number2);
            int divider = BigDivider(highNum, lowNum);
            Console.WriteLine($"Наибольший общий делитель чисел {highNum} и {lowNum} равен {divider}.");

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
        static int BigDivider(int highNum,int lowNum)
        {
            int nextNum = 0;
            if(highNum % lowNum == 0)
            {
                return lowNum ;
            }
            else
            {
                nextNum = highNum % lowNum;
                if (lowNum % nextNum == 0)
                {
                    return nextNum;
                }
                else
                {
                    return BigDivider(lowNum, nextNum);
                }
            }

        }
        static int HighNum (int number1, int number2)
        {
            if(number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
        static int LowNum(int number1, int number2)
        {
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
}
