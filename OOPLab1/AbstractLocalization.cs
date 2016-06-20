using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    abstract class Localization
    { 
        public DateTime BuyTime { get; }
        abstract public string LocalName(Product product);
        abstract public string LocalPrice(decimal product);
        abstract public string LocalDateTime();

        public Localization()
        {
            BuyTime = DateTime.Now;
        }
    }
}
