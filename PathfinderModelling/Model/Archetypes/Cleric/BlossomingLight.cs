using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class BlossomingLight : Archetype
    {
        public BlossomingLight(Classes.Cleric cleric)
        {
            Name = "Blossoming Light";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Promise of Faith",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Promise of Purity",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Luminous Font",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                }
            };

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
