using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class FeyCourtier : Archetype
    {
        public FeyCourtier(Classes.Bard bard)
        {
            Name = "Fey Courtier";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Scorn of the Wilds",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom, bard.FrighteningTune },
                },
                new ArchetypeAbility
                {
                    Name = "Stone Dance",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireHeroics },
                },
                new ArchetypeAbility
                {
                    Name = "Fey Contacts",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))),
                },
                new ArchetypeAbility
                {
                    Name = "Summon Fey Allies",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence"))),
                }
            };
        }
    }
}
