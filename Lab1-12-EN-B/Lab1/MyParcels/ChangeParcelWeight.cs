using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyParcels
{
    public class ChangeParcelWeight : BaseModifier
    {
        private readonly float _overridedwight;

        public ChangeParcelWeight(IParcel _parcel, float weight) : base(_parcel)
        {
            _overridedwight = weight;
        }

        public override string Name => _parcel.Name;

        public override DateTime DeliveryDate => _parcel.DeliveryDate;

        public override float Weight => _overridedwight;

        public override string GetDescription() => _parcel.GetDescription();

        public override float GetCubature() => _parcel.GetCubature();

        public override string ToString() => _parcel.ToString();
    }
}
