using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class RagingCannibal : Archetype
    {
        public RagingCannibal(Classes.Barbarian barbarian)
        {
            Name = "Raging Cannibal";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Animal Fury",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower2 }
                },
                new ArchetypeAbility
                {
                    Name = "Consume Vigor",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Intimidating Gouge",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense1, barbarian.TrapSense2, barbarian.TrapSense3, barbarian.TrapSense4, barbarian.TrapSense5, barbarian.TrapSense6 }
                },
                new ArchetypeAbility
                {
                    Name = "Feed from Fury",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Razor-Toothed Fury 1",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.DamageReduction1, barbarian.DamageReduction2, barbarian.DamageReduction3, barbarian.DamageReduction4, barbarian.DamageReduction5 }
                },
                new ArchetypeAbility
                {
                    Name = "Razor-Toothed Fury 2",
                    Level = 10,
                },
                new ArchetypeAbility
                {
                    Name = "Razor-Toothed Fury 3",
                    Level = 14,
                },
                new ArchetypeAbility
                {
                    Name = "Razor-Toothed Fury",
                    Level = 18,
                }
            };
        }
    }
}
