using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Bane : Hero
    {
        public Bane()
        {
            this.Player = "Not in use";
            this.Name = "Bane";
            this.Type = "Intelligence";
        }

    public Bane(string player) : base(player)
        {
            this.Name = "Bane";
            this.Type = "Intelligence";
        }
}
}
