using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class BattleDancer : Archetype
    {
        public BattleDancer(Classes.Brawler brawler)
        {
            Name = "Battle Dancer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Dancer's Cunning",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BrawlersCunning },
                },
                new ArchetypeAbility
                {
                    Name = "Rolling Flurry",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BrawlersFlurry2 },
                },
                new ArchetypeAbility
                {
                    Name = "Dancing Dodge",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("AC Bonus"))),
                }
            };

            ArchetypeAbilities.AddRange(brawler.ClassAbilities
                .Where(a => a.Name.Contains("Knockout"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Knockout", "Sparring Partners"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
