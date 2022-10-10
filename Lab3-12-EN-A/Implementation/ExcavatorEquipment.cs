using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Implementation
{
    class ExcavatorEquipment : Equipement
    {
        public override bool CanApply(Material material)
        {
            return (material.GetMaterialType() == MaterialType.Sand);
        }

        public override string GetName()
        {
            return "Excavator";
        }
    }
}
