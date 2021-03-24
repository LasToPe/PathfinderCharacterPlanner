using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class BogbornAlchemist : Archetype
    {
        public BogbornAlchemist(Classes.Alchemist alchemist)
        {
            Name = "Bogborn Alchemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Amphibious Mutagen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.ThrowAnything }
                }
            };
        }
    }
}
