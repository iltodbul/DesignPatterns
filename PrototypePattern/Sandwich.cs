namespace PrototypePattern
{
    using System;

    public class Sandwich : SandwichPrototype
    {
        private readonly string bread;
        private readonly string meat;
        private readonly string cheese;
        private readonly string veggies;

        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            this.bread = bread;
            this.meat = meat;
            this.cheese = cheese;
            this.veggies = veggies;
        }

        public override SandwichPrototype Clone()
        {
            var ingredients = this.GetIngredients();
            Console.WriteLine($"Cloning sandwich with ingredients: {ingredients}");

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredients()
        {
            return $"{this.bread}, {this.cheese}, {this.meat}, {this.veggies}";
        }
    }
}
