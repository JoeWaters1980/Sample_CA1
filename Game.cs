using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_CA1
{
    public class Game
    {
        static void Main(string[] args)
        {
            // a standard list construction
            List<Player> players = new List<Player>();
           
            Player player1 = new Player(1, "Millie", 0);
            Player player2 = new Player(2, "Katie", 0);
            Player player3 = new Player(3, "Kevin", 0);
            Player player4 = new Player(4, "Conor", 0);
            Player player5 = new Player(5, "Pauline", 0);

            // adding to the list
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Add(player4);
            players.Add(player5);

            DistplayPlayers(players);

            EnterPlayerScore(players);

            DistplayPlayers(players);

            DisplayPlayerDetails(players);

            // when calling we do not call the whole class but the items within it (sort is H-L/reverse is L-H)
            players.Sort();
            players.Reverse();
            // again we call this to show the sorted objects
            DisplayPlayerDetails(players);
            Console.WriteLine();

            // to display the hightest score we refer to the object
            Console.WriteLine($"The Hightest score is {Player.HighestScore}");


            //Console.WriteLine(player1.ToString() + "\n" +
            //     player2.ToString() + "\n" +
            //     player3.ToString() + "\n" +
            //     player4.ToString() + "\n" +
            //     player5.ToString());
        }
       
       // Q9 increasing player score by 1 once selected.
        public static void EnterPlayerScore(List<Player> players)
        {
            int playNumber; 
            string inputText = "Please enter number of player you wish to add score for >> ";
            int exit = 0;

            Console.WriteLine(inputText);
            playNumber =int.Parse(Console.ReadLine());


            // enter loop
            while (playNumber != exit)
            {

                //get the appropriate player get player object and use the elementAt method
                // to select player

                Player selectedPlayer = players.ElementAt(playNumber-1) ;

                //add one to that players score
                // use the incraseScore method to add 1 to the score
                selectedPlayer.IncreaseScore(1);

                // display result using the displayPlayers method
                DistplayPlayers(players);

                //ask for another player number

                Console.WriteLine(inputText);

                playNumber = int.Parse(Console.ReadLine());
               
                // end of loop
            }

        }
        //Q8 displaying all players in list
        public static void DistplayPlayers(List<Player> players)
        {
            Console.WriteLine("{0,-10}{1,-10}{2,-10}{3,-10}{4,-10}", "Player 1", "Player 2", "Player 3", "Player 4", "Player 5");
            foreach (Player player in players)
            {
                Console.Write("{0,-10}", player.Score);
            }
            Console.WriteLine();
        }

        private static void DisplayPlayerDetails(List<Player> players)
        {
            Console.WriteLine($"{"ID"}\t{"Name"}\t{"Score"}");

            // for each loop to display results
            foreach (Player player in players)
            {
                Console.WriteLine(player);
            }
        }
    }

}
