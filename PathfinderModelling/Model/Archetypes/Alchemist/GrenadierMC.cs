using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class GrenadierMC : Archetype
    {
        public GrenadierMC(Classes.Alchemist alchemist)
        {
            Name = "Grenadier [MC]";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Martial Weapon Proficiency",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion }
                },
                new ArchetypeAbility
                {
                    Name = "Alchemical Weapon",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6 }
                },
                new ArchetypeAbility
                {
                    Name = "Precise Bombs",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Directed Blast",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                },
                new ArchetypeAbility
                {
                    Name = "Staggering Blast",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                }
            };
        }
    }
}
