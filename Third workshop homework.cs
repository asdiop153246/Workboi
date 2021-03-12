using System;

namespace อ้าาาาาา
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode;
            double x, y, p, t;
            Console.Write("Input the mode : ");
            mode = Console.ReadLine();
            Console.Write("Input x number : ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Input y number : ");
            y = double.Parse(Console.ReadLine());
            p  = Math.Pow(x - 1, 2);
            t = Math.Sqrt(y) + 1;

            if (mode == "time" || mode == "price")
            {
                if (x >= 0)
                {
                    if (mode == "time")
                    {
                        Console.WriteLine("{0}, {1}", x, p);
                    }
                    else if (mode == "price")
                    {
                        Console.WriteLine("{0}, {1}", t, y);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid mouse position");
                }
            }
            else
            {
                Console.WriteLine("Invalid Mode");
            }
                

            
        }
    }
}
