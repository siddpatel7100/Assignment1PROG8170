using System;
using System.Collections.Generic;
using System.Text;

namespace Assig1TestProject
{
   
    public class TestCase
    {
        private int length=10, width=20;
        public int GetLength()
        {
            return length;
        }
        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }
        public int GetWidth()
        {
            return this.width;
        }
        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }
        public int GetPerimeter()
        {

            return (2 * (length + width));

        }
        public int GetArea()
        {
            int area = length * width;
            return area;
        }
    }
}
