using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class ChannelerOfTheUnknown : Archetype
    {
        public ChannelerOfTheUnknown(Classes.Cleric cleric)
        {
            Name = "Channeler of the Unknown";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Spells",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Spells },
                    Add = () => cleric.DiminishedSpellCasting(true),
                    Remove = () => cleric.DiminishedSpellCasting(false),
                },
                new ArchetypeAbility
                {
                    Name = "Unknown Aura",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Aura },
                },
                new ArchetypeAbility
                {
                    Name = "Power of the Unknown",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    Name = "Spontaneous Casting",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.SpontaneousCasting },
                }
            };
        }
    }
}
