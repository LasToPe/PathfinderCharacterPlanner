using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class DragonHerald : Archetype
    {
        public DragonHerald(Classes.Bard bard)
        {
            Name = "Dragon Herald";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Dragon Patron",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Coat of Arms",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Dragon Voice",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Diplomatic Immunity",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong, bard.Fascinate },
                },
                new ArchetypeAbility
                {
                    Name = "Diplomatic Protection",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence")))
                },
                new ArchetypeAbility
                {
                    Name = "Rebuke Foes",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { bard.SoothingPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Retreat to Lair",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireHeroics },
                },
                new ArchetypeAbility
                {
                    Name = "Extol Glory",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.JackOfAllTrades },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Lore Master"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Lore Master", "Master of Persuasion"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
