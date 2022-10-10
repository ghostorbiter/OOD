namespace Construction.Implementation
{
    public abstract class BaseImplementation
    {
        public abstract Material MakeMaterial(double amount);
        public abstract Transporter MakeTransporter();
        public abstract Equipement MakeEquipment();
    }
}