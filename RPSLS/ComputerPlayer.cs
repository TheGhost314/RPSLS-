using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class ComputerPlayer : Player


    {
        public ComputerPlayer(string name) : base(name)
        {
            this.name = name;
        }

        public override void ChooseGesture()
        {
            List<string> gestures = new List<string> { "rock", "paper", "scissors", "lizard", "spock" };

            Random random = new Random();
            
            int randomIndex = random.Next(gestures.Count);
            chosenGesture = gestures[randomIndex];
           
            Console.WriteLine("Computer choice: " + chosenGesture);
        }
    }
}   
