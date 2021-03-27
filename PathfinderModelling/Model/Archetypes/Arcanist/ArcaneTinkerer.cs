using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class ArcaneTinkerer : Archetype
    {
        public ArcaneTinkerer(Classes.Arcanist arcanist)
        {
            Name = "Arcane Tinkerer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Manipulate Construct",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1 }
                },
                new ArchetypeAbility
                {
                    Name = "Break Magic Immunity 1",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit5 }
                },
                new ArchetypeAbility
                {
                    Name = "Break Magic Immunity 2",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit11 }
                },
            };
        }
    }
}
