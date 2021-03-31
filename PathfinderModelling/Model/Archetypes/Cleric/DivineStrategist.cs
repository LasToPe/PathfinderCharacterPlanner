using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class DivineStrategist : Archetype
    {
        public DivineStrategist(Classes.Cleric cleric)
        {
            Name = "Divine Strategist";
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
                    Name = "Master Tactician",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(cleric.ClassAbilities.Where(a => a.Name.Contains("Channel Energy")))
                },
                new ArchetypeAbility
                {
                    Name = "Caster Support",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Tactical Expertise",
                    Level = 8,
                }
            };
        }
    }
}
