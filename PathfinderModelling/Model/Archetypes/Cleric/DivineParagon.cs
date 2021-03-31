using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class DivineParagon : Archetype
    {
        public DivineParagon(Classes.Cleric cleric)
        {
            Name = "Divine Paragon";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Devoted Domain",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    Name = "Divine Brand",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Aura },
                }
            };
        }
    }
}
