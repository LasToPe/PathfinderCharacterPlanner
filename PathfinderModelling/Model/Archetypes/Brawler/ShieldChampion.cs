using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class ShieldChampion : Archetype
    {
        public ShieldChampion(Classes.Brawler brawler)
        {
            Name = "Shield Champion";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Throw Shield",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { brawler.ManeuverTraining3, brawler.ManeuverTraining7, brawler.ManeuverTraining11 },
                },
                new ArchetypeAbility
                {
                    Name = "Champion Defense",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { brawler.ManeuverTraining15, brawler.ManeuverTraining19 },
                },
                new ArchetypeAbility
                {
                    Name = "Returning Shield",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Brawler's Strike"))),
                }
            };
        }
    }
}
