using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class Spelleater : Archetype
    {
        public Spelleater(Classes.Bloodrager bloodrager)
        {
            Name = "Spelleater";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Blood of Life 1",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.UncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Spell Eating",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.ImprovedUncannyDodge },
                }
            };

            ArchetypeAbilities.AddRange(bloodrager.ClassAbilities
                .Where(a => a.Name.Contains("Damage Reduction"))
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Blood of Life {Math.Round(0.33 * a.Level - 0.33)}",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
