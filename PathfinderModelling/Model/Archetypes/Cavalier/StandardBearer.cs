using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class StandardBearer : Archetype
    {
        public StandardBearer(Classes.Cavalier cavalier)
        {
            Name = "Standard Bearer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Banner",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Mount",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Banner of Solace",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Awesome Pennon",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };
        }
    }
}
