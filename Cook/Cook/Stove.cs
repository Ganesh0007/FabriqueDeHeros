using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook
{
    enum Marque
    { 
        Tefal,
        Pouce,
        Beka
    }

    class Stove : ICupboard
    {
       
        private int idStove;
        private static int nextIdStove;
        private Marque marque;
        private int volume;

        private List<Ingredients> ingredients;

        public Stove()
        {
            ingredients = new List<Ingredients>();
        }
        
        public void DisplayStove()
        {

            Console.WriteLine(idStove +
                "\tMarque" + marque +
                "\tVolume" + volume);
        }

        public void AddIngredients(Ingredients cStove)
        {
            ingredients.Add(cStove);
        }

        public bool RemoveIngredients (Ingredients cStove)
        {
            bool result = ingredients.Remove(cStove);
            return result;

            //ingredients.RemoveAll(x => x.EnumIngredient == enumIngredient);
            //return true;
        }

        public void ShowIngredients()
        {
            foreach (Ingredients i in ingredients)
            {
                i.Display();
            }
        }
        
        private bool etat = true;
        public void Etat()
        {
            
            if (etat == true)
            {
                Console.WriteLine("Hors du placard");

            }
            else
            {
                Console.WriteLine("Dans le placard");
            }
        }


        public void MainMenu(List<Ingredients> ingre)
        {
            List<Ingredients> ingredients = ingre;
            int choice;
            do
            {
            menu:
                Console.Clear();
                Console.WriteLine("1. Add new ingredients");
                Console.WriteLine("2. Delte ingredients ");
                Console.WriteLine("3. Show all ingredients");
                Console.WriteLine("4. Go to cook");
                Console.WriteLine("5. Exit\n\n");

                Console.WriteLine("Chose an option : ");
                string value = Console.ReadLine();

                try
                {
                    choice = int.Parse(value);
                }
                catch (FormatException e)
                {

                    choice = 0;
                    Console.WriteLine("ATTENTION : " + e.Message + "\n\n");
                }

                switch (value)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("1. Add new ingredients");

                        Ingredients iAdd = new Ingredients();
                        Stove stAdd = new Stove();
                        stAdd.AddIngredients(iAdd);

                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto menu;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("2. Delte ingredients ");

                        Ingredients iRm = new Ingredients();
                        Stove stRm = new Stove();
                        stRm.RemoveIngredients(iRm);

                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto menu;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("3. Show all ingredients");
                        


                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto menu;

                    case "4":
                        Console.Clear();
                        Console.WriteLine("4. Go to cook");



                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto menu;


                    case "5":
                        Console.Clear();
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        break; 

                    default:
                        Console.WriteLine("Sorry, invalid selection.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        goto menu;
                }

            } while (choice != 5);
        }
    }
}
