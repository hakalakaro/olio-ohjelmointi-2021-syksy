using System;

namespace _00_hevonen_koodi
{ 
    class Hevonen
    {
        public string nimi;
        public string paino;
    }

    class Program
    {
        static void Main(string[] args)
        {
           Hevonen olio = new Hevonen();
            Console.WriteLine(olio.nimi);
            Console.WriteLine(olio.paino);
            olio.nimi = "Histamiini";
            olio.paino = "89";
            Console.WriteLine(olio.nimi);
            Console.WriteLine(olio.paino);

        }
    }
}
