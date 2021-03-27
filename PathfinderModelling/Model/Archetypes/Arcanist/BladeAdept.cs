using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class BladeAdept : Archetype
    {
        public BladeAdept(Classes.Arcanist arcanist)
        {
            Name = "Blade Adept";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Sword Bond",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1, arcanist.ArcanistExploit9 }
                },
                new ArchetypeAbility
                {
                    Name = "Sentient Sword",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit3 }
                },
                new ArchetypeAbility
                {
                    Name = "Adept Exploits",
                    Level = 1,
                }
            };
        }
    }
}
