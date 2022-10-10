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
    public interface ICarrier
    {
        string Name { get; }
        Planet Location { get; }
        bool haveExpressMission(ExpressMission express);
        bool haveContestedMission(ContestedMission contested);
        bool haveSmugglingMission(SmugglingMission smuggling);
    }
}
