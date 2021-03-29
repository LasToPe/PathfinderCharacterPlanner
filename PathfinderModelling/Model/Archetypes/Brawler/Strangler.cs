using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class Strangler : Archetype
    {
        public Strangler(Classes.Brawler brawler)
        {
            Name = "Strangler";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Strangle +1d6",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Unarmed Strike") || a.Name.Contains("Brawler's Flurry"))),
                },
                new ArchetypeAbility
                {
                    Name = "Strangle +2d6",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Strangle +3d6",
                    Level = 8,
                },
                new ArchetypeAbility
                {
                    Name = "Strangle +4d6",
                    Level = 15,
                },
                new ArchetypeAbility
                {
                    Name = "Practiced Strangler",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("AC Bonus"))),
                },
                new ArchetypeAbility
                {
                    Name = "Neckbreaker",
                    Level = 16,
                    ReplacedAbilities = new List<ClassAbility> { brawler.AwesomeBlow, brawler.ImprovedAwesomeBlow },
                }
            };

            ArchetypeAbilities.AddRange(brawler.ClassAbilities
                .Where(a => a.Name.Contains("Knockout"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Knockout", "Sleeper Hold"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
