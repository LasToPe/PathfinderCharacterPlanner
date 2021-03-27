using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class ElementalMaster : Archetype
    {
        public ElementalMaster(Classes.Arcanist arcanist)
        {
            Name = "Elemental Master";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Elemental Focus",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1 }
                },
                new ArchetypeAbility
                {
                    Name = "Elemental Attack",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit3 }
                },
                new ArchetypeAbility
                {
                    Name = "Powerful Exploit",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit9 }
                },
                new ArchetypeAbility
                {
                    Name = "Greater Elemental Attack",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit11 }
                },
                new ArchetypeAbility
                {
                    Name = "Elemental Movement",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit15 }
                },
            };
        }
    }
}
