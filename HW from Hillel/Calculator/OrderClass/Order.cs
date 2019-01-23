using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderClass
{
    class Order
    {
        private long payerAccount;
        private long beneficiaryAccount;
        private double amount;


        
        public long PayerAccount
        {
            get
            {
                return payerAccount;
            }
        }

        public long BeneficiaryAccount
        {
            get
            {
                return beneficiaryAccount;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }
        }

        public Order(long payerAccount, long beneficiaryAccount, double amount)
        {
            this.payerAccount = payerAccount;
            this.beneficiaryAccount = beneficiaryAccount;
            this.amount = amount;
        }
    }
}
