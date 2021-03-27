using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class WildRager : Archetype
    {
        public WildRager(Classes.Barbarian barbarian)
        {
            Name = "Wild Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Uncontrolled Rage",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage },
                },
                new ArchetypeAbility
                {
                    Name = "Wild Fighting",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Rage Conversion",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge },
                }
            };
        }
    }
}
