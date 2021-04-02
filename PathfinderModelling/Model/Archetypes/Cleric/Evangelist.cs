using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class Evangelist : Archetype
    {
        public Evangelist(Classes.Cleric cleric)
        {
            Name = "Evangelist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Single-Minded",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    Name = "Public Speaker",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Sermonic Performance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.ChannelEnergy1, cleric.ChannelEnergy5, cleric.ChannelEnergy8 },
                },
                new ArchetypeAbility
                {
                    Name = "Spontaneous Casting",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.SpontaneousCasting },
                }
            };

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy") && a.Level > 1 && a.Level < 9)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Channel Energy {Math.Round(0.5 * a.Level - 0.5)}d6",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy") && a.Level > 9 && a.Level < 15)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Channel Energy {Math.Round(0.5 * a.Level - 1.5)}d6",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy") && a.Level > 15)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Channel Energy {Math.Round(0.5 * a.Level - 2.5)}d6",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
