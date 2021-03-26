using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class DreadVanguard : Archetype
    {
        public DreadVanguard(Classes.Antipaladin antipaladin)
        {
            Name = "Dread Vanguard";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Beacon of Evil",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.Spells },
                    Add = () => antipaladin.SpellCaster = false,
                    Remove = () => antipaladin.SpellCaster = true,
                },
                new ArchetypeAbility
                {
                    Name = "Dark Emisary",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfSin }
                }
            };
        }
    }
}
