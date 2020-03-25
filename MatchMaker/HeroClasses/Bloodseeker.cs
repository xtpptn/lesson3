using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Bloodseeker : Hero
    {
        public Bloodseeker()
        {
            this.Player = "Not in use";
            this.Name = "Bloodseeker";
            this.Type = "Agility";
        }

    public Bloodseeker(string player) : base(player)
        {
            this.Name = "Bloodseeker";
            this.Type = "Agility";
        }
    }
}
