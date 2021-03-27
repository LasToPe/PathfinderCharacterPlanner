using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class ShoantiBurnRider : Archetype
    {
        public ShoantiBurnRider(Classes.Barbarian barbarian)
        {
            Name = "Shoanti Burn Rider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Flame Runner",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Cinder Sight",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Cinder Dance",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense1, barbarian.TrapSense2, barbarian.TrapSense3, barbarian.TrapSense4, barbarian.TrapSense5, barbarian.TrapSense6 },
                },
                new ArchetypeAbility
                {
                    Name = "Mount",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower4, barbarian.RagePower8, barbarian.RagePower12, barbarian.RagePower16 },
                },
                new ArchetypeAbility
                {
                    Name = "Give Me Fire",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge },
                }
            };
        }
    }
}
