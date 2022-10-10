using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyParcels
{
    public class BaseModifier : IParcel 
    {
        protected readonly IParcel _parcel;

        protected BaseModifier(IParcel parcel)
        {
            _parcel = parcel;
        }
        public virtual string Name { get; }

        public virtual DateTime DeliveryDate { get; }

        public virtual float Weight { get; }

        public virtual string GetDescription() => _parcel.GetDescription();

        public virtual float GetCubature() => _parcel.GetCubature();

        public override string ToString() => _parcel.ToString();
    }
}
