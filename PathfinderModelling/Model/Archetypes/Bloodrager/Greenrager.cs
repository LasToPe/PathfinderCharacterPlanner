using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class Greenrager : Archetype
    {
        public Greenrager(Classes.Bloodrager bloodrager)
        {
            Name = "Greenrager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Unfettered Fury",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodSanctuary },
                },
                new ArchetypeAbility
                {
                    Name = "Summoning Rager",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlineFeat6 },
                },
                new ArchetypeAbility
                {
                    Name = "Furious Summoning",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlineFeat9 },
                }
            };
        }
    }
}
