using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
   
    class Program
    {
        static int score;
        static int health;

        static void ShowHUD()
        {
            Console.WriteLine("Health = " + health);
            Console.WriteLine("Score = " + score);
        }

        static void TakeDamage(int damage)
        {
            health = health - damage;
        }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Methods2:");

            // Initialization
            score = 0;
            health = 100;

            ShowHUD();// show HUD
            TakeDamage(5); // take damage
            ShowHUD();
            TakeDamage(10); // take damage
            ShowHUD();
            TakeDamage(50);
            ShowHUD();

            Console.ReadKey(true); // wait for keypress to exit

        }
    }
}
