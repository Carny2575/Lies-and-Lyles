namespace Lies_and_Lyles
{
    internal class Program
    {

        /* DESIGN
         * NARRATOR INTRO
         * 
         * PREMISE (NOT TOLD TO PLAYER)
         * 
         * Lies and Lyles is a text based adventure game about deciphering riddles in a dungeon, with the goal of rescuing a princess. The main character is described as an oblivious annoyance to the kingdom, so they send them into the dungeon where they expect to never see them again.
         * 	
         * Before the player enters the dungeon, they are given a message saying that "50% of the people you meet in the dungeon will be lying to you, or is that a lie as well?"
         * 
         * The player will encounter characters that give clues as to where the next staircase is that progresses through the dungeon, however, they must use the knowledge of past interactions to decipher who is lying and who isn't.
         * 
         * 
         * */




        static void Main(string[] args)
        {
            Setup.gameTitle();
            Setup.askingName();
            Setup.Welcome();
            Setup.Rules();
            Validation.clearScreen();


        }
    }

        
}
