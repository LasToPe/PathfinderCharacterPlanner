using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class OenopionResearcher : Archetype
    {
        public OenopionResearcher(Classes.Alchemist alchemist)
        {
            Name = "Oenopion Researcher";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Experimental Mutagen",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Acid Resistance",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftAlchemy }
                }
            };
        }
    }
}
