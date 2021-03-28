using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class RingleaderUI : Archetype
    {
        public RingleaderUI(Classes.Bard bard)
        {
            Name = "Ringleader (UI)";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    // Inspire Competence
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom, bard.FrighteningTune },
                },
                new ArchetypeAbility
                {
                    Name = "Inspired Plan",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))),
                },
                new ArchetypeAbility
                {
                    Name = "Hidden Plans",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Inspire Competence"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Lore Master"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Lore Master", "Prepared"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
