namespace SingletonPattern
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class SingletonDataContainer : ISingletonContainer
    {
        private Dictionary<string, int> capitals;

        private SingletonDataContainer()
        {
            Console.WriteLine("Initializing singleton object");
            this.capitals = new Dictionary<string, int>();
            var dataset = File.ReadAllLines("capitals.txt");
            for (int i = 0; i < dataset.Length; i += 2)
            {
                capitals.Add(dataset[i], int.Parse(dataset[i + 1]));
            }
        }

        public int GetPopulation(string name)
        {
            return this.capitals[name];
        }

        private static SingletonDataContainer instance = new SingletonDataContainer();

        public static SingletonDataContainer Instance => instance;
    }
}
