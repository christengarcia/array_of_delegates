/*
 * C# Program to Illustrate Array of Delegates
 */

using System;
delegate double Measure(double R);
namespace array_of_delegates
{
    class Circle
    {
        const double PI = 3.14159;
        public double Diameter(double Radius)
        {
            return Radius * 2;
        }


    }
}
