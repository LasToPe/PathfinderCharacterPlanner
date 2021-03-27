using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class Occultist :  Archetype
    {
        public Occultist(Classes.Arcanist arcanist)
        {
            Name = "Occultist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Planar Spells",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Conjurer's Focus",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1 }
                },
                new ArchetypeAbility
                {
                    Name = "Planar Contact",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit7 }
                },
                new ArchetypeAbility
                {
                    Name = "Perfect Summoner",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.MagicalSupremacy }
                }
            };
        }
    }
}
