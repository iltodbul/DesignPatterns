namespace FacadePattern
{
    public class CarrAddressBuilder : CarBuilderFacade
    {
        public CarrAddressBuilder(Car car)
        {
            Car = car;
        }

        public CarrAddressBuilder InCity(string city)
        {
            Car.City = city;
            return this;
        }

        public CarrAddressBuilder AtAddress(string address)
        {
            Car.Address = address;
            return this;
        }
    }
}