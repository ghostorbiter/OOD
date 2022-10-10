using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyParcels
{
    public class MakeParcelFragile : BaseModifier
    {
        private readonly FragilityType _newFragileType;
        public MakeParcelFragile(IParcel parcel, FragilityType fr) : base(parcel)
        {
            _newFragileType = fr;
        }

        public override float Weight => _parcel.Weight*2;

        public override DateTime DeliveryDate => _parcel.DeliveryDate;

        public override string Name => _parcel.Name;

        public override string GetDescription() => $"{_newFragileType}";

        public override float GetCubature() => _parcel.GetCubature();

        public override string ToString() => _parcel.ToString();
    }
}
