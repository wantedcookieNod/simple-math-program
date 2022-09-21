using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPME1
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, d, e, f, g, h, i, j, l, o;
            int k;
            string x;
            Console.WriteLine("Hello");
            Console.WriteLine("");
            start:
            Console.WriteLine("Please get me 10 number");

            Console.Write("");
            Console.Write("1.  ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("2.  ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("3.  ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("4.  ");
            d = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("5.  ");
            e = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("6.  ");
            f = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("7.  ");
            g = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("8.  ");
            h = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("9.  ");
            i = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            Console.Write("10.  ");
            j = Convert.ToDouble(Console.ReadLine());
            Console.Write("");
            
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("* * * * * * * * * * * * * * * * *");
            Console.WriteLine("*   1.Sum                       *");
            Console.WriteLine("*   2.Minus                     *");
            Console.WriteLine("*   3.Multiply                  *");
            Console.WriteLine("*   4.Divide                    *");
            Console.WriteLine("*   5.Average                   *");
            Console.WriteLine("*   6.Reverse                   *");
            Console.WriteLine("* * * * * * * * * * * * * * * * *");
            
            k = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Result:");
            Console.WriteLine("");
            switch (k)
            {
                case 1:
                    {
                        l = a + b + c + d + e + f + g + h + i + j;
                        Console.WriteLine(l);
                        break;
                    }
                case 2:
                    {
                        l = a - b - c - d - e - f - g - h - i - j;
                        Console.WriteLine(l);
                        break;
                    }
                case 3:
                    {

                        l = a * b * c * d * e * f * g * h * i * j;
                        Console.WriteLine(l);
                        break;
                    }
                case 4:
                    {
                        l = a / b / c / d / e / f / g / h / i / j;
                        Console.WriteLine(l);
                        break;
                    }
                case 5:
                    {
                        o = a + b + c + d + e + f + g + h + i + j;
                        l = o / 10;
                        Console.WriteLine(l);
                        break;
                    }
                case 6:
                    {
                        Console.Write(j + "/");
                        Console.Write(i + "/");
                        Console.Write(h + "/");
                        Console.Write(g + "/");
                        Console.Write(f + "/");
                        Console.Write(e + "/");
                        Console.Write(d + "/");
                        Console.Write(c + "/");
                        Console.Write(b + "/");
                        Console.WriteLine(a);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This number is out of range");
                        break;
                    }
            }
            Console.WriteLine("Would you like to try again?");
            Console.WriteLine("You can type 'y' for Yes OR you can type 'n' for No");
            x = Console.ReadLine();
            if (x == "y")
                goto start;
            else
                Console.WriteLine("Thank you for using this program");
        }
    }
}
