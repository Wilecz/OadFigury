using System;
using System.Collections.Generic;
using System.Text;

namespace OadFigury
{
    public class Drawing : Figure
    {
        private readonly List<Figure> figury = new();
        public void Adder(Figure f) => figury.Add(f);
        public double SumArea()
        {
        }
        public Figure? Highest()
        {
        }

    }
}
