using RPSLS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class HumanPlayer : Player
    {
        
        public HumanPlayer(string name) : base(name)
        {
            this.name = name;
        }

        public override void ChooseGesture()
        {
            List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };
            Console.WriteLine($"Human player choose your gesture rock, paper, scissor, lizard, spock");
            chosenGesture = Console.ReadLine();
        }

        public class Player
        {
            



        }


          

    
    }
}    
    

    

    
    

