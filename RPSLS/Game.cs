using System.ComponentModel.Design;
using System.Xml;

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
            Console.WriteLine("Welcome to RPSLS! Here are the rules:/n");
            Console.WriteLine("Rock beats Scissors!,Scissors beats Paper!,Paper beats Rock!");
            Console.WriteLine("Rock beats Lizard!, Lizard beats Spock!, Spock beats Scissors!");
            Console.WriteLine("Scissors beats Lizard!, Lizard beats Paper!, Paper beats Spock!, Spock beats Rock!.");
            Console.WriteLine("- winner of the round is determined on the rules of the game");
            Console.WriteLine("- if both players have the same gesture it will be ruled as a tie!");
            Console.WriteLine("Each player will play 3 rounds, best out of 3 wins the game!.");

        }


        public int ChooseNumberOfHumanPlayers()
        {
            // 1. We need to first display "How many players? 1 or 2?"
            Console.WriteLine("There is 1 human player in the game!");
            // 2. Get the user input and store it in a variable
            int numberOfHumanPlayers = 1;
            // 3. Return the variable



            return numberOfHumanPlayers;


        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
        {
            
            if (numberOfHumanPlayers > 0)
            {
                Console.WriteLine("Player one is a human!");
            }
            else if (numberOfHumanPlayers < 0)
            {
                Console.WriteLine("Player two is a computer!");
            }
            else
            {
                Console.WriteLine("Player two is a human!");
            }
               
            
            //if numberOfHumanPlayers is 1, playerTwo is a computer
            //else playerTwo is a human
            
            
        }

        public void CompareGestures()
        {

            playerOne.ChooseGesture();

            playerTwo.ChooseGesture();


            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }
             

            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }

            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "scissors")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;

            }
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "lizard" && playerTwo.chosenGesture == "paper")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }
            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock")
            {
                Console.WriteLine("player one wins the round!");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("player two wins the round!");
                playerTwo.score++;
            }



        }

            public void DisplayGameWinner()
        {
            if (playerOne.score > playerTwo.score)
            {
                Console.WriteLine("player one wins the game!");
            }
            else if (playerTwo.score > playerOne.score)
            {
                Console.WriteLine("player two wins the game!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
        }

        public void RunGame()
        {
            //Step one what beats what to win the game?
            //Step two how many rounds will be played in the game? 
            WelcomeMessage();

            // 1. This variable should capture the value returned from ChooseNumberOfHumanPlayers()
            int numberOfHumanPlayers = ChooseNumberOfHumanPlayers();

            // 2. We need to take the numberOfHumanPlayers value and determine how many player objects we'll create - CreatePlayerObjects
            playerOne = new HumanPlayer("James");
            playerTwo = new ComputerPlayer("Computer");

            CompareGestures();
            DisplayGameWinner();
             
            int winningScore = 3;
            bool gameWinner = true;
            
           while (playerOne.score < winningScore && playerTwo.score < winningScore)
            {
                CompareGestures();

                Console.WriteLine("Round" + (playerOne.score + playerTwo.score + 1));
                Console.WriteLine("play another round?: ");
                string playAgain = Console.ReadLine().ToLower();
                if (playAgain != "yes")
                {
                    break;
                }
           


            }  
                
                
                    
                
            
        }
    }
}



