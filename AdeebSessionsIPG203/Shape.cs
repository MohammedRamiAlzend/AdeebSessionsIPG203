using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdeebSessionsIPG203
{
    internal class Shape
    {
        private int radius;
        private const float pi = 3.14f;
        private int width;
        private int height;
        public Shape(int radius)
        {
            this.radius = radius;
        }
        public Shape(int width, int height) : this(-10)
        {
            this.width = width;
            this.height = height;
        }

        public double Area()
        {
            if(radius == -1)
            {
                return width * height;
            }
            else
            {
                return pi * Math.Pow(radius, 2);
            }
        }



    }
}
