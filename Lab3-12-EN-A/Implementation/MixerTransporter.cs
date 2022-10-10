using System;

namespace Construction.Implementation
{
    class MixerTransporter : Transporter
    {
        public override int Wheels => 4;
        public override string GetName()
        {
            return "Max the Mixer";
        }

        public override int LoadPercentage(Material material)
        {
            return ((int)(1000 * material.Amount / Wheels));
        }
    }
}
