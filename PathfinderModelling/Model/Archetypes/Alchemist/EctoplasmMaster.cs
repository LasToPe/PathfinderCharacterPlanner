using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class EctoplasmMaster : Archetype
    {
        public EctoplasmMaster(Classes.Alchemist alchemist)
        {
            Name = "Ectoplasm Master";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Ectoplasmic Extracts",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion }
                },
                new ArchetypeAbility
                {
                    Name = "Ectoplasm Master Discoveries",
                    Level = 2
                }
            };
        }
    }
}
