namespace Construction.Implementation
{
    public class ConcreteMaterial : Material
    {
        public override MaterialType GetMaterialType()
        {
            return MaterialType.Concrete;
        }

        public ConcreteMaterial(double amount) : base(amount) { }
        public ConcreteMaterial() : base(0) { }
    }
}
