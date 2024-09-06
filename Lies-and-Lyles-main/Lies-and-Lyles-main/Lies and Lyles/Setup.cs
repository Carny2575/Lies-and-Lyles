using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lies_and_Lyles
{

    // MILES PILCHIK: LAST UPDATED 9/5: CREATED CLASS
    internal class Setup
    {
        static string name;

       
        //ASK PLAYER NAME
        public static void askingName()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I am the narrator of this fine tale. What is your name?");
            Console.ForegroundColor = ConsoleColor.White;
            name = Console.ReadLine();
        }

        //PRINTS GAME TITLE
        public static void gameTitle()
        {

            Console.ForegroundColor = ConsoleColor.White;
            
            Console.WriteLine("Welcome to Lies and Lyles");
        }

        //WELCOME PLAYER
        public static void Welcome()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello " + name);
        }

        //RULES OF GAME
        public static void Rules()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You are described as an oblivious and annoying bard, sent by the kingdom to save the princess from the dungeon");
            Console.WriteLine("Before we go on this adventure, I wanted to tell you some of the rules you must abide by");
            Console.WriteLine("You will encounter many friends and foes in that dungeon over there. I can give you a quick tip to help you on your journey. Do you want to hear it?");
            
            //Console.WriteLine("Please type either y or n to respond");
        }
       

    }
}
