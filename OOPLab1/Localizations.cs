﻿using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class UALocalization : Localization
    { 
        override public string LocalName(Product product)
        {
            return product.NameUA;
        }
        override public string LocalPrice(decimal price)
        {
            return price * 24.8948194M + "₴";
        }
        override public string LocalDateTime()
        {
            return BuyTime.ToString("dd/MM/yyyy H:mm:ss");
        }
    }

    class RULocalization : Localization
    {
        override public string LocalName(Product product)
        {
            return product.NameRU;
        }
        override public string LocalPrice(decimal price)
        {
            return price * 64.0532923M + "₽";
        }
        override public string LocalDateTime()
        {
            return BuyTime.ToString("dd/MM/yyyy H:mm:ss");
        }
    }

    class USLocalization : Localization
    { 
        override public string LocalName(Product product)
        {
            return product.NameUS;
        }
        override public string LocalPrice(decimal price)
        {
            return price + "$";
        }
        override public string LocalDateTime()
        {
            return BuyTime.ToString("MM/dd/yyyy H:mm:ss");
        }
    }
}
