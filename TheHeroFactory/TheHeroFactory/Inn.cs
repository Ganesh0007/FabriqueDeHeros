using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace TheHeroFactory
{
    class Inn
    {
        private string innName;
        public string InnName { get => innName; set => innName = value; }

        public Inn()
        {
            List<Hero> heroes = new List<Hero>();
        }
        public Inn(string NameOfInn)
        {
            this.innName = NameOfInn;
        }


        public void AddHero(Hero hero, List<Hero> heroes)
        {
            /* à voir */
            Console.WriteLine("AddHero");
            string nameHero = Console.ReadLine();
            Hero h = new Hero();
            Character c = new Character(nameHero);
            heroes.Add(h);
        }


        public void ShowHero(List<Hero> heroes)
        {
            List<Hero> Show = heroes;
            foreach (Hero h in Show)
            {
                Console.WriteLine(h.NameCharacter);
                h.DisplayHero();
            }

        }

        public void RemoveHero(List<Hero> heroes)
        {
            List<Hero> Remove = heroes;
            Hero choice = new Hero();
            Remove.Remove(choice);
        }


        public void TrainHero(List<Hero> heroes)
        {
            List<Hero> Train = heroes;
        }

        public void FightDevil()
        {

        }







        public void MainMenu(List<Hero> Heroes)
        {
            List<Hero> heroes = Heroes;
            int choice;
            do
            {
                menu:
                Console.Clear();
                
                Console.WriteLine("1. Add new hero");
                Console.WriteLine("2. Delte a hero");
                Console.WriteLine("3. Show all hero");
                Console.WriteLine("4. Train hero");
                Console.WriteLine("5. Fight the devil");
                Console.WriteLine("7. Test to save list");
                Console.WriteLine("6. Exit\n\n");

                Console.WriteLine("Chose an option : ");
                string value = Console.ReadLine();

                /*  Gestion de la valeur  */
                try
                {
                    choice = int.Parse(value);
                }
                catch (FormatException e)
                {

                    choice = 0;
                    Console.WriteLine("ATTENTION : " + e.Message + "\n\n");
                }

                /*  Menu Principale  */
                switch (value)
                {
                    case "1":
                        add:
                        Console.Clear();
                        Console.WriteLine("1. Add new hero");
                        Console.WriteLine("Poverty, deprivation and misery are the school of the good soldier.\n");
                        bool test = true;
                        do
                        {
                            Console.WriteLine("Write here the name of your hero :");
                            string mainNameHero = Console.ReadLine();

                            if (String.IsNullOrEmpty(mainNameHero))
                            {
                                Console.WriteLine("This input is empty. Please Try Again.\n\n");
                                test = true;
                            }
                            else
                            {
                                Console.WriteLine("Write here the name of your hero to add:");
                                Hero h = new Hero();
                                h.NameCharacter = mainNameHero;
                                h.DisplayHero();
                                heroes.Add(h);
                               
                                //Console.WriteLine(heroes.Count());
                                Console.WriteLine("\n\nYour request has been made, press any key to continue...");
                                Console.ReadKey();
                                goto menu;
                            }
                        } while (test);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine("2. Delete a hero");
                        Console.WriteLine("There is no war without dead.\n");
                        
                        if (heroes.Any() && heroes != null)
                        {
                            Console.WriteLine("Write here the name of your hero to delte :");

                            string mainNameOfHero = Console.ReadLine();
                            Hero h = new Hero();
                            h.NameCharacter = mainNameOfHero;            // A revoir !
                            heroes.Remove(h);
                            //this.RemoveHero(heroes);
                            Console.WriteLine("Your request has been made.");
                        }
                        else
                        {
                            Console.WriteLine("You can't delete because no hero exists or the backup file is corrupt\n");

                        }

                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto menu;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("3. Show all hero");
                        Console.WriteLine("Swift and Secure\n");
                        if (heroes.Any() && heroes != null)
                        {
                            this.ShowHero(heroes);
                            Console.WriteLine("\n\nPress any key to continue ...");
                            Console.ReadKey();
                            goto menu;

                        }
                        else
                        {
                            Console.WriteLine("You haven't hero. You will be redirected to add new hero.");
                            Console.WriteLine("\n\nPress any key to continue...");
                            Console.ReadKey();
                            goto add;
                        }
                    case "4":
                        Console.Clear();
                        Console.WriteLine("4. Train hero");
                        Console.WriteLine("The more you sweat in training and the less you bleed in battle.\n");
                        if (heroes.Any() && heroes != null)
                        {
                            // Faire switch :
                            // 1. HeroUser vs HeroUser
                            // 2. HeroUser vs Computer
                            Console.WriteLine("Write here the name of your hero : ");
                            string hero1 = Console.ReadLine();
                            string hero2 = Console.ReadLine();
                            // Method avec la prise en charge de deux string
                            // this.TrainHero(heroes);
                        }
                        else
                        {

                        }
                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto menu;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("5. Fight the devil");
                        Console.WriteLine("It's crisp, enemies.\n");

                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto menu;

                    case "7":
                        Console.Clear();
                        Console.WriteLine("7. Test to save list");
                        Console.WriteLine("Well, nothing ventured, nothing gained.\n");
                        if (heroes.Any() && heroes != null)
                        {
                            Console.WriteLine("Sorry, It's in maintenance.");
                            /*  Test de sauvegarde*/
                            //Program.SerializeObject(heroes, "dataFile.xml");

                        }
                        else
                        {
                            Console.WriteLine("I have to redouble my efforts^^'");
                        }

                        Console.WriteLine("\n\nPress any key to continue...");
                        Console.ReadKey();
                        goto menu;
                        
                    case "6":
                        Console.Clear();
                        Console.WriteLine("The soldier who fled the fight is a soldier who can serve again...\n");
                        Console.WriteLine("Press any key to exit...");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Sorry, invalid selection.");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        goto menu;
                }
            } while (choice != 6);
        } 
    }
}



