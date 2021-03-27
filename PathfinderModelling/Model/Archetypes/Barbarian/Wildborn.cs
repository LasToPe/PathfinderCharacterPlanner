using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class Wildborn : Archetype
    {
        public Wildborn(Classes.Barbarian barbarian)
        {
            Name = "Wildborn";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Illiteracy",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Inexhaustible",
                    Level = 7,
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Live Off the Land"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            var levels = new[] { 4, 10, 16 };
            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Rage Power") && levels.Contains(a.Level))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Rage Power / Bonus Feat",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
