using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Perfumer : Archetype
    {
        public Perfumer(Classes.Alchemist alchemist)
        {
            Name = "Perfumer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Atomized Extracts",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion, alchemist.Extracts }
                },
                new ArchetypeAbility
                {
                    Name = "Pheromones",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Persistent Pheromones",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PersistentMutagen }
                }
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Bomb", "Effervescent Bombs").Replace("d6", "d4"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
