using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Axe : Hero
    {
        public Axe()
        {
            this.Player = "Not in use";
            this.Name = "Axe";
            this.Type = "Strength";
        }

    public Axe(string player) : base(player)
        {
            this.Name = "Axe";
            this.Type = "Strength";
        }
    }
}
