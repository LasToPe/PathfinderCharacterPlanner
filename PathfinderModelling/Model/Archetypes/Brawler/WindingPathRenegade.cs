using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class WindingPathRenegade : Archetype
    {
        public WindingPathRenegade(Classes.Brawler brawler)
        {
            Name = "Winding Path Renegade";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "School Focus",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BonusCombatFeat2, brawler.BonusCombatFeat8, brawler.BonusCombatFeat14 },
                },
                new ArchetypeAbility
                {
                    Name = "Monk Moves",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("AC Bonus"))),
                }
            };
        }
    }
}
