using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingHuin9
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroes Tor = new Heroes("Tor","Lightning",100,50);
            Villains Loky = new Villains("Loky","Pizdit",100,50);
            Write Writer = new Write();
            RedWrite RW = new RedWrite();
            Tor.Introduction(Writer);
            Loky.Introduction(RW);
            Fight Battle1 = new Fight(Tor,Loky);
            Battle1.GoFight(Writer);
            Console.ReadKey();
        }
    }

    class Write : IIntroduction
    {
        public void Print(string pr)
        {
            Console.WriteLine(pr);
        }
    }
    class RedWrite : IIntroduction
    {
        public void Print(string pr)
        {
            ConsoleColor cl = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(pr);
            Console.ForegroundColor = cl;
        }
    }

}
