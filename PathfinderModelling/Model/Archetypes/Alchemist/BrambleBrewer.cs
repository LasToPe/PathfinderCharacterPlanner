using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class BrambleBrewer : Archetype
    {
        public BrambleBrewer(Classes.Alchemist alchemist)
        {
            Name = "Bramble Brewer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Briar Bombs",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery2 }
                },
                new ArchetypeAbility
                {
                    Name = "Dendrite Mutagen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Grand Discovery",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.GrandDiscovery }
                },
            };
        }
    }
}
