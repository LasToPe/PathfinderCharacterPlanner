using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Emissary : Archetype
    {
        public Emissary(Classes.Cavalier cavalier)
        {
            Name = "Emissary";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "In or Out of the Saddle",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician },
                },
                new ArchetypeAbility
                {
                    Name = "Battlefield Agility",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Mounted Acrobatics",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Mounted Dervish",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterBanner },
                },
                new ArchetypeAbility
                {
                    Name = "Erratic Charge",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };
        }
    }
}
