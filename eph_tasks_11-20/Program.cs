using System.ComponentModel.Design;

namespace eph_tasks_11_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double z = double.Parse(Console.ReadLine());
            //11
            if (Math.Pow(a, 2) + Math.Pow(a, 2) > 5)
            {
                Console.WriteLine((3 * Math.Exp(a - x)) + (Math.Log(3, (Math.Pow(a, 2) + Math.Pow(b, 2) + 5))));
            }
            else if(Math.Pow(a, 2) + Math.Pow(a, 2) < 1)
            {
                Console.WriteLine(Math.Pow(Math.Tan(a + b), 4));
            }
            else
            {
                Console.WriteLine(-3);
            }
            //12
            if (-5 <= x && x <= 5)
            {
                Console.WriteLine(Math.Pow((1 + Math.Pow(a, 2)), 6));
            } else if (x>5){
                Console.WriteLine(Math.Cos(Math.Log((Math.Abs(x) + Math.Pow(x, 8)))));
            }
            else
            {
                Console.WriteLine(a);
            }

            //13
            if (a + Math.Abs(b) < -5)
            {
                Console.WriteLine((Math.Exp(Math.Abs(a + x)) * Math.Pow(Math.Cos(a + x + b), 2)));
            } else if (a + Math.Abs(b) > 2)
            {
                Console.WriteLine(Math.Pow(Math.Atan(a + x), 1.0 / 3.0));
            }
            else
            {
                Console.WriteLine(a+Math.Abs(b));
            }

            //14
            if (a + b < 3)
            {
                Console.WriteLine(Math.Pow(Math.Atan(a + b), 4));
            }else if(a + b > 5)
            {
                Console.WriteLine(Math.Pow(Math.Log(8, a+b), 2));
            }
            else
            {
                Console.WriteLine(Math.Pow(a, 15));
            }

            //15
            if (-1 < c && c < 1)
            {
                Console.WriteLine(b + Math.Pow(Math.Tan(c + a), 5));
            } else if(c<=-1)
            {
                Console.WriteLine(Math.Cos(Math.Pow(Math.Log(Math.Abs(x)), 2) + Math.Pow(x, 8)));
            }
            else
            {
                Console.WriteLine(Math.Pow(a, -10));
            }

            //16
            if (Math.Abs(a) < 3)
            {
                Console.WriteLine((Math.Pow(Math.Sin(Math.Abs(x + a)), 2)) + Math.Pow(Math.Cos(Math.Pow(x, 2)), 2));
            }
            else
            {
                Console.WriteLine((Math.Pow(Math.Pow(a, 2) + Math.Pow(x, 2), 1.0 / 4.0)) * Math.Log2(Math.Pow(a, 2) + Math.Pow(x, 4)));
            }

            //17
            if(Math.Abs(a) > 3)
            {
                Console.WriteLine(Math.Pow(Math.Log2(4 + Math.Pow(a, 2)), 5) + (Math.Tan(z + a)));
            }
            else
            {
                Console.WriteLine(Math.Pow(Math.Pow(z,4) + 4*a, 5));
            }

            //18
            if(1<=x && x <= 7)
            {
                Console.WriteLine(Math.Pow((Math.Abs(x) + 2*Math.Abs(z)), 1.0 / 4.0) + Math.Exp(Math.Exp(Math.Abs(x+1))));
            }
            else
            {
                Console.WriteLine(Math.Pow(Math.Tan(Math.Pow(x + z, 7)), 2));
            }

            //19
            if (a + b < 7)
            {
                Console.WriteLine(1 / (Math.Pow(Math.Tan(Math.Pow(a, 2) + Math.Pow(b, 2) + c), 2)));
            }
            else
            {
                Console.WriteLine(Math.Pow(10, -7));
            }

            //20
            if (a > 3)
            {
                Console.WriteLine(Math.Exp(Math.Cos(x + a + b)) * Math.Tan(a + Math.Pow(b, 2)));
            }
            else
            {
                Console.WriteLine(Math.Log(3, 4 + Math.Pow(a, 2) + Math.Pow(b, 2)));
            }



            

        }
    }
}
