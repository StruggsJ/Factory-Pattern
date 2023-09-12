using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    static class BreverageFactory
    {
        public static IBeverage GetDrink(string drinkType)
        {
            switch (drinkType.ToLower())
            {
                case "tea":
                    return new Tea();
                case "coffee":
                    return new Coffee();
                default:
                    return new Tea();
            }
        }
    }
}
