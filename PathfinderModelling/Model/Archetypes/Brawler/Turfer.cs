using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class Turfer : Archetype
    {
        public Turfer(Classes.Brawler brawler)
        {
            Name = "Turfer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Terrain Mastery",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Knockout"))),
                }
            };

            ArchetypeAbilities.AddRange(brawler.ClassAbilities
                .Where(a => a.Name.Contains("Maneuver Training"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Favored Turf",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
