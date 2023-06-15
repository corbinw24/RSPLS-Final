using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class ComputerPlayer : Player
    {
        public List<String> Gestures;

        public void Player()
        {
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
        }

        public ComputerPlayer(string name) : base(name)
        {
            Console.WriteLine("Please Choose a gesture");
            Console.WriteLine("1. Rock");
            Console.WriteLine("2. Paper");
            Console.WriteLine("3. Scissors");
            Console.WriteLine("4. Lizard");
            Console.WriteLine("5. Spock");

        }
    }
}
