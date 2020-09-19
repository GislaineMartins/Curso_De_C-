using System;
using System.Collections.Generic;
using System.Text;

namespace Aula01.Entities {
    class CarRental {
        public DateTime start { get; set; }
        public DateTime finish { get; set; }

        public Vehicle Vehicle { get; set; }

        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle) {
            this.start = start;
            this.finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
