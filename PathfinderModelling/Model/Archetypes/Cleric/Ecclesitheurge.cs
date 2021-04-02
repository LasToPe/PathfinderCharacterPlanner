using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class Ecclesitheurge : Archetype
    {
        public Ecclesitheurge(Classes.Cleric cleric)
        {
            Name = "Ecclesitheurge";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Ecclesitheurge's Vow",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Blessing of the Faithful",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Domain Mastery",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    Name = "Bonded Holy Symbol",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cleric.ChannelEnergy2 },
                }
            };

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy") && a.Level > 3)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Channel Energy {Math.Round(0.5 * a.Level - 0.5)}d6",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
