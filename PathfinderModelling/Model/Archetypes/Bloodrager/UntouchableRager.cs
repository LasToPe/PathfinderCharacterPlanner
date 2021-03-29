using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class UntouchableRager : Archetype
    {
        public UntouchableRager(Classes.Bloodrager bloodrager)
        {
            Name = "Untouchable Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Raging Resistance",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility>(bloodrager.ClassAbilities.Where(a => a.Name.Contains("Bloodline Spell"))) { bloodrager.Spells, bloodrager.BloodCasting, bloodrager.EschewMaterials },
                    Add = () => bloodrager.SpellCaster = false,
                    Remove = () => bloodrager.SpellCaster = true,
                },
                new ArchetypeAbility
                {
                    Name = "Resistance Control",
                    Level = 14,
                }
            };
        }
    }
}
