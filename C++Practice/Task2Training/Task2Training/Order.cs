using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2Training
{
    class Order
    {
        private long payerAccount;
        private long beneficiaryAccount;
        private double amount;
        

        
        public long BeneficiaryAccount { get => beneficiaryAccount;  }
        public double Amount { get => amount; }
public long PayerAccount
        {
            get
            {
                return payerAccount;
            }

            set
            {
                payerAccount = value;
            }
        }

        public Order()
        {


        }
        public Order(long payerAccount,long beneficiaryAccount,double amount)
        {
            this.PayerAccount = payerAccount;
            this.beneficiaryAccount = beneficiaryAccount;
            this.amount = amount;
        }



    }
}
