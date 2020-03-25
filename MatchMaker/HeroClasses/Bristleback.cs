using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Bristleback : Hero
    {
        public Bristleback()
        {
            this.Player = "Not in use";
            this.Name = "Bristleback";
            this.Type = "Strength";
        }

    public Bristleback(string player) : base(player)
        {
            this.Name = "Bristleback";
            this.Type = "Strength";
        }
    }
}
