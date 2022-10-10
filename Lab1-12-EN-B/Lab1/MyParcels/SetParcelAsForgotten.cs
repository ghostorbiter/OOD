using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyParcels
{
    public class SetParcelAsForgotten : BaseModifier
    {
        private readonly Random _random;

        public SetParcelAsForgotten(IParcel parcel) : base(parcel)
        {
            _random = new Random(0);
        }

        public override float Weight => (float)(_random.NextDouble() * 3 + 0.5);

        //public override DateTime DeliveryDate => DateTime.MaxValue;
        public override DateTime DeliveryDate => new DateTime(4000,01,01);

        public override string Name => _parcel.Name;

        public override string GetDescription() => _parcel.GetDescription();

        public override float GetCubature() => _parcel.GetCubature();

        public override string ToString() => _parcel.ToString();
    }
}
