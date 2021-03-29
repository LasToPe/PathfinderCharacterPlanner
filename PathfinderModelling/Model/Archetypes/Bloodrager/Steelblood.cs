using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class Steelblood : Archetype
    {
        public Steelblood(Classes.Bloodrager bloodrager)
        {
            Name = "Steelblood";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Indomitable Stance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Armored Swiftness",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.UncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Armor Training",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.ImprovedUncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Blood Deflection",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility>(bloodrager.ClassAbilities.Where(a => a.Name.Contains("Damage Reduction"))),
                }
            };
        }
    }
}
