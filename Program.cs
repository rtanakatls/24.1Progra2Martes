using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy enemy = new Enemy(-10);
            Console.WriteLine($"La vida del enemigo es: {enemy.Life}");


            try
            {
                Player player = new Player(-10);
                Console.WriteLine($"La vida del jugador es: {player.Life}");
            }
            catch (LifeCannotBeNegativeException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
            
        }
    }
}

