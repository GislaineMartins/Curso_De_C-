using System;
using System.Collections.Generic;
using System.Text;

namespace Aula06.entities {
    struct Point {

        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) : this(){
            X = x;
            Y = y;
        }
    }
}
