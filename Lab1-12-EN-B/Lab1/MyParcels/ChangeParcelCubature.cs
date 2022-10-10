using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyParcels
{
    public class ChangeParcelCubature : BaseModifier
    {
        private readonly float _changedCurbature;

        public ChangeParcelCubature(IParcel parcel, float curbature) : base(parcel)
        {
            _changedCurbature = curbature;
        }

        public override float Weight => _parcel.Weight;

        public override DateTime DeliveryDate => _parcel.DeliveryDate.AddDays(2 * _changedCurbature / _parcel.GetCubature());

        public override string Name => _parcel.Name;

        public override string GetDescription() => _parcel.GetDescription();

        public override float GetCubature() => _changedCurbature;

        public override string ToString() => _parcel.ToString();
    }
}
