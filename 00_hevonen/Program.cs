using System;

namespace _00_hevonen
{
    class Program
    {
        public class Horse
        {
            public string name;
            public int weight;

            public Horse()
            {
                name = "default";
                weight = 100;
            }
        }

        static void Main(string[] args)
        {
            Horse horse = new();
            Console.WriteLine($"{horse.name} {horse.weight}");
            horse.name = "Histamiini";
            horse.weight = 89;
            Console.WriteLine($"{horse.name} {horse.weight}");
        }
    }
}
