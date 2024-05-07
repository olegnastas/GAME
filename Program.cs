using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            float health1=random.Next(40,80);
            int damage1 = random.Next(5, 20);
            int armor1 = random.Next(45, 65);

            float health2 = random.Next(50, 150);
            int damage2 = random.Next(20, 40);
            int armor2 = random.Next(65, 100);

            Console.WriteLine($"Гладиатор 1 -{health1} Здоровья, {damage1} наносимый урон, {armor1} броня.");
            Console.WriteLine($"Гладиатор 2 -{health2} Здоровья, {damage2} наносимый урон, {armor2} броня.");

            while(health1 >0 && health2 >0)
            {
                health1 -= Convert.ToSingle (random.Next(0, damage2 + 1)) / 100 * armor1;
                health2 -= Convert.ToSingle (random.Next(0, damage1 + 1)) / 100 * armor2;

                Console.WriteLine("Здоровья гладиатора1: "+ health1 +".");
                Console.WriteLine("Здоровья гладиатора2: "+ health2 +".");
            }
            if (health1<=0 && health2 <=0)
            {
                Console.WriteLine("Ничья. Оба гладиатора погибли.");
            }
            else if (health1<=0)
            {
                Console.WriteLine("Гладиатор1 пал.");
            }
            else if (health2 <= 0)
            {
                Console.WriteLine("Гладиатор2 пал.");
            }
        }
    }
}
