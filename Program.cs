using Progra2.NotificationExample;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationMenu menu = new NotificationMenu();
            menu.Execute();

            Enemy enemy = new Enemy(-10);
            Console.WriteLine($"La vida del enemigo es: {enemy.Life}");


            try
            {
                int a = 0;
                int[] b = new int[0];
                Console.WriteLine(b[10]);
                Player player = new Player(-10);
                Console.WriteLine($"La vida del jugador es: {player.Life}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine("Hola mundo");
            Console.ReadLine();
            
        }
    }
}

