using System;
using Lab1.MyParcels;

namespace Lab1
{
    public static class ParcelsManipulator
    {
        public static IParcel ChangeParcelWeight(IParcel parcel, float weight)
        {
            return new ChangeParcelWeight(parcel, weight);
        }

        public static IParcel ChangeParcelCubature(IParcel parcel, float cubature)
        {
            return new ChangeParcelCubature(parcel, cubature);
        }
    
        public static IParcel MakeParcelFragile(IParcel parcel, FragilityType fr)
        {
            return new MakeParcelFragile(parcel, fr);
        }

        public static IParcel MakeParcelExpress(IParcel parcel, int daysDecrease)
        {
            return new MakeParcelExpress(parcel, daysDecrease);
        }
    
        public static IParcel SetParcelAsForgotten(IParcel parcel)
        {
            return new SetParcelAsForgotten(parcel);
        }

        public static IParcel MakeDescriptionUnreadable(IParcel parcel)
        {
            return new MakeDescriptionUnreadable(parcel);
        }

        public static IParcel TranslateDescription(IParcel parcel)
        {
            return new TranslateDescription(parcel);
        }
    }
}