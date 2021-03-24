using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Interrogator : Archetype
    {
        public Interrogator(Classes.Alchemist alchemist)
        {
            Name = "Interrogator";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Injections",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Bomb")))
                },
                new ArchetypeAbility
                {
                    Name = "Serums",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen, alchemist.PersistentMutagen }
                }
            };
        }
    }
}
