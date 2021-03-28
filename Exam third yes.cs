using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int first, second, third, number, amount;
            int left1,left2,left3;
            string player1, player2;
            Console.Write("Input player 1 name : ");
            player1 = Console.ReadLine();
            Console.Write("Input player 2 name : ");
            player2 = Console.ReadLine();
            Console.Write("Input the amount for box 1 : ");
            first = int.Parse(Console.ReadLine());
            Console.Write("Input the amount for box 2 : ");
            second = int.Parse(Console.ReadLine());
            Console.Write("Input the amount for box 3 : ");
            third = int.Parse(Console.ReadLine());

            
            for (int i = 1; ;)
            {
                left1 = first;
                left2 = second;
                left3 = third;
                
                
                    if (i % 2 == 1)
                    {
                        Console.WriteLine("{0} turn",player1);
                        Console.Write("Choose box number : ");
                        number = int.Parse(Console.ReadLine());
                        Console.Write("Choose the amount you want to pick (Maximum is 2) ");
                        amount = int.Parse(Console.ReadLine());


                        if (amount < 3 && amount > 0)
                        {
                            if (number == 1)
                            {
                                first = first - amount;


                            }
                            else if (number == 2)
                            {
                                second = second - amount;


                            }
                            else if (number == 3)
                            {
                                third = third - amount;


                            }
                            else
                            {
                                Console.WriteLine("Wrong box");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong amount");
                        }
                        left1 = first;
                        left2 = second;
                        left3 = third;
                        if (left1 == 0 && left2 == 0 && left3 == 0)
                        {
                            Console.WriteLine("{0} win",player2);
                            break;
                        }
                        Console.WriteLine("{0},{1},{2}", left1, left2, left3);
                        i++;
                    }
                    else if (i % 2 == 0)
                    {
                        Console.WriteLine("{0} turn ",player2);
                        Console.Write("Choose box number : ");
                        number = int.Parse(Console.ReadLine());
                        Console.Write("Choose the amount you want to pick : ");
                        amount = int.Parse(Console.ReadLine());

                        if (amount < 3 && amount > 0)
                        {
                            if (number == 1)
                            {
                                first = first - amount;



                            }
                            else if (number == 2)
                            {
                                second = second - amount;


                            }
                            else if (number == 3)
                            {
                                third = third - amount;


                            }
                            else
                            {
                                Console.WriteLine("Wrong box");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong amount");
                        }
                        left1 = first;
                        left2 = second;
                        left3 = third;
                        if (left1 == 0 && left2 == 0 && left3 == 0)
                        {
                            Console.WriteLine("{0} win",player1);
                            break;
                        }
                        Console.WriteLine("{0},{1},{2}", left1, left2, left3);
                        i++;
                    }
                }             
            }
        }
    }

