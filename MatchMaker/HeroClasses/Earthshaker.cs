using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Earthshaker : Hero
    {
        public Earthshaker()
        {
            this.Player = "Not in use";
            this.Name = "Earthshaker";
            this.Type = "Strength";
        }

        public Earthshaker(string player) : base(player)
        {
            this.Name = "Earthshaker";
            this.Type = "Strength";
        }

    }
}
