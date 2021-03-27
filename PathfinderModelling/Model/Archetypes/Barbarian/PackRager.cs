using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class PackRager : Archetype
    {
        public PackRager(Classes.Barbarian barbarian)
        {
            Name = "Pack Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>();

            var levels = new[] { 2, 6, 10, 14, 18 };
            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Rage Power") && levels.Contains(a.Level))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Bonus Teamwork Feat",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Damage Reduction", "Raging Tactician").Replace("/-", ""),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
