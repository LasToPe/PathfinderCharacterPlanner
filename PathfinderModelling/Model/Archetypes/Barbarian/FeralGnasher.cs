using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class FeralGnasher : Archetype
    {
        public FeralGnasher(Classes.Barbarian barbarian)
        {
            Name = "Feral Gnasher";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Savage Bite",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
                new ArchetypeAbility
                {
                    Name = "Impromptu Armament",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower2 }
                },
                new ArchetypeAbility
                {
                    Name = "Lockjaw",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense1 }
                },
                new ArchetypeAbility
                {
                    Name = "Improvised Weapon Mastery",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Improved Lockjaw",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense2 }
                },
                new ArchetypeAbility
                {
                    Name = "Greater Lockjaw",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense3, barbarian.TrapSense5 }
                },
                new ArchetypeAbility
                {
                    Name = "Wicked Improvisation",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense4 }
                },
                new ArchetypeAbility
                {
                    Name = "Trap Sense +1",
                    Level = barbarian.TrapSense6.Level,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense6 }
                }
            };
        }
    }
}
