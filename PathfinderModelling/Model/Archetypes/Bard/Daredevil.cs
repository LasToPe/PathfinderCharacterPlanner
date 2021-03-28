using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Daredevil : Archetype
    {
        public Daredevil(Classes.Bard bard)
        {
            Name = "Daredevil";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Agile",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Dauntless",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Scoundrel's Fortune 1/day",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))),
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Inspire Courage"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Inspire Courage", "Derring-do"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Canny Foe",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            for (int i = 8; i <= 20; i += 3)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Scoundrel's Fortune {Math.Round(0.33 * i - 0.667)}/day",
                    Level = i,
                });
        }
    }
}
