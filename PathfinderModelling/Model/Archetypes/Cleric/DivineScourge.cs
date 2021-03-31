using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class DivineScourge : Archetype
    {
        public DivineScourge(Classes.Cleric cleric)
        {
            Name = "Divine Scourge";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Curser",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    // Divine Hexes
                    ReplacedAbilities = new List<ClassAbility>(cleric.ClassAbilities.Where(a => a.Name.Contains("Channel Energy"))),
                }
            };

            for (int i = 3; i <= 20; i += 4)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = "Divine Hex",
                    Level = i,
                });
        }
    }
}
