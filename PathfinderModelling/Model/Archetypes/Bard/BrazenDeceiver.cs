using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class BrazenDeceiver : Archetype
    {
        public BrazenDeceiver(Classes.Bard bard)
        {
            Name = "Brazen Deceiver";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Deceptive Tale",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong, bard.Distraction },
                },
                new ArchetypeAbility
                {
                    Name = "Shameless Scoundrel",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Blatant Subtlety",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Invoke Vyriavaxus",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { },
                }));

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Lore Master"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Lore Master", "Devil's Tongue"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
