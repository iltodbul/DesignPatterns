namespace FacadePattern
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var car = new CarBuilderFacade()
                .CarInfo
                .WithType("BMW")
                .WithColor("Red")
                .WhitNumberOfDoors(4)
                .CarAddress
                .InCity("Berlin")
                .AtAddress("Some address in Berlin")
                .Build();

            Console.WriteLine(car);
        }
    }
}
