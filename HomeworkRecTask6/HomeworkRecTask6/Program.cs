using System;

namespace HomeworkRecTask6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание 6: Написать игру «Быки и коровы».
            Программа "загадывает" четырёхзначное число и играющий должен угадать его. 
            После ввода пользователем числа программа сообщает, сколько цифр числа угадано (быки) и сколько цифр угадано и стоит на нужном месте (коровы). 
            После отгадывания числа на экран необходимо вывести количество сделанных пользователем попыток. В программе необходимо использовать рекурсию.*/
            Console.WriteLine("Я загадал четырехзначное число. Попробуйте угадать его.");
            int secretNum = GenerateNum();
            Console.WriteLine(secretNum);
            bool gameEnd = false;
            int i = 0;
            do
            {
                int number = EnterNum();
                int steps = 0;
                char[] fromGame = ConvertToArray(secretNum);
                char[] fromPlayer = ConvertToArray(number);
                int cowPoints = CompareNumsCow(fromGame, fromPlayer,i) ;
                int bullPoints1 = CompareNumsBull1(fromGame, fromPlayer, i);
                int bullPoints2 = CompareNumsBull2(fromGame, fromPlayer, i);
                int bullPoints3 = CompareNumsBull3(fromGame, fromPlayer, i);
                int bullPoints4 = CompareNumsBull4(fromGame, fromPlayer, i);
                int bullPoints = bullPoints1 + bullPoints2 + bullPoints3 + bullPoints4;

                Console.WriteLine($"Вы сделали ход. Быков = {bullPoints} , Коров = {cowPoints}");
                
                if (cowPoints == 4)
                {
                    Console.WriteLine($"Поздравляю! Вы победили и угадали число {secretNum}. Количество попыток: {steps}");
                    gameEnd = true;
                }
            }
            while (gameEnd == false) ;


        }
        static char[] ConvertToArray(int num)
        {
            string toArray = Convert.ToString(num);
            char[] nums = toArray.ToCharArray();
            return nums;
        }
        static int EnterNum()
        {
            int number;
            bool isRight = false;
            do
            {
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (number >= 1000 && number < 10000)
                    {   
                        
                        isRight = true;
                    }
                    else
                    {
                        Console.WriteLine("Число не четырехзначное! Попробуйте снова.");
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
        static int GenerateNum()
        {
            Random rnd = new Random();
            int secretNum = rnd.Next(1000, 10000);
            return secretNum;
        }
        static int CompareNumsBull1(char[] fromGame, char[] fromPlayer, int i)
        {
            int point = 0;
            {
                if (fromGame[0] == fromPlayer[3])
                {
                    return point = 1;
                }
                else if (fromGame[0] != fromPlayer[i])
                {
                  return  point = 0;
                }

                else if (fromGame[0] == fromPlayer[i])
                {
                    return point = 1;
                }
                else
                {
                    return point + CompareNumsBull1(fromGame, fromPlayer, i + 1);
                }

            }
        }
        static int CompareNumsBull2(char[] fromGame, char[] fromPlayer, int i)
        {
            int point = 0;
            {
                if (fromGame[1] == fromPlayer[3])
                {
                    return point = 1;
                }
                else if (fromGame[1] != fromPlayer[i])
                {
                  return  point = 0;
                }
                else if (fromGame[1] == fromPlayer[i])
                {
                    return point = 1;
                }
                else
                {
                    return point + CompareNumsBull2(fromGame, fromPlayer, i + 1);
                }

            }
        }
        static int CompareNumsBull3(char[] fromGame, char[] fromPlayer, int i)
        {
            int point = 0;
            {
                if (fromGame[2] == fromPlayer[3])
                {
                    return point = 1;
                }
                else if (fromGame[2] != fromPlayer[i])
                {
                   return point = 0;
                }
                else if (fromGame[2] == fromPlayer[i])
                {
                    return point = 1;
                }
                else
                {
                    return point + CompareNumsBull3(fromGame, fromPlayer, i + 1);
                }
            }
        }
        static int CompareNumsBull4(char[] fromGame, char[] fromPlayer, int i)
        {
            int point = 0;
            {
                if (fromGame[3] == fromPlayer[3])
                {
                    return point = 1;
                }
                else if (fromGame[3] != fromPlayer[i])
                {
                  return  point = 0;
                }

                else if (fromGame[3] == fromPlayer[i])
                {
                    return point = 1;
                }
                else
                {
                    return point + CompareNumsBull4(fromGame, fromPlayer, i + 1);
                }
            }
        }
        static int CompareNumsCow(char[] fromGame, char[] fromPlayer, int i)
        {
            int point = 0;
            {
                do
                {
                    if (fromGame[0] == fromPlayer[0] && fromGame[1] == fromPlayer[1] && fromGame[2] == fromPlayer[2] && fromGame[3] == fromPlayer[3])
                    {
                        return point = 4;
                    }
                    else if (fromGame[i] == fromPlayer[i])
                    {

                        point += 1;
                        return point + CompareNumsCow(fromGame, fromPlayer, i + 1);

                    }
                    else
                    {
                        return point += 0;
                    }
                }
                while (point < 4);
            }
        }
    }
}
