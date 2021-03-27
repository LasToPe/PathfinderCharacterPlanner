using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class Mooncursed : Archetype
    {
        public Mooncursed(Classes.Barbarian barbarian)
        {
            Name = "Mooncursed";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Shifting Rage",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage }
                },
                new ArchetypeAbility
                {
                    Name = "Hybrid Rage",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Greater Shifting Rage",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.GreaterRage }
                },
                new ArchetypeAbility
                {
                    Name = "Mighty Shifting Rage",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.MightyRage }
                }
            };
        }
    }
}
