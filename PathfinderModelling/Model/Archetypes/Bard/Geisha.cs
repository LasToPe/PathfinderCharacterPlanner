using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Geisha : Archetype
    {
        public Geisha(Classes.Bard bard)
        {
            Name = "Geisha";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Tea Ceremony",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Geisha Knowledge",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Scribe Scroll",
                    Level = 1,
                }
            };
        }
    }
}
