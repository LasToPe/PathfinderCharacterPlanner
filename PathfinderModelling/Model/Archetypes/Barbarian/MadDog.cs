using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class MadDog : Archetype
    {
        public MadDog(Classes.Barbarian barbarian)
        {
            Name = "Mad Dog";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "War Beast",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower2, barbarian.RagePower6, barbarian.RagePower10, barbarian.RagePower14, barbarian.RagePower18 }
                },
                new ArchetypeAbility
                {
                    Name = "Pack Tactics",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Rage",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage }
                },
                new ArchetypeAbility
                {
                    Name = "Ferocious Fetch",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Throat Cutter",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.IndomitableWill }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => a.Level < 17 ? new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level + 3,
                    ReplacedAbilities = new List<ClassAbility> { a }
                } : new ArchetypeAbility 
                { 
                    ReplacedAbilities = new List<ClassAbility> { a } 
                }));
        }
    }
}
