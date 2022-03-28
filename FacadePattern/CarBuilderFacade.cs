namespace FacadePattern
{
    public class CarBuilderFacade
    {
        public CarBuilderFacade()
        {
            this.Car = new Car();
        }

        protected Car Car { get; set; }

        public Car Build() => Car;

        public CarInfoBuilder CarInfo => new CarInfoBuilder(Car);

        public CarrAddressBuilder CarAddress => new CarrAddressBuilder(Car);
    }
}