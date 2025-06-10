using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeebSessionsIPG203
{
    internal class Rectangle
    {
        public static int myint = 10;
        int length;
        int width;
        public int Length
        {
            get { return length; }
            set
            {
                if (value < 0)
                    length = 0;
                else
                    length = value;
            }
        }
        public int Width
        {
            get { return width; }
            set { width = value < 0 ? 0 : value; }
        }
        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int Area()
        {
            return (length + width) * 2;
        }
        public int Perimeter()
        {
            return (length * width);
        }
    }
}
