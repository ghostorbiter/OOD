using System;

namespace _5A_Training
{
    internal class Program
    {
        private readonly static Player[] team =
        {
            new SquadPlayer("Adam"),
            new Superstar("Brian"),
            new InjuryReturnee("Cole")
        };

        static void Main(string[] args)
        {
            Manager boss = new Manager();

            Console.WriteLine("\nThe manager has a new training plan for the team: regular season\n");
            foreach (Player p in team)
            {
                boss.SelectTrainingProgramme(new RegularSeason(p));
                boss.StartTraining();
            }

            Console.WriteLine("\nThe manager has new training plan for the team: match day\n");
            foreach (Player p in team)
            {
                boss.SelectTrainingProgramme(new MatchDay(p));
                boss.StartTraining();
            }

            Console.WriteLine("\nThe manager has a new training plan for the team: off-season\n");
            foreach (Player p in team)
            {
                boss.SelectTrainingProgramme(new OffSeason(p));
                boss.StartTraining();
            }

            Console.ReadKey();
        }
    }
}