using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class Appeaser : Archetype
    {
        public Appeaser(Classes.Cleric cleric)
        {
            Name = "Appeaser";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Aura",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Aura },
                },
                new ArchetypeAbility
                {
                    Name = "Divine Apologist",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Mollified Domain",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                }
            };

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Channel Energy", "Channel Utility"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
