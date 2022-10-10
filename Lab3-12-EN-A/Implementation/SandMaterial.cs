using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Implementation
{
    class SandMaterial : Material
    {
        public override MaterialType GetMaterialType()
        {
            return MaterialType.Asphalt;
        }

        public SandMaterial(double amount) : base(amount) { }
        public SandMaterial() : base(0) { }
    }
}
