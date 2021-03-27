using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class BrutishSwamper : Archetype
    {
        public BrutishSwamper(Classes.Barbarian barbarian)
        {
            Name = "Brutish Swamper";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Marsh March",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
                new ArchetypeAbility
                {
                    Name = "Home",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge, barbarian.ImprovedUncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Wrastlin'",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower6 }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Stubborn -{a.Level / 3 * 2}",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
