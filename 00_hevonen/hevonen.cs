using System;

namespace _01_hevonen
{
    public class Horse
    {
        public string name;
        public int weight;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Horse hevonen = new Horse(); 
            Console.WriteLine(hevonen.name +" "+hevonen.weight);
            hevonen.name = "Histamiini";
            hevonen.weight = 89;
            Console.WriteLine(hevonen.name + " " + hevonen.weight);
        }



    }
}

    
