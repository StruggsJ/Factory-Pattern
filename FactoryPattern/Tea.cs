using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    internal class Tea : IBeverage
    {
        public double Price { get; set; } = 2.18;
        public string Tempature { get; set; } = "cold";

        public void Drink()
        {
            Console.WriteLine($"Brewing a {Tempature} cup of tea. It will take about twenty minutes. Your total is ${Price}.");
        }
    }
}
