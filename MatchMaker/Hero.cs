using System;
using System.Collections.Generic;
using System.Text;

namespace MatchMaker
{
    public class Hero
    {
        public Hero()
        {
            this.Player = "Not in use";
        }

        public Hero(string player)
        {
            this.Player = player;
        }


        public string Player { get; set; }
        public string Name { get; protected set; }
        public string Type { get; protected set; }

        public void SetPlayer(string player)
        {
            this.Player = player;
        }

        public override string ToString()
        {
            return $"{this.Name} ({this.Type}): {this.Player} [{this.GetType().Name}]";
        }
    }
}
