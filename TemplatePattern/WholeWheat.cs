namespace TemplatePattern
{
    using System;
    
    public class WholeWheat : Bread
    {
        public override void MixIngredients()
        {
            Console.WriteLine($"Gathering the ingredients for Whole wheat bread");

        }

        public override void Bake()
        {
            Console.WriteLine("Baking the Whole wheat bread. (15 minutes)");
        }
    }
}
