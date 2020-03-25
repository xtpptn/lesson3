using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class AncientApparition : Hero
    {
        public AncientApparition()
        {
            this.Player = "Not in use";
            this.Name = "Ancient Apparition";
            this.Type = "Intelligence";
        }

        public AncientApparition(string player) : base(player)
        {
            this.Name = "Ancient Apparition";
            this.Type = "Intelligence";
        }
}
}
