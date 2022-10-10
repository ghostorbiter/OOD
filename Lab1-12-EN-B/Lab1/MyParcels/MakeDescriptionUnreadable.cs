using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.MyParcels
{
    public class MakeDescriptionUnreadable : BaseModifier
    {
        private readonly string _unreadableString;
        public MakeDescriptionUnreadable(IParcel parcel) : base(parcel)
        {
            char[] newChar = parcel.GetDescription().ToCharArray();
            for (var i = 1; i < parcel.GetDescription().Length; i+=2)
            {
                newChar[i] = '_';
            }
            _unreadableString = new String(newChar);
        }

        public override float Weight => _parcel.Weight;

        public override DateTime DeliveryDate => _parcel.DeliveryDate;

        public override string Name => _parcel.Name;

        public override string GetDescription() => _unreadableString;

        public override float GetCubature() => _parcel.GetCubature();

        public override string ToString() => _parcel.ToString();
    }
}
