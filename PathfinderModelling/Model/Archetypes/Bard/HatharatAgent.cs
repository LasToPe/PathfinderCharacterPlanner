using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class HatharatAgent : Archetype
    {
        public HatharatAgent(Classes.Bard bard)
        {
            Name = "Hatharat Agent";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Called Favor",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Informed Persuasion",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Master of Manipulation",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                }
            };
        }
    }
}
