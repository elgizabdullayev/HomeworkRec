using System;

namespace HomeworkRecTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задание 5: Написать программу, которая выдает день недели на английском языке по номеру дня недели.
            Console.WriteLine("Введите номер дня недели.");
            int number = EnterNum();
            Console.WriteLine($"День номер {number} на английском языке: {SwitchDay(number)}");
        }
        enum Days
        {
            Monday = 1,

            Tuesday,

            Wednesday,

            Thursday,

            Friday,

            Saturday,

            Sunday
        }
        static int EnterNum()
        {
            int number;
            bool isRight = false;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= 1 && number <= 7)
                    {
                        isRight = true;
                    }
                    else
                    {
                        Console.WriteLine("В неделе семь дней.");
                        Console.WriteLine("Введите число от 1 до 7.");
                        isRight = false;
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
        static string SwitchDay(int number)
        {
            string day;
            switch (number)
            {
                case 1:
                    return day=Convert.ToString(Days.Monday);
                case 2:
                    return day=Convert.ToString(Days.Tuesday);
                case 3:
                    return day=Convert.ToString(Days.Wednesday);
                case 4:
                    return day=Convert.ToString(Days.Thursday);
                case 5:
                    return day=Convert.ToString(Days.Friday);
                case 6:
                    return day=Convert.ToString(Days.Saturday);
                case 7:
                    return day=Convert.ToString(Days.Sunday);
            }
            return day = "Nothing";
        }
    } 
}
