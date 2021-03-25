using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class PlagueBringer : Archetype
    {
        public PlagueBringer(Classes.Alchemist alchemist)
        {
            Name = "Plague Bringer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Plague Vial",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Disease Immunity",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                }
            };
            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Poison Resistance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Poison", "Disease"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
