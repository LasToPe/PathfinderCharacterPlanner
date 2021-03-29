using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class CircuitJudge : Archetype
    {
        public CircuitJudge(Classes.Cavalier cavalier)
        {
            Name = "Circuit Judge";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Circuit",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician, cavalier.GreaterTactician, cavalier.MasterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Double Jeopardy",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.DemandingChallenge },
                }
            };

            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Challenge"))
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Sentence {Math.Round(0.667 * a.Level + 1.33)}/day",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
