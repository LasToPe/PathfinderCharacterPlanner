using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class ElementalKin : Archetype
    {
        public ElementalKin(Classes.Barbarian barbarian)
        {
            Name = "Elemental Kin";
            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Elemental Fury"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
