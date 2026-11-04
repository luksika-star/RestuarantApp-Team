
using System;
using System.Collections.Generic;

namespace RestuarantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SIT.11");
            Console.WriteLine("week 2");

            List<Restuarant> restaurants = new List<Restuarant>
            {
                new Restuarant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restuarant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restuarant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restuarant(4, "Huguosi Snacks", "Snacks", 4.2),
                new Restuarant(5, "Haidilao Hot Pot", "Hot Pot", 4.8)
            };

            Console.WriteLine("\n=== รายการร้านอาหารทั้งหมด ===");

           
        }

        
    }

    public class Restuarant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double rating { get; set; }

        public Restuarant(int id, string name, string type, double rate)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.rating = rate;
        }
    }
}
