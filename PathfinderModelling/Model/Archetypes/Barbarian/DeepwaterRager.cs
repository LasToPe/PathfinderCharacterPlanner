using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class DeepwaterRager : Archetype
    {
        public DeepwaterRager(Classes.Barbarian barbarian)
        {
            Name = "Deepwater Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Strong Lungs",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement  }
                },
                new ArchetypeAbility
                {
                    Name = "Spiraling Charge",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Disorienting Grapple",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Crushing Grapple",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.IndomitableWill }
                },
                new ArchetypeAbility
                {
                    Name = "Full Lungs",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TirelessRage }
                }
            };
        }
    }
}
