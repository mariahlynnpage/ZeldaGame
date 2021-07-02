using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeldaDungeonConsole
{
    public class ProgramUI
    {

        public void Run()
        {

            Console.Clear();
            Console.WriteLine("You have entered the Land of Hyrule, Ganon must be defeated...");


            Dictionary<string, int> enemylist = new Dictionary<string, int>() {
                { "Chicken", 10 },
                { "Moblin", 50 },
                { "Zora", 100 },
                { "Bokoblin", 200 },
                { "Octorok", 100 },
                { "Ganon", 1000 },
            };

            Dictionary<string, string> areas = new Dictionary<string, string>() {
                { "Greater Hyrule", "Chicken" },
                { "Great Plateu", "Bokoblin" },
                { "Forest of Spirits", "Bokoblin" },
                { "Temple of Time", "Bokoblin" },
                { "Forest of Time", "Moblin"},
                { "Kokiri Forest", "Octorock"},
                { "Kakariko Village", "Chicken" },
                { "Zorras Domain", "Zora"},
                { "Hyrule Castle", "Bokoblin"},
                { "Ganon's Castle", "Ganon" }
            };


            bool LinkIsAlive = true;
            while (LinkIsAlive)
            {
                string input = Console.ReadLine().ToLower();
                Console.Clear();
                if (input.StartsWith("go ") || input.StartsWith("exit "))
                {
                    Console.WriteLine("Go forward brave Link.");
                }
                else if (input.StartsWith("get ") || input.StartsWith("take" ) || input.StartsWith("grab "))
                {
                    Console.WriteLine("Get the item");
                }
                else if (input.StartsWith("use ") || input.StartsWith("activate "))
                {
                    Console.WriteLine("Use your item.");
                }
                else
                {
                    Console.WriteLine("You hear a fairy asking what?");
                }
            }
        }

       
    }
}
