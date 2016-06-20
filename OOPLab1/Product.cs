using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Product
    {      
        Localization localization { get; set; }

        public decimal Price { get; }
        public string NameUA { get; }
        public string NameRU { get; }
        public string NameUS { get; }

        public Product(decimal price, string nameUA, string nameRU, string nameUS)
        {
            Price = price;
            NameUA = nameUA; 
            NameRU = nameRU;
            NameUS = nameUS;
        }

        public override string ToString()
        {
            return localization.LocalDateTime() + "\n" + localization.LocalName(this) + "\t" + localization.LocalPrice(price);
        }
    }
}
