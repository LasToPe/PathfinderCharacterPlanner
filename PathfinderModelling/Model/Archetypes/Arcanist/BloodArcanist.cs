using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class BloodArcanist : Archetype
    {
        public BloodArcanist(Classes.Arcanist arcanist)
        {
            Name = "Blood Arcanist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bloodline",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Bloodline Power",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1 }
                },
                new ArchetypeAbility
                {
                    Name = "Bloodline Power",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit3 }
                },
                new ArchetypeAbility
                {
                    Name = "Bloodline Power",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit9 }
                },
                new ArchetypeAbility
                {
                    Name = "Bloodline Power",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit15 }
                },
                new ArchetypeAbility
                {
                    Name = "Bloodline Power",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.MagicalSupremacy }
                },
            };
        }
    }
}
