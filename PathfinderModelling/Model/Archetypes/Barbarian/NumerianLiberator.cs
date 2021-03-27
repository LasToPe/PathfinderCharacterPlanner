using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class NumerianLiberator : Archetype
    {
        public NumerianLiberator(Classes.Barbarian barbarian)
        {
            Name = "Numerian Liberator";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Hard Hitter",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Disruptor",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Hide from Constructs",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.IndomitableWill }
                }
            };
        }
    }
}
