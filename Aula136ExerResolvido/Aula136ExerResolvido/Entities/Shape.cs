using System;
using System.Collections.Generic;
using System.Text;
using Aula136ExerResolvido.Entities.Enums;

namespace Aula136ExerResolvido {
    abstract class Shape {
        public Color Color { get; set; }

       

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();


    }
}
