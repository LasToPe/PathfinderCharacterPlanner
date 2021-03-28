using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Detective : Archetype
    {
        public Detective(Classes.Bard bard)
        {
            Name = "Detective";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "True Confession",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireGreatness },
                },
                new ArchetypeAbility
                {
                    Name = "Show Yourselves",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireHeroics },
                },
                new ArchetypeAbility
                {
                    Name = "Eye for Detail",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Arcane Insight",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Inspire Courage"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Inspire Courage", "Careful Teamwork"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Arcane Investigation",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
