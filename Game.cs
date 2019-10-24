using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_CA1
{
    class Game
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


            Console.WriteLine(player1.ToString()+"\n"+
                player2.ToString()+"\n"+
                player3.ToString()+"\n"+
                player4.ToString()+ "\n"+
                player5.ToString());
        }

      

    }
   
}
