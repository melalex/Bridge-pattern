using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Product
    {
        public override string ToString()
        {
            return base.ToString();
        }
    }

    abstract class Decorator : Product
    {
        protected Product DecoratedProduct;

        public Decorator(Product product)
        {
            DecoratedProduct = product;
        } 

        public override string ToString()
        {
            return DecoratedProduct.ToString();
        }
    }
}
