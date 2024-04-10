using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Enemy
    {
        private int life;

        public int Life
        {
            get
            {
                return life;
            }
        }
        public Enemy(int life)
        {
            if (life < 0)
            {
                Console.WriteLine("La vida no puede ser negativa");
                return;
            }
            this.life = life;
        }
    }
}
