using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class WhiteMage : Archetype
    {
        public WhiteMage(Classes.Arcanist arcanist)
        {
            Name = "White Mage";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Spontaneous Healing",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1, arcanist.ArcanistExploit9 }
                }
            };
        }
    }
}
