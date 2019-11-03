using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_CA1
{
    public class Player: IComparable
    {
        private readonly int _playerID;

        public int PlayerID
        {
            get { return _playerID; }

        }
        public string PlayerName { get; set; }
        public int Score { get; set; }

        public static int HighestScore { get; private set; }

        public Player(int playerID, string playerName, int score)
        {
            _playerID = playerID;
            PlayerName = playerName;
            Score = score;
        }

        public override string ToString()
        {
            // a differnt format for displaying the object 

            return string.Format($"{PlayerID}\t{PlayerName}\t{Score}");
        }

        public int IncreaseScore(int _score)
        {
            Score += _score;

            // see how has the hightest score
            if (_score > HighestScore)
            {
                HighestScore = _score;
            }

            return _score;
        }

        public int CompareTo(object obj)
        {
            int returnValue;
            // we require a referance for either a list, array or collection
            // to compare one object within the list to another item within the list
            Player that = obj as Player;
            // so we compare that player ie the player and comparing it to the obj which is also a player

            returnValue = this.Score.CompareTo(that.Score);
            // we now compare this score to that(the obj we use as ref) both on the part we wish to compare to.
            // so the returnValue will either be a 1,0,-1 depending were it is in the list

            // now we return that value
            return returnValue;
        }
    }

}
