using System;

namespace Construction.Implementation
{
    class CisternTransporter : Transporter
    {
        public override int Wheels => 12;
        public override string GetName()
        {
            return "Clara the Cistern";
        }

        public override int LoadPercentage(Material material)
        {
            return ((int)(1000 * material.Amount / (Wheels - 2)));
        }
    }
}
