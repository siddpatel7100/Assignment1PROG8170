using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1PROG8170
{
   public class Rectangle
    {
        private int length, width;
       public Rectangle()
        {
            length = 1;
            width = 1;
        }
        Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;

        }
        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            return this.length = length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int SetWidth(int width)
        {
            return this.width = width;
        }
        public int GetPerimeter()
        {

            return 2 * (length + width);

        }
        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
