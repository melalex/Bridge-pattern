using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class CountryDecorator : Decorator
    {
        private CountryInformation Information;
        private DateTime BuyTime;

        public CountryDecorator(Product product, CountryInformation information) : base(product)
        { 
            Information = information;
            BuyTime = DateTime.Now;
        }

        public override string ToString()
        {
            return Information.GetLocalDateTime(BuyTime) + "/n" + Information.GetLocalName(DecoratedProduct);
        }
    }
}
