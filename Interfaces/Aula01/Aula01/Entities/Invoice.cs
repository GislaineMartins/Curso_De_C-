using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Aula01.Entities {
    class Invoice {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax) {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TatalPayment {
            get { return BasicPayment + Tax; }
        }

        public override string ToString() {
            return "BasicPayment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TatalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
