using System;

namespace เสาร์นี้เหงาดีนะ
{
    class Program
    {
        static void Main(string[] args)
        {
            //พงศกร พิศนาคะ 63120501030
            double number;
            string letter;
            double C1, C2, C3, t, y,f, g, p; 
            bool CIA, NSA, FBI;
            
            Console.Write("Insert your agency name : ");
            letter = Console.ReadLine();
            Console.Write("Insert your ID : ");
            number = double.Parse(Console.ReadLine());

            if (number < 1000000)
            {


                if (letter == "CIA")
                {
                    C1 = number % 10 % 3;
                    C2 = number % 100 / 10;
                    C3 = number % 10000 / 1000;

                    CIA = (C1 == 0) && ((C2 != 1) && (C2 != 3) && (C2 != 5)) && (C3 > 6 && C3 != 8);
                    Console.WriteLine(CIA);
                }

                else if (letter == "FBI")
                {
                    C1 = number % 1000000 / 100000;
                    C2 = number % 1000 / 100;
                    C3 = number % 100000 / 10000;

                    FBI = (C1 >= 4 && C1 <= 7) && (C2 % 2 == 0 && C2 != 6) && (C3 == 1 || C3 % 3 == 0);
                    Console.WriteLine(FBI);
                }
                else if (letter == "NSA")
                {

                    C1 = number % 10;
                    C2 = number % 1000 / 100;
                    
                    t = number % 100 / 10;
                    y = number % 1000 / 100;
                    f = number % 10000 / 1000;
                    g = number % 100000 / 10000;
                    p = number % 1000000 / 100000;

                    NSA = (30 % C1 == 0) && ((C2 % 3 == 0)&&(C2 % 2 != 0)) && ((C1 == 7) || (t == 7) || (y == 7) || (f == 7) || (g == 7) || (p == 7));
                    Console.WriteLine(NSA);
                }
                
                else
                {
                    Console.WriteLine("Error");
                }
                
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}


//&& ((C1 == 3) || (C1 == 6) || (C1 == 9)) && ((C2 != 1) || (C2 != 3) || (C2 != 5) && (C3 > 6) && (C3 != 8)))


//if  (C3 > 6 && C3 != 8)
//{
//    if ((C2 !=1)&&(C2 != 3)&&(C2 != 5))
//    {
//        if (C1 % 3 == 0)
//        {
//            Console.WriteLine("You're CIA");
//        }
//        else
//        {
//            Console.WriteLine("Error");
//        }




//    }
//    else
//    {
//        Console.WriteLine("Error");
//    }
//}
//else
//{
//    Console.WriteLine("Error");
//}