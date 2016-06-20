using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
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
        protected Product product; 
        public override string ToString()
        {
            return product.ToString();
        }
    }
}
