using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class DrunkenRager : Archetype
    {
        public DrunkenRager(Classes.Barbarian barbarian)
        {
            Name = "Drunken Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Drunken Rage",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
                new ArchetypeAbility
                {
                    Name = "Staggering Evasion",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Improved Staggering Evasion",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Drunken Swing",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower12 }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Tolerance"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
