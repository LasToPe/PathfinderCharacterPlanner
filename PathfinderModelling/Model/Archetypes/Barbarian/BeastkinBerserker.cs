using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class BeastkinBerserker : Archetype
    {
        public BeastkinBerserker(Classes.Barbarian barbarian)
        {
            Name = "Beastkin Berserker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Savage Rapport",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
                new ArchetypeAbility
                {
                    Name = "Feral Transformation",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower4, barbarian.RagePower8, barbarian.RagePower12 }
                }
            };
        }
    }
}
