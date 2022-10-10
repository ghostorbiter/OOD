using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Implementation
{
    class PumpEquipment : Equipement
    {
        public override bool CanApply(Material material)
        {
            return (material.GetMaterialType() == MaterialType.Concrete || material.GetMaterialType() == MaterialType.Asphalt);
        }

        public override string GetName()
        {
            return "Pump";
        }
    }
}
