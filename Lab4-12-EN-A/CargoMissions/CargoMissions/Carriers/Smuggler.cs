using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoMissions;
using CargoMissions.Carriers;
using CargoMissions.Missions;


namespace CargoMissions.Carriers
{
    public class Smuggler : ICarrier
    {
        public string Name { get; }

        public Planet Location { get; private set; }

        public double Expertise { get; }

        public double MinimalFee { get; }

        public Smuggler(string name, Planet location,
            double expertise, double minimalFee)
        {
            Name = name;
            Location = location;
            Expertise = expertise;
            MinimalFee = minimalFee;
        }

        public bool haveExpressMission(ExpressMission express)
        {
            if (express.Reward > 0.5 * MinimalFee && Location == express.Starting && PlanetExtensions.DistanceTo(Location, express.Destination) < express.MaximumTime)
            {
                express.IsCompleted = true;
                Location = express.Destination;
                return true;
            }

            return false;
        }

        public bool haveContestedMission(ContestedMission contested)
        {
            return false;
        }

        public bool haveSmugglingMission(SmugglingMission smuggling)
        {
            if (Expertise > smuggling.Risk && smuggling.Reward > MinimalFee)
            {
                smuggling.IsCompleted = true;
                Location = smuggling.Destination;
                return true;
            }

            return false;
        }
    }
}
