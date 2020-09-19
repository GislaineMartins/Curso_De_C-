using Aula02.model.enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02.model.entities {
   abstract class AbstractShape : IShape{

        public Color Color { get; set; }

        public abstract double Area();
    }
}
