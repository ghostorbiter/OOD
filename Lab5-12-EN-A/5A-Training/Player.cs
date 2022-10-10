using System;

namespace _5A_Training
{
    public abstract class Player
    {
        public Random rand = new Random();
        public string Name { get; }
        public Player(string name)
        {
            Name = name;
        }
        public abstract void WarmUp();
        public abstract void HighIntensityTraining();
        public abstract void TacticalBriefing();
    }

    public class Superstar : Player
    {
        public Superstar(string name) : base(name) { }
        // TODO: finish implementation
        public override void WarmUp()
        {
            int precent = rand.Next(100);
            if (precent <= 25)
                Console.WriteLine($"{Name}: is doing something else");
            else
                Console.WriteLine($"{Name}: is late for warm-up");
        }
        public override void HighIntensityTraining()
        {
            int precent = rand.Next(100);
            if (precent <= 25)
                Console.WriteLine($"{Name}: is doing something else");
            else
                Console.WriteLine($"{Name}: is saving up his energy for the upcoming match");
        }

        public override void TacticalBriefing()
        {
            int precent = rand.Next(100);
            if (precent <= 25)
                Console.WriteLine($"{Name}: is doing something else");
            else
                Console.WriteLine($"{Name}: skips tactical briefing");
        }
    }

    public class SquadPlayer : Player
    {
        // TODO: finish implementation
        public SquadPlayer(string name) : base(name) { }
        public override void WarmUp()
        {
            int precent = rand.Next(100);
            if (precent <= 33)
                Console.WriteLine($"{Name}: away for optional training");
            else
                Console.WriteLine($"{Name}: warms up");
        }
        public override void HighIntensityTraining()
        {
            int precent = rand.Next(100);
            if (precent <= 33)
                Console.WriteLine($"{Name}: away for optional training");
            else
                Console.WriteLine($"{Name}: trains at high intensity");
        }

        public override void TacticalBriefing()
        {
            int precent = rand.Next(100);
            if (precent <= 33)
                Console.WriteLine($"{Name}: away for optional training");
            else
                Console.WriteLine($"{Name}: attends tactical briefing");
        }
    }

    public class InjuryReturnee : Player
    {
        // TODO: finish implementation
        public InjuryReturnee(string name) : base(name) { }
        public override void WarmUp()
        {
            Console.WriteLine($"{Name}: warms up");
        }
        public override void HighIntensityTraining()
        {
            Console.WriteLine($"{Name}: just returned from injury, so does not train at high intensity yet");
        }

        public override void TacticalBriefing()
        {
            Console.WriteLine($"{Name}: attends tactical briefing");
        }
    }
}