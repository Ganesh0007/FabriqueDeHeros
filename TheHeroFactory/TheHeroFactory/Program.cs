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
    class Program
    {
        public static void InitConsole()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
        }


        public static void Introduction()
        {

            Console.WriteLine("\tThe World War III\n\n");
            Console.WriteLine("In 2016, a few hours after General Shepherd's death in Afghanistan.\n" +
                "Soap MacTavish killed him with a knife thrown in the face while the General was going to defeat Captain Price.\n" +
                "A few days earlier, Price, Soap and Task Force 141 were tracking under the orders of Shepherd,\n" +
                "Russia's Vladimir Makarov, the main responsable of World War III. He is the opponent of the United States.\n");

            Console.WriteLine("\tNow, your misssion is train heroes to end the war.\n\n");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        /*  Essai sauvegarde  */
        // Erreur : La méthode d'extension doit être définie dans une classe statique non générique
        // https://social.msdn.microsoft.com/Forums/vstudio/en-US/0a5aa658-7276-42e5-9d9e-b786694d6020/c-serialize-listltstringgt-to-xml?forum=csharpgeneral
        /*
        public static void SerializeObject(this List<Hero> list, string fileName)
        {
            Program.SerializeObject(list, "dataFile.xml");

            var serializer = new XmlSerializer(typeof(List<Hero>));
            using (var stream = File.OpenWrite(fileName))
            {
                serializer.Serialize(stream, list);
            }
        }

        public static void Deserialize(this List<Hero> list, string fileName)
        {
            var serializer = new XmlSerializer(typeof(List<Hero>));
            using (var stream = File.OpenRead(fileName))
            {
                var other = (List<Hero>)(serializer.Deserialize(stream));
                list.Clear();
                list.AddRange(other);
            }
        }*/





        static void Main(string[] args)
        {


            InitConsole();
            Introduction();





            string nameInnProgram;
            Console.WriteLine("Do you have an inn ? (Y/N) ");
            if (Console.ReadLine() == "Y" && Console.ReadLine() == "y" && Console.ReadLine() == "YES" && Console.ReadLine() == "Yes" && Console.ReadLine() == "yes")
            {
                // Do dataFile.xml 
            }
            else
            {
                bool test = true;
                do
                {
                    Console.WriteLine("\nWrite here the name of your Inn :");
                    nameInnProgram = Console.ReadLine();
                    if (String.IsNullOrEmpty(nameInnProgram))
                    {
                        Console.WriteLine("This input is empty. Please Try Again.\n\n");
                        test = true;
                    }
                    else
                    {
                        Inn inn = new Inn(nameInnProgram);      // Backup Data
                        test = false;
                    }
                } while (test);

                Inn forMainMenu = new Inn();
                List<Hero> forMain = new List<Hero>();
                forMainMenu.MainMenu(forMain );

                

                

            }

        }
    }
}
