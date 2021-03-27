using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class PrimalHunter : Archetype
    {
        public PrimalHunter(Classes.Barbarian barbarian)
        {
            Name = "Primal Hunter";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Exceptional Pull",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
                new ArchetypeAbility
                {
                    Name = "Focused Rage",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage }
                }
            };
        }
    }
}
