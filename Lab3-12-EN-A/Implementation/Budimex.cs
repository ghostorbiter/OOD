using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Implementation
{
    class Budimex : BaseImplementation
    {
        public override Equipement MakeEquipment()
        {
            return new PumpEquipment();
        }

        public override Material MakeMaterial(double amount)
        {
            return new ConcreteMaterial(amount);
        }

        public override Transporter MakeTransporter()
        {
            return new MixerTransporter();
        }
    }
}
