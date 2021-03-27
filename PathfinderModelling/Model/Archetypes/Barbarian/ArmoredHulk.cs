using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class ArmoredHulk : Archetype
    {
        public ArmoredHulk(Classes.Barbarian barbarian)
        {
            Name = "Armored Hulk";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Indomitable Stance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
                new ArchetypeAbility
                {
                    Name = "Armored Swiftness",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Improved Armored Swiftness",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Resilience of Steel"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
