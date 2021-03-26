using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class Fearmonger : Archetype
    {
        public Fearmonger(Classes.Antipaladin antipaladin)
        {
            Name = "Fearmonger";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Feed on Fear",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.TouchOfCorruption }
                },
            };
            ArchetypeAbilities.AddRange(antipaladin.ClassAbilities
                .Where(a => a.Name == "Cruelty")
                .Select(a => new ArchetypeAbility
                {
                    Name = "Frightening Cruelty",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
