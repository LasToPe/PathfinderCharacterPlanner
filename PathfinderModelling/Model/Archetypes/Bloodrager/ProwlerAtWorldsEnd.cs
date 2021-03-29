using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class ProwlerAtWorldsEnd : Archetype
    {
        public ProwlerAtWorldsEnd(Classes.Bloodrager bloodrager)
        {
            Name = "Prowler at World's End";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bloodline",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.Bloodline },
                },
                new ArchetypeAbility
                {
                    Name = "Spirit",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlinePower1, bloodrager.BloodlinePower8, bloodrager.BloodlinePower16 },
                },
                new ArchetypeAbility
                {
                    Name = "Bloodline Power",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlineFeat9 },
                },
                new ArchetypeAbility
                {
                    Name = "Bloodline Power",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlineFeat15 },
                },
                new ArchetypeAbility
                {
                    Name = "Chosen of the Spirits",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.GreaterBloodrage, bloodrager.MightyBloodrage },
                },
                new ArchetypeAbility
                {
                    Name = "Shapeshifted Spellcasting",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlineFeat12 },
                }
            };
        }
    }
}
