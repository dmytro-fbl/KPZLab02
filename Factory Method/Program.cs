using Factory_Method.Factories;
using Factory_Method.Models.Abstractions;

namespace Factory_Method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ISubscriptionFactory factory = new ManagerCall();

            ISubscription mySub1 = factory.CreateSubscription(EnumSubscription.Premium);
            ISubscription mySub2 = factory.CreateSubscription(EnumSubscription.Domestic);

            Console.WriteLine($"Тип Підписки: {mySub1.GetType().Name}");
            Console.WriteLine($"Ціна: {mySub1.Price}");
            Console.WriteLine($"Період: {mySub1.Period}");
            Console.WriteLine("Канали:" + string.Join(", ", mySub1.Channels));

            Console.WriteLine();

            Console.WriteLine($"Тип Підписки: {mySub2.GetType().Name}");
            Console.WriteLine($"Ціна: {mySub2.Price}");
            Console.WriteLine($"Період: {mySub2.Period}");
            Console.WriteLine("Канали:" + string.Join(", ", mySub2.Channels));

            Console.ReadKey();
        }
    }
}
