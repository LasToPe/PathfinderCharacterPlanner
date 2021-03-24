using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class EnergyScientist : Archetype
    {
        public EnergyScientist(Classes.Alchemist alchemist)
        {
            Name = "Energy Scientist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 1d6",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion, alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 2d6",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 3d6",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 4d6",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 5d6",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 6d6",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 7d6",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 8d6",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 9d6",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = "Energy Bombs 10d6",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Limited Extracts",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Extracts },
                    Add = () => alchemist.LimitedExtracts(true),
                    Remove = () => alchemist.LimitedExtracts(false)
                },
                new ArchetypeAbility
                {
                    Name = "Attuned Resistance +2",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2 }
                },
                new ArchetypeAbility
                {
                    Name = "Attuned Resistance +3",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance4 }
                },
                new ArchetypeAbility
                {
                    Name = "Attuned Resistance +4",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6 }
                },
                new ArchetypeAbility
                {
                    Name = "Attuned Resistance (Planar Adaptation)",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Salvage Energy",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse, alchemist.SwiftPoisoning }
                },
            };
        }
    }
}
