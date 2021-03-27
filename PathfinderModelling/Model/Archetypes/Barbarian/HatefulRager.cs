using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class HatefulRager : Archetype
    {
        public HatefulRager(Classes.Barbarian barbarian)
        {
            Name = "Hateful Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Reduced Rage",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Favored Enemy 1",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower2 }
                },
                new ArchetypeAbility
                {
                    Name = "Favored Enemy 2",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower8 }
                },
                new ArchetypeAbility
                {
                    Name = "Favored Enemy 3",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower14 }
                },
                new ArchetypeAbility
                {
                    Name = "Favored Enemy 4",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower20 }
                },
                new ArchetypeAbility
                {
                    Name = "Feed the Rage",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Amplified by Hate",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense3 }
                }
            };
        }
    }
}
