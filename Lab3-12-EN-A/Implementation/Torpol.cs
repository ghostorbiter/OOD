using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Implementation
{
    class Torpol : BaseImplementation
    {
        public override Equipement MakeEquipment()
        {
            return new ExcavatorEquipment();
        }

        public override Material MakeMaterial(double amount)
        {
            return new SandMaterial(amount);
        }

        public override Transporter MakeTransporter()
        {
            return new TruckTransporter();
        }
    }
}
