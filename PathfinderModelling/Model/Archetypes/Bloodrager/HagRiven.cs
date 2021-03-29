using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class HagRiven : Archetype
    {
        public HagRiven(Classes.Bloodrager bloodrager)
        {
            Name = "Hag-Riven";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Arcane Influence",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Claws of the Hag",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.FastMovement, bloodrager.UncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Sorcerous Claws",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.ImprovedUncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Hexing Claws",
                    Level = 10,
                }
            };

            ArchetypeAbilities.AddRange(bloodrager.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Scarred Hide +{Math.Round(0.33 * a.Level - 1.33)}",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
