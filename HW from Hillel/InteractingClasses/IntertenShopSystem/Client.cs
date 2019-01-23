using System;
using System.Collections.Generic;
using System.Text;

namespace WebShopSystem
{
    class Client
    {
        readonly string name;
        double balance;
        bool blackListMember;

        public double Balance { get => balance; set => balance = value; }
        public bool BlackListMember { get => blackListMember; set => blackListMember = value; }

        public Client(string name, double balance)
        {
            this.name = name;
            Balance = balance;
            BlackListMember = false;
        }

        public override string ToString()
        {
            return string.Format($"{name}, {Balance}, {BlackListMember}");
        }
    }
}
