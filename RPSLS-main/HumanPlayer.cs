using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        //member variables (HAS A)
        public string Chosengesture;

        public HumanPlayer(string name) : base(name)
        {
            HumanPlayer humanPlayer = new HumanPlayer("PlayerOne");
        }

       

        

    }
}
