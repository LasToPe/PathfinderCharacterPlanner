using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Mixologist : Archetype
    {
        public Mixologist(Classes.Alchemist alchemist)
        {
            Name = "Mixologist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Alcoholic Alchemy",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Alchemy, alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Brew Potion",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion }
                },
                new ArchetypeAbility
                {
                    Name = "Alcoholic Bombs",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery2 }
                },
                new ArchetypeAbility
                {
                    Name = "Mixologist Master",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PersistentMutagen }
                },
            };
            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Poison Resistance"))
                .Select(a => new ArchetypeAbility 
                { 
                    Name = a.Name.Replace("Poison", "Alcoholic"), 
                    Level = a.Level, 
                    ReplacedAbilities = new List<ClassAbility> { a } 
                }));
        }
    }
}
