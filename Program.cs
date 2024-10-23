using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Oevelse_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<Enemy> enemies = new List<Enemy>();
            for (int i = 0; i < 10; i++)
            {
                enemies.Add(new Enemy($"Enemy{i}"));
            }
            foreach (var enemy in enemies)
            {
                Console.WriteLine(enemy.Name);
            }
            Console.WriteLine();
            for (int i = 0; i < enemies.Count; i++)
            {
                Console.WriteLine(enemies[i].Name);
            }
            for (int i = 0; i < 3; i++)
            {
                enemies.RemoveAt(random.Next(0, enemies.Count));
            }
            Console.WriteLine();
            foreach (var enemy in enemies)
            {
                Console.WriteLine(enemy.Name);
            }
            Console.ReadKey();
        }
    }
}
