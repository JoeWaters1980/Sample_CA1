using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_CA1
{
    class Player
    {
        private readonly int _playerID;

        public int PlayerID
        {
            get { return _playerID; }
            
        }
        public string PlayerName { get; set; }
        public int Score { get; set; }

       public Player(int playerID,string playerName, int score)
       {
            _playerID= playerID;
             PlayerName= playerName;
            Score=score;
       }

        public override string ToString()
        {

            return string.Format("Player ID : {0}  Player Name : {1} Score : {2}", PlayerID, PlayerName, Score);
        }

        public int IncreaseScore(int _score)
        {
            Score+= _score;

            return _score;
        }
    }

}
