using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class Exemplar : Archetype
    {
        public Exemplar(Classes.Brawler brawler)
        {
            Name = "Exemplar";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Call to Arms",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Unarmed Strike"))) { brawler.CloseWeaponMastery }
                },
                new ArchetypeAbility
                {
                    Name = "Inspiring Prowess",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Maneuver Training") || a.Name.Contains("AC Bonus"))),
                },
                new ArchetypeAbility
                {
                    Name = "Field Instruction",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Brawler's Strike")))
                }
            };
        }
    }
}
