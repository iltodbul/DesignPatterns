namespace CompositePattern
{
    using System;

    public class Startup
    {
        static void Main(string[] args)
        {
            var phone = new SingleGift("Phone", 256);
            phone.CalculateTotalPrice();
            Console.WriteLine();

            var rootBox = new CompositeGift("Root Box", 0);
            var plainToy = new SingleGift("Plain", 123);
            var truckToy = new SingleGift("Truck", 55);
            rootBox.Add(plainToy);
            rootBox.Add(truckToy);
            var childBox = new CompositeGift("Child Box", 0);
            var soldierToy = new SingleGift("Soldier", 33);
            childBox.Add(soldierToy);
            rootBox.Add(childBox);

            Console.WriteLine($"Total price of this composite present is: {rootBox.CalculateTotalPrice()}");
        }
    }
}
