using System;
using System.Collections.Generic;
using Construction.Implementation;

namespace Construction
{
    class Program
    {
        static void Main(string[] args)
        {
            var amounts = new List<int>(){10, 15, 20};

            Console.WriteLine("Budimex");
            SupplyChain(amounts, new Budimex());

            Console.WriteLine("Strabag");
            SupplyChain(amounts, new Strabag());

            Console.WriteLine("Torpol");
            SupplyChain(amounts, new Torpol());
            
            Console.WriteLine("Mixed");
            Build(new ConcreteMaterial(), new CisternTransporter(), new ExcavatorEquipment());
        }

        private static void SupplyChain(List<int> amounts, BaseImplementation baseImplementation)
        {
            foreach (var amount in amounts)
                Build(baseImplementation.MakeMaterial(amount), baseImplementation.MakeTransporter(), baseImplementation.MakeEquipment());
        }

        private static void Build(Material material, Transporter transporter, Equipement equipement)
        {
            Console.WriteLine($"{material.Amount} tons of {material.GetMaterialType()}");
            Console.WriteLine($"Will be transported by {transporter.GetName()} on {transporter.Wheels} wheels");
            Console.WriteLine($"Load percentage: {transporter.LoadPercentage(material)}");
            Console.WriteLine($"{equipement.GetName()} {(equipement.CanApply(material)?"can":"CANNOT")} apply the material\n");
        }
    }
}
