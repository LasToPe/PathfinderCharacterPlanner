using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class MagaambyanInitiate : Archetype
    {
        public MagaambyanInitiate(Classes.Arcanist arcanist)
        {
            Name = "Magaambyan Initiate";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Aura of Good",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Halcyon Spell Lore",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1, arcanist.ArcanistExploit9, arcanist.ArcanistExploit17 }
                },
                new ArchetypeAbility
                {
                    Name = "Spell Mastery",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit5 }
                }
            };
        }
    }
}
