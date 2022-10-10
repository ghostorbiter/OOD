using Construction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Construction
{
    public abstract class Equipement
    {
        public abstract string GetName();

        public abstract bool CanApply(Material material);
    }
}
