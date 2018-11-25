using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingHuin9
{
    abstract class Marvel : IGobliki
    {
        public string Name { get; set; }
        public string Ability { get; set; }
        public int Power { get; set; }
        public int Speed { get; set; }

        public Marvel(string Name, string Ability, int Power, int Speed)
        {
            this.Name = Name;
            this.Ability = Ability;
            this.Power = Power;
            this.Speed = Speed;
        }

        public abstract void Introduction(IIntroduction intr);

    }
}
