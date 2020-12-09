using System;
using System.Collections.Generic;
using System.Text;
using AutomatizarContrato.Entities;

namespace AutomatizarContrato.Service {
    class PaypalService {
        public double Interest(double amount, int months) {

            return amount * months / 100;
        }

        public double PaymentFee(double amount) {
            double tax = amount * 0.02;
            return amount + tax;
        }

    }
}
