using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bloodrager
{
    class EnlightenedBloodrager : Archetype
    {
        public EnlightenedBloodrager(Classes.Bloodrager bloodrager)
        {
            Name = "Enlightened Bloodrager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Enlightened Spellcasting",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility>(bloodrager.ClassAbilities.Where(a => a.Name.Contains("Bloodline Spell"))) { bloodrager.BloodlinePower1 },
                },
                new ArchetypeAbility
                {
                    Name = "Enlightened Bloodrage",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.BloodlinePower4 },
                },
                new ArchetypeAbility
                {
                    Name = "Bloodline Feat",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.DamageReduction1, bloodrager.DamageReduction3, bloodrager.DamageReduction5 },
                },
                new ArchetypeAbility
                {
                    Name = bloodrager.DamageReduction1.Name,
                    Level = bloodrager.DamageReduction2.Level,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.DamageReduction2 },
                },
                new ArchetypeAbility
                {
                    Name = bloodrager.DamageReduction2.Name,
                    Level = bloodrager.DamageReduction4.Level,
                    ReplacedAbilities = new List<ClassAbility> { bloodrager.DamageReduction4 },
                },
            };
        }
    }
}
