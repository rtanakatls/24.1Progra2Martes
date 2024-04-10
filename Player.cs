using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class Player
    {
        private int life;

        public int Life
        {
            get
            {
                return life;
            }
        }
        public Player(int life)
        {
            if (life < 0)
            {
                throw new LifeCannotBeNegativeException(life);
            }
            this.life = life;
        }
    }
}
