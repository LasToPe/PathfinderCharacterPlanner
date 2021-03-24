using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class InternalAlchemist : Archetype
    {
        public InternalAlchemist(Classes.Alchemist alchemist)
        {
            Name = "Internal Alchemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Breath Mastery",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feats",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Disease Resistance",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftAlchemy }
                },
                new ArchetypeAbility
                {
                    Name = "Uncanny Dodge",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                }
            };
        }
    }
}
