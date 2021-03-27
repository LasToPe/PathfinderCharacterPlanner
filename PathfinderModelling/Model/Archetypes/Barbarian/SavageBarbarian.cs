using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class SavageBarbarian : Archetype
    {
        public SavageBarbarian(Classes.Barbarian barbarian)
        {
            Name = "Savage Barbarian";
            ArchetypeAbilities = new List<ArchetypeAbility>();

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Naked Courage"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Damage Reduction", "Natural Toughness +").Replace("/-", ""),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
