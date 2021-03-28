using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Flamesinger : Archetype
    {
        public Flamesinger(Classes.Bard bard)
        {
            Name = "Flamesinger";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fire Music",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))) { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Wildfire",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))),
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Inspire Courage"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Inspire Courage +", "Blazing Blades ") + "d4",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
