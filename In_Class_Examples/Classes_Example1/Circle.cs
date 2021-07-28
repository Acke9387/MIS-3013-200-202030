using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Example1
{
    public class Circle
    {
        public double Radius { get; set; }


        /// <summary>
        /// Default/Empty Constructor
        /// </summary>
        public Circle()
        {
            Radius = 0;
        }

        /// <summary>
        /// Calculates the Area of THIS circle
        /// </summary>
        /// <returns>The area of THIS circle</returns>
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Calculates the perimeter of THIS circle
        /// </summary>
        /// <returns>The perimeter of THIS circle</returns>
        public double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }
}
