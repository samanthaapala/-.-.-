using System;

namespace Математический.тренажер.рандом
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne, numberTwo, operaiton;
            double input;
            
            while (true)
            {
              

              
              Random random = new Random();
              numberOne = random.Next(0, 11);
                Console.WriteLine("Число 1: " + numberOne);
              numberTwo = random.Next(0, 11);
                Console.WriteLine("Число 2: " + numberTwo);
              operaiton = random.Next(0, 4);
              switch (operaiton)
                {
                    case 0:
                        Console.WriteLine("Введите результат сложения ", numberTwo + " " + numberTwo);
                        input = Convert.ToDouble(Console.ReadLine());
                        numberOne += numberTwo;
                        if (input == numberOne) {
                            Console.WriteLine("Правильно");


                        }
                        else
                        {
                            Console.WriteLine("Неправильно");
                        }
                        break;
                    case 1:
                        Console.WriteLine("Введите результат вычитания ", numberTwo + " " + numberTwo);
                        input = Convert.ToDouble(Console.ReadLine());
                        numberOne -= numberTwo;
                        if (input == numberOne)
                        {
                            Console.WriteLine("Правильно");


                        }
                        else
                        {
                            Console.WriteLine("Неправильно");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Введите результат умножения ", numberTwo + " " + numberTwo);
                        input = Convert.ToDouble(Console.ReadLine());
                        numberOne *= numberTwo;
                        if (input == numberOne)
                        {
                            Console.WriteLine("Правильно");


                        }
                        else
                        {
                            Console.WriteLine("Неправильно");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Введите результат деления ", numberTwo + " " + numberTwo);
                        input = Convert.ToDouble(Console.ReadLine());
                        numberOne /= numberTwo;
                        if (input == numberOne)
                        {
                            Console.WriteLine("Правильно");


                        }
                        else
                        {
                            Console.WriteLine("Неправильно");
                        }
                        break;
                    default:
                        Console.WriteLine("Операция не найдена ");
                        break;









                }



            }


        }
    }
}
