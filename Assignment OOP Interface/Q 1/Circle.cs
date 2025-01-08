using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_OOP_Interface.Q_1
{
    internal class Circle : ICircle
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double Area => Math.PI * Radius * Radius; // Calculate the Area

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle Radius = {Radius } ,,,, Circle Area = {Area}");
        }
    }
}
