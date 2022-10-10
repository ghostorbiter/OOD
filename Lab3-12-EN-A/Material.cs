using Construction;
using System;
using System.Collections.Generic;
using System.Text;

namespace Construction
{
    public enum MaterialType{
        Sand,
        Concrete,
        Asphalt
    }
    public abstract class Material
    {
        protected double amount;
        public double Amount
        {
            get { return amount; }
        }
        
        public Material(double amount)
        {
            this.amount = amount;
        }

        public abstract MaterialType GetMaterialType();
    }
}
