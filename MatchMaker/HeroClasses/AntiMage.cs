using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class AntiMage : Hero
    {
        public AntiMage()
        {
            this.Player = "Not in use";
            this.Name = "Anti-Mage";
            this.Type = "Agility";
        }

        public AntiMage(string player) : base(player)
        {
            this.Name = "Anti-Mage";
            this.Type = "Agility";
        }
    }
}
