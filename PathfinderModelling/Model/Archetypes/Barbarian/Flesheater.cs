using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class Flesheater : Archetype
    {
        public Flesheater(Classes.Barbarian barbarian)
        {
            Name = "Flesheater";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Rage",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage }
                },
                new ArchetypeAbility
                {
                    Name = "One Flesh",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge, barbarian.ImprovedUncannyDodge, barbarian.RagePower2, barbarian.RagePower8 }
                },
                new ArchetypeAbility
                {
                    Name = "Unbound Rage",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.GreaterRage }
                },
                new ArchetypeAbility
                {
                    Name = "Feast",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower14 }
                },
                new ArchetypeAbility
                {
                    Name = "Unbound Form",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.MightyRage }
                }
            };
        }
    }
}
