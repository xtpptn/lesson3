using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Alchemist : Hero
    {
        public Alchemist()
        {
            this.Player = "Not in use";
            this.Name = "Alchemist";
            this.Type = "Strength";
        }

        public Alchemist(string player) : base(player)
        {
            this.Name = "Alchemist";
            this.Type = "Strength";
        }

    }
}
