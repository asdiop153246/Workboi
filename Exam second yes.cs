using System;

namespace Best
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            int x = a;
            int y = b;
            
            for (int i = 0; ; i++)
            {
                if (x == y) break;
                if (x < y)
                {
                    x += a;
                }
                else
                {
                    y += b;
                }
            }
            Console.WriteLine(x);
            
            
            






        }
    }
}
