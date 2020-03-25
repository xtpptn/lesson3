using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Beastmaster : Hero
    {
        public Beastmaster()
        {
            this.Player = "Not in use";
            this.Name = "Beastmaster";
            this.Type = "Strength";
        }

    public Beastmaster(string player) : base(player)
        {
            this.Name = "Beastmaster";
            this.Type = "Strength";
        }
    }
}
