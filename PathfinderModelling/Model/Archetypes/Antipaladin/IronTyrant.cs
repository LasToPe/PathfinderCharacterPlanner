using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class IronTyrant :  Archetype
    {
        public IronTyrant(Classes.Antipaladin antipaladin)
        {
            Name = "Iron Tyrant";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Iron Fist",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.TouchOfCorruption }
                },
                new ArchetypeAbility
                {
                    Name = "Unstoppable",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.ChannelNegativeEnergy }
                },
                new ArchetypeAbility
                {
                    Name = "Fiendish Bond",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.FiendishBoon }
                }
            };

            ArchetypeAbilities.AddRange(antipaladin.ClassAbilities
                .Where(a => a.Name.Contains("Cruelty"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
