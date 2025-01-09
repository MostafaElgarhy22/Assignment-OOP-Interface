using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_Interface.Q_1
{
    internal class Rectangle : IRectangle
    {
        public double Length { get; }
        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Area => Length * Width; // Calculate Area

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle Length = {Length}, Width = {Width}, Area = {Area}");
        }
    }
}
