using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class CloisteredCleric : Archetype
    {
        public CloisteredCleric(Classes.Cleric cleric)
        {
            Name = "Cloistered Cleric";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Diminished Spellcasting",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Spells },
                    Add = () => cleric.DiminishedSpellCasting(true),
                    Remove = () => cleric.DiminishedSpellCasting(false)
                },
                new ArchetypeAbility
                {
                    Name = "Domain",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                },
                new ArchetypeAbility
                {
                    Name = "Breadth of Knowledge",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Well-Read",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Verbal Instruction",
                    Level = 3,
                },
                new ArchetypeAbility
                {
                    Name = "Scribe Scroll",
                    Level = 4,
                }
            };
        }
    }
}
