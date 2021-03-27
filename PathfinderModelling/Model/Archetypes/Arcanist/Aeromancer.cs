using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class Aeromancer : Archetype
    {
        public Aeromancer(Classes.Arcanist arcanist)
        {
            Name = "Aeromancer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Air Mastery",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1 }
                },
                new ArchetypeAbility
                {
                    Name = "Wind's Embrace",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit5 }
                },
                new ArchetypeAbility
                {
                    Name = "Rebuking Gale",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit11 }
                }
            };
        }
    }
}
