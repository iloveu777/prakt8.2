using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            void line()
            {
                Write('*');
            }
            for (int i = 0; i < 60;  i++)
            {
                line();
            }
            */
            //2
            /*
             void Main()
            {
                Write("Введите количество строк: ");
                if (int.TryParse(ReadLine(), out int numberOfLines) && numberOfLines >= 0)
                {
                    for (int i = 1; i <= numberOfLines; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Write("#");
                        }
                        WriteLine();
                    }
                }

            }
            Main();

            */
            //3 
            /*
            double Sqrt(double number)
            { 
            return Math.Sqrt(number);
            }
            double res()
            { 
            double result = ((Sqrt(5) + 5) /2 + (Sqrt(12) + 12) / 2 + (Sqrt(19) + 19) /2 );
            return result;
            }
            double x = res();
            WriteLine($"{x:f2}");
            */
            /*
            int FindMax(int x, int y)
            { 
            if (x > y)
                {
                    return x;
                }
                else
                {
                    return y;
                }

            }
            Write("введите а: ");
            int a = int.Parse(ReadLine());

            Write("введите b: ");
            int b = int.Parse(ReadLine());
            int max = FindMax(a, b);
            Write(max);
            */

            ReadKey();
            }
        }
    }
