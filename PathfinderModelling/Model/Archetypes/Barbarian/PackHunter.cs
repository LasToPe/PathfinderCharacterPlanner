using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class PackHunter : Archetype
    {
        public PackHunter(Classes.Barbarian barbarian)
        {
            Name = "Pack Hunter";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Sympathetic Rage",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower6 }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Rage Power") && a.Level != 6)
                .Select(a => new ArchetypeAbility
                {
                    Name = "Rage Power / Teamwork Feat",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "In and Out"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
