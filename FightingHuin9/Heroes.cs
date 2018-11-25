using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingHuin9
{
    class Heroes : Marvel, IGobliki
    {
        public Heroes(string Name, string Ability, int Power, int Speed) : base(Name, Ability, Power, Speed)
        {
        }

        public override void Introduction(IIntroduction intr)
        {
            intr.Print($"My name {Name}, i have power of {Ability} \nPower={Power}\nSpeed={Speed}");
        }
    }
}
