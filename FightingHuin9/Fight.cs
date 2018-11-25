using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingHuin9
{
    class Fight
    {
        IGobliki Her;
        IGobliki Vil;
        public Fight(IGobliki Her, IGobliki Vil)
        {
            this.Her = Her;
            this.Vil = Vil;
        }

        public void GoFight(IIntroduction intrs)
        {
            if(Her?.Power+Her?.Speed > Vil?.Power + Vil?.Speed)
            {
                intrs.Print($"{Her.Name} is Winner!");
            }
            else
            {
                if((Her?.Power + Her?.Speed < Vil?.Power + Vil?.Speed))
                {
                    intrs.Print($"{Vil.Name} is Winner!");
                }
                else
                {
                    intrs.Print($"They are equal!");
                }
            }
            
        }
    }
}
