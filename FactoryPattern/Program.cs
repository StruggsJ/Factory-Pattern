namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {

            var userChoice = "";

            Console.WriteLine("Good day. Would you like a cup of coffee or tea?");
            userChoice = Console.ReadLine();

            var drink = BreverageFactory.GetDrink(userChoice);
            drink.Drink();
            Console.ReadLine();
        }
    }
}
