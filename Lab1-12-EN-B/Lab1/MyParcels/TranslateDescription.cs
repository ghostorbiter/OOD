using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyParcels
{
    class TranslateDescription : BaseModifier
    {
        public TranslateDescription(IParcel parcel) : base(parcel) { }

        public override float Weight => _parcel.Weight;

        public override DateTime DeliveryDate => _parcel.DeliveryDate;

        public override string Name => _parcel.Name;

        public override string GetDescription() => "folowing description is in french:\n" + _parcel.GetDescription();

        public override float GetCubature() => _parcel.GetCubature();

        public override string ToString() => _parcel.ToString();
    }
}
