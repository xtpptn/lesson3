using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class BountyHunter : Hero
    {
        public BountyHunter()
        {
            this.Player = "Not in use";
            this.Name = "Bounty Hunter";
            this.Type = "Agility";
        }

    public BountyHunter(string player) : base(player)
        {
            this.Name = "Bounty Hunter";
            this.Type = "Agility";
        }
    }
}
