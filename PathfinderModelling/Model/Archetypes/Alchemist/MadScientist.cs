using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class MadScientist : Archetype
    {
        public MadScientist(Classes.Alchemist alchemist)
        {
            Name = "Mad Scientist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = alchemist.Alchemy.Name,
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Alchemy }
                },
                new ArchetypeAbility
                {
                    Name = "Mad Genius",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery2 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Mutagen.Name,
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Mad Mutagen",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery4 }
                },
            };
        }
    }
}
