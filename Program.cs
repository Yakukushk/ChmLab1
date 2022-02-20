using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CHMlab1 {
    class Program : Newton{
        

        static double F(double x) {
            return x * x * x - 10 * x * x + 44*x + 29;
        }
        static void Addlog(string str) {
            using (StreamWriter sw = new StreamWriter(@"C:\Users\Administrator\source\repos\CHMlab1\input.txt")) {
                sw.WriteLine(str);
            }
        }

        static void Main(string[] args) {
            Console.WriteLine("Dichotomy Method");
            Random random = new Random();
            double x = 0;
            double xlast = 2;
            double xto = 50;
            Console.WriteLine($"X0 = {x}");
            double b = double.MaxValue;
            int interation = 0;
            while (Math.Pow(b, 2) > 1e-4) {
                interation++;
                Addlog(x.ToString());
                x = (xto + xlast) / 2;
                if (F(xto) * F(x) < 0)
                {
                    xlast = x;
                }
                else if (F(xto) * F(x) == 0)
                {
                    break;
                }
                else {
                    xto = x;
                }
                b = xto - xlast;
            }
            
            Console.WriteLine($"min = {xlast}");
           // Console.WriteLine($"max = {xto}");
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"F(x) = {F(x)}");
            Console.WriteLine($"Interation = {interation}");
            Console.WriteLine("");
            Newton newton = new Newton();
            Inter inter = new Inter();
            Print();
            Console.WriteLine("");
            
            
            Console.ReadKey();


            
        }
    }
}
    