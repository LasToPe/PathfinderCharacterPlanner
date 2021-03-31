using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class CrashingWave : Archetype
    {
        public CrashingWave(Classes.Cleric cleric)
        {
            Name = "Crashing Wave";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Sworn to the Sea",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Speech of the Sea",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Spontaneous Casting",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.SpontaneousCasting },
                }
            };

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Channel Energy", "Balanced Channel"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
