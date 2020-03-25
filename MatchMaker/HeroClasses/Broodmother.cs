using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Broodmother : Hero
    {
        public Broodmother()
        {
            this.Player = "Not in use";
            this.Name = "Broodmother";
            this.Type = "Agility";
        }

    public Broodmother(string player) : base(player)
        {
            this.Name = "Broodmother";
            this.Type = "Agility";
        }
    }
}
