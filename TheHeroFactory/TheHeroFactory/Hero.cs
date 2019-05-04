using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeroFactory
{
    class Hero : Character
    {
      

        private int lvlHero;
        private int xpHero;

       
        public int LvlHero { get => lvlHero; set => lvlHero = value; }
        public int XpHero { get => xpHero; set => xpHero = value; }

        public Hero()
        {
            nameCharacter = "Default";
            pv = 100;
            lvlHero = 1;
            xpHero = 0;
        }

       

        public void DisplayHero()
        {
            Console.WriteLine("Name of the hero " + nameCharacter +
                "\nHero Life Point " + lvlHero +
                "\nHero Experience " + xpHero +
                "\n\nHero experience increases with training and fight th enemy ");
        }

        public void GainXp()
        {
            xpHero = 0;
        }

        public void LevelUp()
        {
            lvlHero = 0;
        }
        public void AttackHero()
        {
            damageGive = 4;
        }


    }
}
