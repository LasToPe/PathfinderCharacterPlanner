using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class JungleRager : Archetype
    {
        public JungleRager(Classes.Barbarian barbarian)
        {
            Name = "Jungle Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Home Ground Advantage",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Home Ground Supremacy",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Jungle Endurance"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level + 1,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
