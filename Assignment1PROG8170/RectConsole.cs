using System;

namespace Assignment1PROG8170
{
    public class RectConsole
    {

        static void Main(string[] args)
        {
            int length, width;
            Rectangle rt = new Rectangle();
            Console.WriteLine("Enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width");
            width = Convert.ToInt32(Console.ReadLine());
            rt.SetLength(length);
            rt.SetWidth(width);

            Console.WriteLine("\nPerimeter of rectangle: " + rt.GetPerimeter());
            Console.WriteLine("\nArea of rectangle: " + rt.GetArea());
            Console.ReadKey();
        }
    }
}
