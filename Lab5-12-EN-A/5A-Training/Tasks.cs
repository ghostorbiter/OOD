using System;

namespace _5A_Training
{
    public abstract class Task
    {
        protected Player _player;
        public Task(Player player) => _player = player;
        public abstract void Train();
    }

    public class RegularSeason : Task
    {
        // TODO: finish implementation
        public RegularSeason(Player player) : base(player) { }
        public override void Train()
        {
            for (int i = 0; i < 6; i++)
            {
                if (i < 3)
                    Console.WriteLine($"Hour: {10+i}:00");
                else
                    Console.WriteLine($"Hour: {12+i}:00");

                if (i % 3 == 0)
                    _player.TacticalBriefing();
                else if (i % 3 == 1)
                    _player.WarmUp();
                else
                    _player.HighIntensityTraining();
            }
        }
    }

    public class MatchDay : Task
    {
        // TODO: finish implementation
        public MatchDay(Player player) : base(player) { }
        public override void Train()
        {
            for (int i = 0; i < 3; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Hour: 11:00");
                        _player.TacticalBriefing();
                        break;
                    case 1:
                        Console.WriteLine("Hour: 12:00");
                        _player.WarmUp();
                        break;
                    case 2:
                        Console.WriteLine("Hour: 20:00");
                        _player.WarmUp();
                        break;
                    default:
                        throw new Exception("Oops! Something went wrong!");
                }
            }
        }
    }

    public class OffSeason : Task
    {
        // TODO: finish implementation
        public OffSeason(Player player) : base(player) { }
        Random rand = new Random();
        public override void Train()
        {
            int precent = rand.Next(100);
            if (precent >= 50)
            {
                int time = rand.Next(24);
                Console.WriteLine($"Hour: {time}:00");
                _player.WarmUp();
            }
            else
            {
                for (int i = 0; i < 6; i++)
                {
                    if (i < 3)
                        Console.WriteLine($"Hour: {10 + i}:00");
                    else
                        Console.WriteLine($"Hour: {12 + i}:00");

                    if (i % 3 == 0)
                        _player.TacticalBriefing();
                    else if (i % 3 == 1)
                        _player.WarmUp();
                    else
                        _player.HighIntensityTraining();
                }
            }
        }
    }
}