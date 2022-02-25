using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1_RPG_Characters.Characters
{
    public class PrimaryAttributes
    {
        public PrimaryAttributes()
        {

        }
        public PrimaryAttributes(PrimaryAttributes primaryAttributes)
        {
            Strength = primaryAttributes.Strength;
            Dexterity = primaryAttributes.Dexterity;
            Intelligence = primaryAttributes.Intelligence;
        }
        public int Strength { get; set; } = 0;
        public int Dexterity { get; set; } = 0;
        public int Intelligence { get; set; } = 0;

        /// <summary>
        /// Overloads the + operator to add all individual fields of both objects.
        /// </summary>
        /// <param name="lhs">A PrimaryAttributes object to be used in the sum.</param>
        /// <param name="rhs">A PrimaryAttributes object to be used in the sum.</param>
        /// <returns>A PrimaryAttributes object representing the sum of all individual fields.</returns>
        public static PrimaryAttributes operator +(PrimaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new PrimaryAttributes
            {
                Strength = lhs.Strength + rhs.Strength,
                Dexterity = lhs.Dexterity + rhs.Dexterity,
                Intelligence = lhs.Intelligence + rhs.Intelligence
            };
        }

        /// <summary>
        /// Overloads the - operator to add all individual fields of both objects.
        /// </summary>
        /// <param name="lhs">A PrimaryAttributes object to be used in the difference.</param>
        /// <param name="rhs">A PrimaryAttributes object to be used in the difference.</param>
        /// <returns>A PrimaryAttributes object representing the difference of all individual fields.</returns>
        public static PrimaryAttributes operator -(PrimaryAttributes lhs, PrimaryAttributes rhs)
        {
            return new PrimaryAttributes
            {
                Strength = lhs.Strength - rhs.Strength,
                Dexterity = lhs.Dexterity - rhs.Dexterity,
                Intelligence = lhs.Intelligence - rhs.Intelligence
            };
        }
    }
}
