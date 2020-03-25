using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Brewmaster : Hero
    {
        public Brewmaster()
        {
            this.Player = "Not in use";
            this.Name = "Brewmaster";
            this.Type = "Strength";
        }

    public Brewmaster(string player) : base(player)
        {
            this.Name = "Brewmaster";
            this.Type = "Strength";
        }
    }
}
