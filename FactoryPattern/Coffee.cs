using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Coffee : IBeverage
    {
        public double Price { get; set; } = 1.89;
        public string Tempature { get; set; } = "hot";

        public void Drink()
        {
            var userChoice = "";
           

            Console.WriteLine($"Would you like a cup of cold brew or an espresso?");
            userChoice = Console.ReadLine();

            switch (userChoice.ToLower())
            {
                case "cold brew":

                    Tempature = "cold";
                    Console.WriteLine($"Brewing a {Tempature} cup of cold brew coffee. It will take about five minutes. Your total is ${Price}.");
                    break;
                case "espresso":
                    Console.WriteLine($"Brewing a {Tempature} cup of espresso. It will take about ten minutes. Your total is ${Price}.");
                    break;
                default:
                    Console.WriteLine($"Brewing a {Tempature} cup of coffee. It will take about twenty minutes. Your total is ${Price}.");
                    break;
            }
        }
    }
}
