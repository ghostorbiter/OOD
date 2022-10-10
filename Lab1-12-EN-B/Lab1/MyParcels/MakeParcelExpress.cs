using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyParcels
{
    public class MakeParcelExpress : BaseModifier
    {
        private readonly int _daysDecrease;
        public MakeParcelExpress(IParcel parcel, int days) : base(parcel)
        {
            _daysDecrease = days;
        }

        public override float Weight => _parcel.Weight;

        public override DateTime DeliveryDate => _parcel.DeliveryDate.AddDays(-_daysDecrease);

        public override string Name => _parcel.Name;

        public override string GetDescription() => _parcel.GetDescription();

        public override float GetCubature() => _parcel.GetCubature()/2;

        public override string ToString() => _parcel.ToString();
    }
}
