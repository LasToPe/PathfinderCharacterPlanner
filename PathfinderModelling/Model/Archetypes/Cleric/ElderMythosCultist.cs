using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class ElderMythosCultist : Archetype
    {
        public ElderMythosCultist(Classes.Cleric cleric)
        {
            Name = "Elder Mythos Cultist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Domain",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    Name = "Forbidden Knowledge",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Unhinged Mind",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Channel the Void",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.SpontaneousCasting },
                },
                new ArchetypeAbility
                {
                    Name = "Maddening Gaze",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cleric.ChannelEnergy3, cleric.ChannelEnergy6, cleric.ChannelEnergy10 },
                }
            };

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy") && a.Level < 5)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Channel the Void {Math.Round(0.5 * a.Level + 0.5)}d6",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy") && a.Level > 5 && a.Level < 11)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Channel the Void {Math.Round(0.5 * a.Level - 0.5)}d6",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(cleric.ClassAbilities
                .Where(a => a.Name.Contains("Channel Energy") && a.Level > 11 && a.Level < 19)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Channel the Void {Math.Round(0.5 * a.Level - 1.5)}d6",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
