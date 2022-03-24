namespace TemplatePattern
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var twelveGrain = new TwelveGrain();
            twelveGrain.Make();

            var sourdough = new Sourdough();
            sourdough.Make();

            var wholeWheat = new WholeWheat();
            wholeWheat.Make();
        }
    }
}
