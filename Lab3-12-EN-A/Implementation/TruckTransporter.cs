using System;
using System.Collections.Generic;
using System.Text;

namespace Construction.Implementation
{
    class TruckTransporter : Transporter
    {
        public override int Wheels => 8;
        public override string GetName()
        {
            return "Thomas the Truck";
        }

        public override int LoadPercentage(Material material)
        {
            return ((int)(1000 * material.Amount / (Wheels - 2)) + 3000);
        }
    }
}
