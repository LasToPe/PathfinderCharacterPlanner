using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class BrownFurTransmuter : Archetype
    {
        public BrownFurTransmuter(Classes.Arcanist arcanist)
        {
            Name = "Brown-Fur Transmuter";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Powerful Change",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit3 }
                },
                new ArchetypeAbility
                {
                    Name = "Share Transmutation",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit9 }
                },
                new ArchetypeAbility
                {
                    Name = "Transmutation Supremacy",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.MagicalSupremacy }
                }
            };
        }
    }
}
