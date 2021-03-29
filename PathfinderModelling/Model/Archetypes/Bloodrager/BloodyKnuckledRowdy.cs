using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class BloodyKnuckledRowdy : Archetype
    {
        public BloodyKnuckledRowdy(Classes.Bloodrager bloodrager)
        {
            Name = "Bloody-Knuckled Rowdy";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bloody Knuckles",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bloodrager.ClassAbilities.Where(a => a.Name.Contains("Damage Reduction"))),
                },
                new ArchetypeAbility
                {
                    Name = "Reduced Spells Known",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Pugilist",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Combat Style Student",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.UncannyDodge, bloodrager.ImprovedUncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Hand-to-Hand Training",
                    Level = 3,
                }
            };
        }
    }
}
