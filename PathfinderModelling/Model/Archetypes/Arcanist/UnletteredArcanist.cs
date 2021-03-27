using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class UnletteredArcanist : Archetype
    {
        public UnletteredArcanist(Classes.Arcanist arcanist)
        {
            Name = "Unlettered Arcanist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Familiar",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Witch Spells",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.Spells }
                }
            };
        }
    }
}
