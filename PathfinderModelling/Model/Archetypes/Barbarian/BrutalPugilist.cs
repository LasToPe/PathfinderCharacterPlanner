using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class BrutalPugilist : Archetype
    {
        public BrutalPugilist(Classes.Barbarian barbarian)
        {
            Name = "Brutal Pugilist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Savage Grapple",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Improved Savage Grapple",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense +", "Pit Fighter "),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
