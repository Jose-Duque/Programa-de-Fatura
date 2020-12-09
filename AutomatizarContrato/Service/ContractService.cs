using System;
using System.Collections.Generic;
using System.Text;
using AutomatizarContrato.Entities;

namespace AutomatizarContrato.Service {
    class ContractService {
        public void ProcessContract(Contract contract, int months) {
            
            PaypalService paypal = new PaypalService();
           
            
            double amount = contract.TotalValue / months;
            
            
            for (int i = 1; i <= months; i++) {
              
                
                DateTime date = contract.Date.AddMonths(i);
                
                double tax = amount + paypal.Interest(amount, i);

                double tax2 = paypal.PaymentFee(tax);

                contract.AddInstallment(new Installment(date, tax2));
            }

        }
    }
}
