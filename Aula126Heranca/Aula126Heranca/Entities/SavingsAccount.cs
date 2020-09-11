using System;
using System.Collections.Generic;
using System.Text;

namespace Aula126Heranca.Entities {
    class SavingsAccount : Account {
        
        public double InteresRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interesRate) :base(number, holder, balance) {
            InteresRate = interesRate;
        }
        public void UpdateBalance() {
            Balance += Balance * InteresRate;

        }


    }
}
