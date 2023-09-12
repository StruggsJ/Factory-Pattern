using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal interface IBeverage
    {
        public double Price { get; set; }
        public string Tempature { get; set; }

        public void Drink();
    }
}
