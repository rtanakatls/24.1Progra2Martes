using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra2
{
    internal class LifeCannotBeNegativeException : Exception
    {
        public LifeCannotBeNegativeException() : base("La vida no puede ser negativa")
        {

        }

        public LifeCannotBeNegativeException(int life) : base($"La vida es {life} pero no puede ser negativa")
        {

        }

        public LifeCannotBeNegativeException(string message) : base(message)
        {

        }

        public LifeCannotBeNegativeException(string message, Exception innerException) : base(message, innerException)
        {

        }
        
    }
}
