﻿using Exercicio16.Entities.Enums;

namespace Exercicio16.Entities

{
    abstract internal class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
