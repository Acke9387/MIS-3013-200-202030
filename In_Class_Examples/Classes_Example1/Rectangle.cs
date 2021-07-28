using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example1
{
    public class Rectangle
    {
        public double Length { get; set; }

        public double Width { get; set; }

        //private double _Width;
        //public double GetWidth()
        //{
        //    return _Width;
        //}
        //public void SetWidth(double w)
        //{
        //    _Width = w;
        //}

        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Rectangle()
        {
            Length = 0;
            Width = 0;
        }

        /// <summary>
        /// Calculates the Area of THIS Rectangle
        /// </summary>
        /// <returns>The area of THIS rectangle</returns>
        public double CalculateArea()
        {
            double area;

            area = Length * Width;

            return area;
        }

        /// <summary>
        /// Calculates the Perimeter of THIS rectangle
        /// </summary>
        /// <returns>The perimeter of THIS rectangle</returns>
        public double CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
        
    }
}
