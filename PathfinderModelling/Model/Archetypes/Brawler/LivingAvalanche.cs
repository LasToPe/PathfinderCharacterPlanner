using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class LivingAvalanche : Archetype
    {
        public LivingAvalanche(Classes.Brawler brawler)
        {
            Name = "Living Avalanche";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Earth Discipline",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BonusCombatFeat2, brawler.BonusCombatFeat5 },
                },
                new ArchetypeAbility
                {
                    Name = "Avalanche",
                    Level = 16,
                    ReplacedAbilities = new List<ClassAbility> { brawler.AwesomeBlow },
                },
                new ArchetypeAbility
                {
                    Name = "Improved Avalanche",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { brawler.ImprovedAwesomeBlow },
                }
            };

            ArchetypeAbilities.AddRange(brawler.ClassAbilities
                .Where(a => a.Name.Contains("Maneuver Training"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Maneuver Training", "Landslide"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(brawler.ClassAbilities
                .Where(a => a.Name.Contains("AC Bonus"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("AC Bonus +", "Unyielding ") + "/adamantine",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                })); 
        }
    }
}
