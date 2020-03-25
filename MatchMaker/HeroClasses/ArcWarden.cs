using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class ArcWarden : Hero
    {
        public ArcWarden()
        {
            this.Player = "Not in use";
            this.Name = "Arc Warden";
            this.Type = "Agility";
        }

    public ArcWarden(string player) : base(player)
        {
            this.Name = "Arc Warden";
            this.Type = "Agility";
        }
    }
}
