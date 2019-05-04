using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook
{
    enum EnumIngredient
    {
        oeufs,
        frarine,
        lait,
        sucre
    }

    class Ingredients : ICupboard
    {
        private string nameIngredients;
        private int qantity;
        private EnumIngredient enumIngredient;

        
        public string NameIngredients { get => nameIngredients; set => nameIngredients = value; }
        public int Qantity { get => qantity; set => qantity = value; }

        public Ingredients()
        {

        }

        public Ingredients(string nameIngredients)
        {
            this.nameIngredients = nameIngredients;
        }

        public void Display()
        {
            Console.WriteLine("Ingredients"+ nameIngredients +
                "\tQuantity" + qantity);
        }
     


        public void Ricipe()
        {

            //if ( )
/*Si dans la poêle il y a: 1 oeuf, 1 farine, 1 lait et 1 sucre => on obtient une crêpe.
Si dans la poêle il y a: 2 oeufs et 1 lait => on obtient une omelette.
Si dans la poêle il y a: 1 lait, 1 sucre => on obtient un lait chaud sucré.
*/



        }

        public void Etat()
        {

        }

    }
}
