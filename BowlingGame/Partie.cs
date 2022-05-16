using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BowlingGame
{
    public class Partie
    {
        private int score;
        public Partie()
        {
            this.score = 0;
        }

        public int Score()
        {
            return this.score;
        }
    }
}
