namespace Construction.Implementation
{
    public class AsphaltMaterial : Material
    {
        public override MaterialType GetMaterialType()
        {
            return MaterialType.Asphalt;
        }

        public AsphaltMaterial(double amount) : base(amount) { }
        public AsphaltMaterial() : base(0) { }
    }
}
