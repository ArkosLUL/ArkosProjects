using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceClass
{
    class Prices
    {
        List<Price> prices;
        List<Price> temp;

        public Prices()
        {
            prices = new List<Price>();
            temp = new List<Price>();
        }

        /// <summary>
        /// Вывод информации о товаре на консоль
        /// </summary>
        /// <param name="price">Товар</param>
        private void Show(Price price)
        {
            Console.WriteLine($"{price.ProductName}-->{price.ShopName}-->{price.ProductPrice}");
        }

        /// <summary>
        /// Добавление товара в список от пользователя
        /// </summary>
        /// <param name="price">Товар</param>
        public void InputUserData(Price price)
        {
            prices.Add(price);
        }

        /// <summary>
        /// Вывод на консоль информации обо всех товарах в списке
        /// </summary>
        public void Print()
        {
            foreach (var price in prices)
            {
                Show(price);
            }
        }

        /// <summary>
        /// Вывод на консоль отсортированный список товаров по имени в алфавитном порядке
        /// </summary>
        /// <param name="isSorted">Сортировать?</param>
        public void Print(bool isSorted)
        {
            if(isSorted)
            {
                temp = prices.OrderBy(x => x.ProductName).ToList();
                foreach (var price in temp)
                {
                    Show(price);
                }
            }
        }

        /// <summary>
        /// Вывод информации о товарах с указанным пользователем названием
        /// </summary>
        /// <param name="productName">Название товара</param>
        public void Print(string productName)
        {
            foreach (var price in prices)
            {
                if(price.ProductName == productName)
                {
                    Show(price);
                }
            }
        }
    }
    }

