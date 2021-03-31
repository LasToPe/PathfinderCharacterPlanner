using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cleric
{
    class Cardinal : Archetype
    {
        public Cardinal(Classes.Cleric cleric)
        {
            Name = "Cardinal";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Political Skill",
                    Level = 1,
                    Add = () =>
                    {
                        // Skills per level
                        cleric.BaseAttackBonus = BaseAttackBonus.Half;
                    },
                    Remove = () =>
                    {
                        // Skills per level
                        cleric.BaseAttackBonus = BaseAttackBonus.Medium;
                    }
                },
                new ArchetypeAbility
                {
                    Name = "Domain",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cleric.Domains },
                }
            };
        }
    }
}
