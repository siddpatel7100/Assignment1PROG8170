using System;

namespace Assignment1PROG8170
{
    public class RectConsole
    {

        static void Main(string[] args)
        {
            Rectangle rt = new Rectangle();
            int getNum = 0;
            int length, width;
            Console.Write("Enter Length: ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter Width: ");
            width = Convert.ToInt32(Console.ReadLine());
            rt = new Rectangle(length, width);
            if (width > 0 && length > 0)
            { 
                while (getNum != 7)
                {

                    Console.WriteLine("1. Get Rectangle Length ");
                    Console.WriteLine("\n2. Change Rectangle Length ");
                    Console.WriteLine("\n3. Get Rectangle Width  ");
                    Console.WriteLine("\n4. Change Rectangle Width  ");
                    Console.WriteLine("\n5. Get Rectangle Perimeter  ");
                    Console.WriteLine("\n6. Get Rectangle Area  ");
                    Console.WriteLine("\n7. Exit   ");
                    Console.WriteLine("\nEnter a number to perform operation");
                    getNum = Convert.ToInt32(Console.ReadLine());
                    int result = 0;
                    switch (getNum)
                    {
                        case 1:
                            {
                                result = rt.GetLength();
                                Console.WriteLine("The result is {0}\n", result);
                                break;
                            }
                        case 2:
                            {
                                Console.WriteLine("Enter length");
                                length = Convert.ToInt32(Console.ReadLine());
                                if (length > 0)
                                {
                                    Console.WriteLine("New Length:" + " " + rt.SetLength(length));
                                }
                                else
                                {
                                    Console.WriteLine("Value Should not be less than 1");
                                    Console.WriteLine("Enter The Correct Value Again\n");
                                }
                                    break;
                            }
                        case 3:
                            {
                                result = rt.GetWidth();
                                Console.WriteLine("The result is {0}\n", result);
                                break;
                            }
                        case 4:
                            {
                                Console.WriteLine("Enter Width");
                                width = Convert.ToInt32(Console.ReadLine());
                                if (width > 0) {
                                    Console.WriteLine("New Width:" + " " + rt.SetWidth(width));
                                }
                                else
                                {
                                    Console.WriteLine("Value Should not be less than 1");
                                    Console.WriteLine("Enter The Correct Value Again\n");
                                }
                                break;
                            }
                        case 5:
                            {
                                result = rt.GetPerimeter();
                                Console.WriteLine("The result is {0}\n", result);
                                break;
                            }
                        case 6:
                            {
                                result = rt.GetArea();
                                Console.WriteLine("The result is {0}\n", result);
                                break;
                            }
                        case 7:
                            {
                                Environment.Exit(-1);
                                break;
                            }
                        default:
                            Console.WriteLine("Wrong action!! try again");
                            break;
                    }

                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("Value Should not be less than 1");
                Console.WriteLine("Enter The Correct Value Again\n");
            }
        }
    }
}
