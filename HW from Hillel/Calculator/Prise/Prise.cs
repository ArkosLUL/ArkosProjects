using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceClass
{
    class Price
    {
        private string productName;
        private string shopName;
        private double productPrice;

        public string ProductName
        {
            get
            {
                return productName;
            }
        }

        public string ShopName
        {
            get
            {
                return shopName;
            }
        }

        public double ProductPrice
        {
            get
            {
                return productPrice;
            }
        }

        public Price(string productName, string shopName, double productPrise)
        {
            this.productName = productName;
            this.shopName = shopName;
            this.productPrice = productPrise;
        }
    }
}
