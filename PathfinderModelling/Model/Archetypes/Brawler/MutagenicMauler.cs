using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class MutagenicMauler : Archetype
    {
        public MutagenicMauler(Classes.Brawler brawler)
        {
            Name = "Mutagenic Mauler";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Mutagen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.MartialFlexibility },
                },
                new ArchetypeAbility
                {
                    Name = "Beastmorph",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("AC Bonus"))),
                }
            };
        }
    }
}
