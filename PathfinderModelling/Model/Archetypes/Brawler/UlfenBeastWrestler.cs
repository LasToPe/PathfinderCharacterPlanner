using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class UlfenBeastWrestler : Archetype
    {
        public UlfenBeastWrestler(Classes.Brawler brawler)
        {
            Name = "Ulfen Beast-Wrestler";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Beast Defenses",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("AC Bonus"))),
                }
            };

            ArchetypeAbilities.AddRange(brawler.ClassAbilities
                .Where(a => a.Name.Contains("Maneuver Training"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Beast Training",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
