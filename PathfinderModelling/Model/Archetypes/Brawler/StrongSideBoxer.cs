using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class StrongSideBoxer : Archetype
    {
        public StrongSideBoxer(Classes.Brawler brawler)
        {
            Name = "Strong-Side Boxer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Shield-Hand",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("AC Bonus"))),
                },
                new ArchetypeAbility
                {
                    Name = "Strong-Side Fist",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Maneuver Training"))),
                },
                new ArchetypeAbility
                {
                    Name = "Lead Leg",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { brawler.CloseWeaponMastery },
                }
            };
        }
    }
}
