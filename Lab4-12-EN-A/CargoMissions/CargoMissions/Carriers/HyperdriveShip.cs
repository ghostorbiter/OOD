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
    public class HyperdriveShip : ICarrier
    {
        public string Name { get; }

        public Planet Location { get; private set; }

        public double HyperdriveSpeed { get; }

        public HyperdriveShip(string name, Planet location, double hyperdriveSpeed)
        {
            Name = name;
            Location = location;
            HyperdriveSpeed = hyperdriveSpeed;
        }

        public bool haveExpressMission(ExpressMission express)
        {
            if (PlanetExtensions.DistanceTo(Location, express.Destination) / HyperdriveSpeed < express.MaximumTime)
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
            if (HyperdriveSpeed > smuggling.Risk)
            {
                smuggling.IsCompleted = true;
                Location = smuggling.Destination;
                return true;
            }

            return false;
        }
    }
}
