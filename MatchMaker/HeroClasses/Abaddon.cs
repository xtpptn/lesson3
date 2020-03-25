using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Abaddon : Hero
    {
        public Abaddon()
        {
            this.Player = "Not in use";
            this.Name = "Abaddon";
            this.Type = "Strength";
        }

        public Abaddon(string player) : base(player)
        {
            this.Name = "Abaddon";
            this.Type = "Strength";
        }

    }
}
