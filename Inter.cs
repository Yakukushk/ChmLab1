﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHMlab1
{
    class Inter
    {
        //  static double F(double x)
        //{
        //  return 3 * x * x - 20 * x + 44;
        //return (x * x + 4) / 5;
        //}


        static void Addlog(string str)
        {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\source\repos\CHMlab1\input.txt"))
            {
                sw.WriteLine(str);
            }
        }
        public static void Print_()
        {
            double x0 = 1.5,
               x1 = 2,
               x2 = 1,
               x3 = 1;
            const double x = 1;
            int interation = 0;
            Console.WriteLine($"xlast = {x0}");
            Console.WriteLine($"xto ={x1}");
            for (; ; )
            {
                
                interation++;
                Addlog(x.ToString());
                x1 = Math.Pow(x, 3) - 10 * x * x + 44 * x + 29;
                if (Math.Abs(x1 - x0) < 1e-4) break;
                x0 = x1;
            }for (; ; )
            {
                
                interation++;
                Addlog(x.ToString());
                x1 = Math.Pow(x, 3) - 10 * x * x + 44 * x + 29;
                if (Math.Abs(x1 - x0) < 0.01) break;
                x0 = x1;
            }
            static double f(double x) {
                double a = Math.Log10(Math.Sqrt(3) - 0.5) / (1 - 1 / 6544) * 1e-4;
                double b = Math.Log10(6544);
                return a / b + 1;
            }
            Console.WriteLine(" ");
            static double p(double x)
            {
                double a = 14 * 0.5;
                double b = 2 * 34.75;
                double f = a / b;
                return f;
            }
            static double g(double x) {
                double b = ((1 - 6544) / 6544) * 1e-4;
                double a = Math.Abs(Math.Pow(x, 3) - Math.Pow(x, 2)) * b;
                return a;
            }
            Console.WriteLine($"g = {g(x)}");
            
            Console.WriteLine($"p = {p(x)}");
            Console.WriteLine($"f = {f(x)}");
            double[,] myArr = new double[,] {
            {x, x1/1e-4, 1e-4 },
            {x,x1/1e-3, 1e-3 },
            {x, x1/1e-2, 1e-2}



            };
            double height = myArr.GetLength(0);
            double width = myArr.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.WriteLine(myArr[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Interation = {interation}");
            Console.WriteLine($"Mehod = {x1}");
        }
    }
}