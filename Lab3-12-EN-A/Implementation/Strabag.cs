using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Implementation
{
    class Strabag : BaseImplementation
    {
        public override Equipement MakeEquipment()
        {
            return new RoadRollerEquipment();
        }

        public override Material MakeMaterial(double amount)
        {
            return new AsphaltMaterial(amount);
        }

        public override Transporter MakeTransporter()
        {
            return new CisternTransporter();
        }
    }
}
