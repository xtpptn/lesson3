using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Batrider : Hero
    {
        public Batrider()
        {
            this.Player = "Not in use";
            this.Name = "Batrider";
            this.Type = "Intelligence";
        }

    public Batrider(string player) : base(player)
        {
            this.Name = "Batrider";
            this.Type = "Intelligence";
        }
}
}
