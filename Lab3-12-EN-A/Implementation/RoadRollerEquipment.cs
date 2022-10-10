using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Implementation
{
    class RoadRollerEquipment : Equipement
    {
        public override bool CanApply(Material material)
        {
            return (material.GetMaterialType() == MaterialType.Asphalt);
        }

        public override string GetName()
        {
            return "RoadRoller";
        }
    }
}
