using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    delegate string LocalName(ConcreteProduct product);
    delegate decimal LocalPrice(ConcreteProduct product);
    delegate string LocalDateTime(DateTime dateTime);

    class CountryInformation
    {
        private char _Currency;

        private LocalName _GetLocalName;
        private LocalPrice _GetLocalPrice;
        private LocalDateTime _GetLocalDateTime;

        public char Currency
        {
            get { return _Currency; }
        }

        public LocalName GetLocalName
        {
            get { return _GetLocalName; }
        }
        public LocalPrice GetLocalPrice
        {
            get { return _GetLocalPrice; }
        }
        public LocalDateTime GetLocalDateTime
        {
            get { return _GetLocalDateTime; }
        }


        public CountryInformation(char currency, LocalName getLocalName, LocalPrice getLocalPrice, LocalDateTime getLocalDateTime)
        {
            _Currency = currency;
            _GetLocalName = getLocalName;
            _GetLocalPrice = getLocalPrice;
            _GetLocalDateTime = getLocalDateTime;
        }
        
    }
}
