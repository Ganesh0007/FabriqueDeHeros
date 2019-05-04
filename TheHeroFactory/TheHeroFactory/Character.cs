using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheHeroFactory
{
    class Character
    {
        protected string nameCharacter;
        public string NameCharacter { get => nameCharacter; set => nameCharacter = value; }

        protected int pv;
    
        protected int power;
        protected int stamina;
        protected int agility;


        protected int damageGive;

        public Character()
        {

        }

        public Character(string nameCharacter)
        {
            this.nameCharacter = nameCharacter;
        }

        public void Attack(int power)
        {
            this.power = power;
        }

        public void RecieveDommage(int pv)
        {
            this.pv = pv;
        }

    }
}
