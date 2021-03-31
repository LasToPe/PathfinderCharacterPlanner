using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class DemonicApostle : Archetype
    {
        public DemonicApostle(Classes.Cleric cleric)
        {
            Name = "Demonic Apostle";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Demonic Magic",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    Name = "Demonic Familiar",
                    Level = 1,
                },
            };

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Channel Energy", "Demonic Channel"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
