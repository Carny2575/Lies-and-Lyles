using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lies_and_Lyles
{
    // MILES PILCHIK: LAST UPDATED 9/5: CREATED CLASS
    //PURPOSE: ENTRANCE TO DUNGEON
    internal class DungeonDoor
    {

        const int stepCount = 3;
        public DungeonDoor()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The door to the dungeon is right in front of your feet. Would you like to enter?");
        }
    }
}
