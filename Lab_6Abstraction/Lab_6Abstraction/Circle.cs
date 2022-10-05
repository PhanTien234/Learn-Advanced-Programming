﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_6Abstraction
{
    internal class Circle : IDrawable
    {
        private double radius;
        public double Radius { get { return radius; } set { radius = value; } }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public void Draw()
        {
            double rIn = this.radius - 0.4;
            double rOut = this.radius + 0.4;
            for(double y = this.radius; y >= -this.radius; y--)
            {
                for(double x = -this.Radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
