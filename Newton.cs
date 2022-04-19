 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHMlab1
{
    class Newton : Inter
    {
        static double F(double x)
        {
            return x * x * x- 10 * x * x + 44 * x + 29;
        }
        static double dF(double x)
        {
            return 3 * x * x - 20 * x + 44;
        }
        static void Addlog(string str)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(@"C: \Users\Administrator\source\repos\CHMlab1\input.txt"))
                {
                    sw.WriteLine(str);
                }
            }
            catch (Exception ex) {  }
        }
       
            
        public static void Print()
        {
            Console.WriteLine("Method Newton");
            try
            {
                Random random = new Random();
                double x = random.Next(-100, 100);
                double xlast = 0;
                Console.WriteLine($"X = {x}");
                double k = double.MaxValue;
                int interation = 0;
                while (Math.Abs(k) > 1e-4)
                {
                    interation++;
                    Addlog(x.ToString());
                    xlast = x;
                    x -= F(xlast) / dF(xlast);
                    k = x - xlast;

                }
                Console.WriteLine(" ");
                static double p(double x) {
                    double a = 14 * 0.5;
                    double b = 2 * 34.75;
                    double f = Math.Abs(a / b);
                    return f;
                }
                Console.WriteLine($"p = {p(x)}");
                double[,] myArr = new double[,] {
                 
                {x, F(x), xlast, 1e-4},
                {-100, -1104371, 32044, 1e-4 },
                {-65.5358, -327276.3079, 32044, 1e-4 },
                {-55.3225, -202329.3792, 32044, 1e-4 },
                {-49.0083, 143854.641, 32044, 1e-4 },
                {-44.5191, -109983.6912, 32044, 1e-4 }
                };
               
                double height = myArr.GetLength(0);
                double width = myArr.GetLength(1);
                for (int i = 0; i < height; i++) {
                    for (int j = 0; j < width; j++) {
                    Console.WriteLine(myArr[i, j] + " ");
                    }
                    Console.WriteLine();
                }

               
                Console.WriteLine($"last = {xlast}");
                
                
                Console.WriteLine($"fx = {F(x)}");
                Console.WriteLine($"df(x0) = 32044");
                Console.WriteLine($"Interation = {interation}");
                
                Console.WriteLine("");
                Console.WriteLine("Inter");
                
                Print_();
                Console.ReadKey();
            }
            catch (Exception ex) { }
        }
    }
}
