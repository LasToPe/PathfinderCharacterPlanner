using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class GunChemist : Archetype
    {
        public GunChemist(Classes.Alchemist alchemist)
        {
            Name = "Gun Chemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Gunsmith",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion, alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = "Gun Chemist Discoveries",
                    Level = 2
                },
                new ArchetypeAbility
                {
                    Name = "Cartridge Savant +1",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6, alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Cartridge Savant +2",
                    Level = 5,
                },
                new ArchetypeAbility
                {
                    Name = "Cartridge Savant +3",
                    Level = 8,
                },
                new ArchetypeAbility
                {
                    Name = "Cartridge Savant +4",
                    Level = 11,
                },
                new ArchetypeAbility
                {
                    Name = "Cartridge Savant +5",
                    Level = 14,
                },
                new ArchetypeAbility
                {
                    Name = "Cartridge Savant +6",
                    Level = 17,
                },
                new ArchetypeAbility
                {
                    Name = "Cartridge Savant +7",
                    Level = 20,
                },
                new ArchetypeAbility
                {
                    Name = "Repeat Fire",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                }
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Bomb", "Alchemical Ordnance"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
