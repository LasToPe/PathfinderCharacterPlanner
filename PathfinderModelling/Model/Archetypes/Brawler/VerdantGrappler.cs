using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class VerdantGrappler : Archetype
    {
        public VerdantGrappler(Classes.Brawler brawler)
        {
            Name = "Verdant Grappler";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Green Grasp",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BonusCombatFeat2 },
                },
                new ArchetypeAbility
                {
                    Name = "Thorny Embrace",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { brawler.CloseWeaponMastery },
                },
                new ArchetypeAbility
                {
                    Name = "Phytological Anatomy",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BonusCombatFeat11 },
                }
            };
        }
    }
}
