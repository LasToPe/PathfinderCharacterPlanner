using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Horticulturist : Archetype
    {
        public Horticulturist(Classes.Alchemist alchemist)
        {
            Name = "Horticulturist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Seed Extract",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen, alchemist.Discovery2 }
                },
                new ArchetypeAbility
                {
                    Name = "Plant Voice +2",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6, alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Plant Voice (Speak With Plants)",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Plant Familiar",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery4 }
                },
                new ArchetypeAbility
                {
                    Name = "Fury of Nature",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PersistentMutagen }
                }
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility 
                { 
                    Name = a.Name.Replace("Bomb", "Herbal Bomb"), 
                    Level = a.Level, 
                    ReplacedAbilities = new List<ClassAbility> { a } 
                }));
        }
    }
}
