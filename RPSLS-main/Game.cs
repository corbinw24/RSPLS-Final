using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n Scissors cuts paper." +
                "\r\nPaper covers rock.\r\nRock crushes lizard.\r\nLizard poisons Spock.\r\nSpock smashes scissors." +
                "\r\nScissors decapitates lizard.\r\nLizard eats paper.\r\nPaper disproves Spock.\r\nSpock vaporizes rock." +
                "\r\nRock crushes scissors");
        }

        public int ChooseNumberOfHumanPlayers()
        {
            Console.WriteLine("Choose between 1 or 2 the amount of players you will be using.");
            return 1;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();
            playerOne = new HumanPlayer("PlayerOne");
            playerTwo = new ComputerPlayer("PlayerTwo");
        }

        public void CompareGestures()
        {
            Console.WriteLine("PlayerOne chose the gesture Spock");
            Console.WriteLine("PlayerTwo chose the gesture Rock");
            Console.WriteLine("PlayerOne won the first round");
            int value = 1;
            value++;
            Console.WriteLine("Incremented value: " + value);

        }

        public void DisplayGameWinner()
        {
            Console.WriteLine("Congratulations, You've Won!");
        }

        public void RunGame()
        {
            WelcomeMessage();
            ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(2);
            CompareGestures();
            DisplayGameWinner();


        }
    }
}
