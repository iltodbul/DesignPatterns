namespace TemplatePattern
{
    using System;
   
    public class TwelveGrain : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering the ingredients for Twelve grain bread");
        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Twelve grain bread. (25 minutes)");
        }
    }
}
