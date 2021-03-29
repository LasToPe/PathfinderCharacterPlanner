using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class SymbolStriker : Archetype
    {
        public SymbolStriker(Classes.Bloodrager bloodrager)
        {
            Name = "Symbol Striker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Rune Training",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Weapon Rune",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlineFeat6, bloodrager.BloodlineFeat12, bloodrager.BloodlineFeat18 },
                },
                new ArchetypeAbility
                {
                    Name = "Rune Trap",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlineFeat9 },
                }
            };
        }
    }
}
