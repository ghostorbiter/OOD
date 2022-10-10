using System;
using System.Collections.Generic;
using System.Text;

namespace Construction
{
    public abstract class Transporter
    {
        protected readonly double wheelLoad = 2;

        public abstract int Wheels { get; }

        public abstract int LoadPercentage(Material material);

        public abstract string GetName();
    }
}
