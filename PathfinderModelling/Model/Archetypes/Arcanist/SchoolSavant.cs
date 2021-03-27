using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class SchoolSavant : Archetype
    {
        public SchoolSavant(Classes.Arcanist arcanist)
        {
            Name = "School Savant";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "School Focus",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1, arcanist.ArcanistExploit3, arcanist.ArcanistExploit7 }
                }
            };
        }
    }
}
