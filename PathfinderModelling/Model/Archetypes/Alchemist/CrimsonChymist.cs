using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class CrimsonChymist : Archetype
    {
        public CrimsonChymist(Classes.Alchemist alchemist)
        {
            Name = "Crimson Chymist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Crimson Discoveries",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Mantis Mutagen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                }
            };
        }
    }
}
