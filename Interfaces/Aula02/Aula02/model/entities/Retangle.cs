﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Aula02.model.entities {
    class Retangle : AbstractShape {

        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area() {
            return Width * Height;
        }

        public override string ToString() {
            return "Retangle color = "
                + Color
                + ", width = "
                + Width.ToString("F2", CultureInfo.InvariantCulture)
                + ", height = "
                + Height.ToString("F2", CultureInfo.InvariantCulture)
                + ", are = "
                + Area().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
