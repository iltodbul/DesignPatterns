namespace CompositePattern
{
    public abstract class GiftBase
    {
        protected readonly string name;
        protected readonly int price;

        protected GiftBase(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public abstract int CalculateTotalPrice();
    }
}
