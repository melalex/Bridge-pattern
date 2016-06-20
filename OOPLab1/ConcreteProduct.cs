using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class ConcreteProduct
    {
        private int _id;
        int id { get { return _id; } }
        decimal price { get; set; }
        string nameUA { get; set; }
        string nameRU { get; set; }
        string nameEN { get; set; }

        ConcreteProduct(int id, string nameUA, string nameRU, string nameEN)
        {
            _id = id;
            this.nameUA = nameUA;
            this.nameRU = nameRU;
            this.nameEN = nameEN;
        }
    }
}
