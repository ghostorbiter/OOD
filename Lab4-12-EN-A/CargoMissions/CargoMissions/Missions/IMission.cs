using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CargoMissions;
using CargoMissions.Carriers;
using CargoMissions.Missions;

namespace CargoMissions.Missions
{
    public interface IMission
    {
        string Name { get; }
        Planet Starting { get; }
        Planet Destination { get; }
        double Reward { get; }
        bool IsCompleted { get; set; }
        bool Finished(ICarrier carrier);
    }
}
