using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Items
{
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException()
        {

        }

        public InvalidWeaponException(string message) : base(message)
        {

        }
    }
}
