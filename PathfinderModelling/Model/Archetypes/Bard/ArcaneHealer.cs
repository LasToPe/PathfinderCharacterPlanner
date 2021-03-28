using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class ArcaneHealer : Archetype
    {
        public ArcaneHealer(Classes.Bard bard)
        {
            Name = "Arcane Healer";
            ArchetypeAbilities = new List<ArchetypeAbility>();

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Channel Energy {0.25 * a.Level + 0.5}/day",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Lore Master"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Lore Master", "Inspiring Healing").Replace("/day", ""),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
