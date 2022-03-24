namespace PrototypePattern
{
    using System;

    class Startup
    {
        static void Main(string[] args)
        {
            var menu = new SandwichMenu
            {
                ["BLT"] = new Sandwich("Wheat", "Bacon", "Comte", "Lettuce, Tomato"),
                ["Tostada"] = new Sandwich("Toast", "", "", "Tomato frito, Olive oil")
            };

            var sandwich1 = menu["BLT"].Clone() as Sandwich;
            var sandwich2 = menu["Tostada"].Clone() as Sandwich;
        }
    }
}
