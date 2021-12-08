using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ввод Х и У
            while (true)
            {
                double x = 0;
                double y = 0;
                try
                {
                    Console.Write("Введите число: Х=\t");
                    x = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException) // если ввели не число
                {
                    Console.WriteLine("Вы ввели недопустимое значение. Нажмите любую клавишу для повторного ввода");
                    Console.ReadKey();
                    continue;
                }
                Console.Write("Введите число: Y=\t");
                try
                {
                    y = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException) // если ввели не число
                {
                    Console.WriteLine("Вы ввели недопустимое значение. Нажмите любую клавишу для повторного ввода");
                    Console.ReadKey();
                    continue;
                }
                //Выбор операции
                Console.Write("Выберите код операции:  1-сложение;  2-вычитание;  3-умножение;  4-деление:\t");
                int kod = Convert.ToInt32(Console.ReadLine());
                Calculate(x, y, kod);
                Console.WriteLine("Нажмите любую клавишу для повторного ввода");
                Console.ReadLine();
            }
        }
        static void Calculate(double x, double y, int kod)
        {
            double result;
            switch (kod)
            {
                case 1:
                    {
                        result = x + y;
                        Console.WriteLine("{0} + {1} = {2}", x, y, result);
                        break;
                    }

                case 2:
                    {
                        result = x - y;
                        Console.WriteLine("{0} - {1} = {2}", x, y, result);
                        break;
                    }

                case 3:
                    {
                        result = x * y;
                        Console.WriteLine("{0} * {1} = {2}", x, y, result);
                        break;
                    }

                case 4:
                    {
                        if (y == 0)
                        {
                            Console.WriteLine("Деление на ноль недопустимо!");
                        }
                        else
                        {
                            result = x / y;
                            Console.WriteLine("{0} / {1} = {2}", x, y, result);
                        }
                        break;
                                          
                    }
                default:
                    {
                        Console.WriteLine("Неизвестное действие. Нажмите любую клавишу для повторного ввода"); // сообщение при вводе непредусмотренного кода
                        break;
                    }
            }
        }
    }
}
