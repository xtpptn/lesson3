using System;
using System.Collections.Generic;
using System.IO;

namespace MatchMaker
{
    class Program
    {
        static void Main(string[] args)
        {

            const int teamSize = 5;
            Random random = new Random();

            // SET RESOURCE PATH
            string projectPath = Directory.GetCurrentDirectory();
            projectPath = Directory.GetParent(projectPath).Parent.Parent.FullName;
            projectPath += "\\Resources\\players.csv";

            string[] input = File.ReadAllLines(projectPath);
            
            List<string> players = new List<string>(input);

            List<Hero> heroes = new List<Hero>();
            InitialiseHeros(heroes);

            
            
            /* 
            input = File.ReadAllLines(@"M:\c\Lesson3\heroes.csv");
            List<string> heroNames = new List<string>(input); */

            List<Hero> teamRed = new List<Hero>();
            List<Hero> teamBlue = new List<Hero>();



            for (int i = 0; i < teamSize; i++)
            {

                /// Team Red
                int playerListIndex = random.Next(0, players.Count);
                int heroesListIndex = random.Next(0, heroes.Count);

                teamRed.Add(heroes[heroesListIndex]);
                heroes.RemoveAt(heroesListIndex);

                teamRed[i].Player = players[playerListIndex];
                players.RemoveAt(playerListIndex);


                /// Team Blue
                playerListIndex = random.Next(0, players.Count);
                heroesListIndex = random.Next(0, heroes.Count);

                teamBlue.Add(heroes[heroesListIndex]);
                heroes.RemoveAt(heroesListIndex);

                teamBlue[i].Player = players[playerListIndex];
                players.RemoveAt(playerListIndex);

            }

            /// Hint
            Console.WriteLine("Hero (Type): Player [ClassName]");


            /// Team Red - Player List
            Console.WriteLine("\nTeam Red");
            for (int i = 0; i < teamRed.Count; i++)
            {
                Console.WriteLine(teamRed[i].ToString());
            }


            /// Team Blue - Player List
            Console.WriteLine("\nTeam Blue");
            for (int i = 0; i < teamBlue.Count; i++)
            {
                Console.WriteLine(teamBlue[i].ToString());
            }

            Console.Write("\nPress any key to terminate the application.");
            Console.ReadKey();

        }


        static void InitialiseHeros(List<Hero> heroes)
        {

            heroes.Add(new Abaddon());
            heroes.Add(new Alchemist());
            heroes.Add(new AncientApparition());
            heroes.Add(new AntiMage());
            heroes.Add(new ArcWarden());
            heroes.Add(new Axe());
            heroes.Add(new Bane());
            heroes.Add(new Batrider());
            heroes.Add(new Beastmaster());
            heroes.Add(new Bloodseeker());
            heroes.Add(new BountyHunter());
            heroes.Add(new Brewmaster());
            heroes.Add(new Bristleback());
            heroes.Add(new Broodmother());
            heroes.Add(new Earthshaker());

        }

    }
}
