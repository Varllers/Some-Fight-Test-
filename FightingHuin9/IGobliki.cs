using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingHuin9
{
    interface IGobliki
    {
        void Introduction(IIntroduction intr);
        int Speed { get; }
        int Power { get; }
        string Name { get; }
    }
}
