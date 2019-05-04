using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cook
{
    class Program
    {
        public static void InitConsole()
        {
            Console.OutputEncoding = System.Text.Encoding.GetEncoding(28591);
        }
        
        static void Main(string[] args)
        {
            InitConsole();

            // Frist chose your stove


            // Let's play

            Stove forMainMenu = new Stove();
            List<Ingredients> forMain = new List<Ingredients>();
            forMainMenu.MainMenu(forMain);
        }
    }
}
