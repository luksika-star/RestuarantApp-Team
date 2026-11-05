
using System;
using System.Collections.Generic;
using System.Linq;

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

            foreach (Restuarant res in restaurants)
            {
                Console.WriteLine($"ID: {res.id} | ร้าน: {res.name} | ประเภท: {res.type} | คะแนน: {res.rating}");
            }

            // เรียกใช้งานเมธอดเพิ่มร้านอาหาร
            AddRestaurant(restaurants);

            // แสดงรายการร้านอาหารอีกครั้ง
            Console.WriteLine("\n=== รายการร้านอาหารหลังเพิ่มข้อมูล ===");

            foreach (Restuarant res in restaurants)
            {
                Console.WriteLine($"ID: {res.id} | ร้าน: {res.name} | ประเภท: {res.type} | คะแนน: {res.rating}");
            }
        }

        public static void AddRestaurant(List<Restuarant> restaurants)
        {
            Console.WriteLine("\n--- เพิ่มข้อมูลร้านอาหารใหม่ ---");

            int id = restaurants.Count + 1;

            Console.Write("กรอกชื่อร้าน: ");
            string name = Console.ReadLine();

            Console.Write("กรอกประเภทร้าน: ");
            string type = Console.ReadLine();

            Console.Write("กรอกคะแนนร้าน (เช่น 4.5): ");

            double rating;

            while (!double.TryParse(Console.ReadLine(), out rating))
            {
                Console.Write("กรอกข้อมูลไม่ถูกต้อง กรุณากรอกคะแนนเป็นตัวเลข: ");
            }

            restaurants.Add(new Restuarant(id, name, type, rating));

            Console.WriteLine("เพิ่มข้อมูลร้านสำเร็จ");

            // แสดงร้านอาหารที่มีคะแนนตั้งแต่ 4.5 ขึ้นไป
            Console.WriteLine("\n=== ร้านอาหารคะแนนดี (4.5 ขึ้นไป) ===");
            foreach (var restaurant in restaurants)
            {
                if (restaurant.rating >= 4.5)
                {
                    Console.WriteLine(
                        $"ชื่อร้าน: {restaurant.name}, " +
                        $"ประเภท: {restaurant.type}, " +
                        $"คะแนน: {restaurant.rating}"
                    );
                }
            }


        }
        // แสดงค่าสูงสุดต่ำสุด
        static void Summary(List<Restuarant> list)
        {
            Console.WriteLine("\n===== Restaurant Summary =====");

            if (list.Count == 0)
            {
                Console.WriteLine("No restaurant data.");
                return;
            }
            var highest = list.OrderByDescending(
            r => r.rating).First();

            var lowest = list.OrderBy(
                r => r.rating).First();

            Console.WriteLine(
                $"Highest: {highest.name} ({highest.rating})");

            Console.WriteLine(
                $"Lowest: {lowest.name} ({lowest.rating})");
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
