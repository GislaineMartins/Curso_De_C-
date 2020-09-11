using Aula115Enumeracao.Entities;
using Aula115Enumeracao.Entities.Enums;
using System;

namespace Aula115Enumeracao {
    class Program {
        static void Main(string[] args) {
            Order order = new Order {
                Id = 0,
                Moment = DateTime.Now,
                Status = OrderStatus.PedingPayment
            };

            Console.WriteLine(order);
            string txt = OrderStatus.PedingPayment.ToString();
            Console.WriteLine(txt);
        }
    }
}
