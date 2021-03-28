using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Songhealer : Archetype
    {
        public Songhealer(Classes.Bard bard)
        {
            Name = "Songhealer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Enhance Healing",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance")))
                },
                new ArchetypeAbility
                {
                    Name = "Healing Performance",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { bard.FrighteningTune },
                },
                new ArchetypeAbility
                {
                    Name = "Funereal Ballad",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { bard.DeadlyPerformance },
                }
            };
        }
    }
}
