using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class WastelandChronicler : Archetype
    {
        public WastelandChronicler(Classes.Bard bard)
        {
            Name = "Wasteland Chronicler";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Wasteland Knowledge",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Wasteland Specialist 1",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence"))),
                }
            };

            for (int i = 8; i <= 20; i += 5)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Wasteland Specialist {0.2 * i + 0.4}",
                    Level = i,
                });
        }
    }
}
