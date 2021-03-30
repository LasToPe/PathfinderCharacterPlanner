using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Strategist : Archetype
    {
        public Strategist(Classes.Cavalier cavalier)
        {
            Name = "Strategist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Tactician",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician },
                },
                new ArchetypeAbility
                {
                    Name = "Drill Instructor",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Tactical Advantage",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterBanner },
                },
                new ArchetypeAbility
                {
                    Name = "Strategic Supremacy",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.BonusFeat18 },
                }
            };
        }
    }
}
