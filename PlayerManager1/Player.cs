using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManager1
{
    public class Player
    {
        public string Name { get; }
        public int    Score {get; set;}

        // Constructor
        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }
    }
}