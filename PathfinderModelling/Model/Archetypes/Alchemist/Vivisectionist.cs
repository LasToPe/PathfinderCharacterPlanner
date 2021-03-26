using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Vivisectionist : Archetype
    {
        public Vivisectionist(Classes.Alchemist alchemist)
        {
            Name = "Vivisectionist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Torturer's Eye",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Cruel Anatomist",
                    Level = 3,
                },
                new ArchetypeAbility
                {
                    Name = "Torturous Transformation",
                    Level = 7
                },
                new ArchetypeAbility
                {
                    Name = "Bleeding Attack",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Crippling Strike",
                    Level = 10,
                }
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Bomb ", "Sneak Attack +"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
