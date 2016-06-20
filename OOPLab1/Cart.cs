using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLab1
{
    class Cart
    {
        private Queue<Product> Check = new Queue<Product>();
        public Localization localization { set; get; }

        public void AddToCart(Product product)
        {
            Check.Enqueue(product);
        }

        public string Buy()
        {
            StringBuilder check = new StringBuilder();
            while (Check.Count != 0)
            {
                Product product = Check.Dequeue();
                product.localization = localization;
                check.Append(product.ToString());
            }
            return check.ToString();
        }
    }
}
