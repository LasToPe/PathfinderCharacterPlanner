using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class GloomChymist : Archetype
    {
        public GloomChymist(Classes.Alchemist alchemist)
        {
            Name = "Gloom Chymist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Umbral Gloom",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Poison")))
                }
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Bomb", "Gloom"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
