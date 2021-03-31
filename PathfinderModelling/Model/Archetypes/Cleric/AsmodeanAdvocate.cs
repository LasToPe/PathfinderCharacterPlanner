using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class AsmodeanAdvocate : Archetype
    {
        public AsmodeanAdvocate(Classes.Cleric cleric)
        {
            Name = "Asmodean Advocate";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Pact-Bound",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    Name = "Serpent",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Devil in the Details",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Shoulder Devil",
                    Level = 8,
                }
            };
        }
    }
}
