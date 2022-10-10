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
    public class Flotilla : ICarrier
    {
        public string Name { get; }

        public Planet Location { get; private set; }

        public double Strength { get; }

        public Flotilla(string name, Planet location, double strength)
        {
            Name = name;
            Location = location;
            Strength = strength;
        }

        public bool haveExpressMission(ExpressMission express)
        {
            return false;
        }

        public bool haveContestedMission(ContestedMission contested)
        {
            if (Strength > 1.5 * contested.EnemyStrength && Location == contested.Destination)
            {
                contested.IsCompleted = true;
                Location = contested.Destination;
                return true;
            }

            return false;
        }

        public bool haveSmugglingMission(SmugglingMission smuggling)
        {
            return false;
        }
    }
}
