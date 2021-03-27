using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class Superstitious : Archetype
    {
        public Superstitious(Classes.Barbarian barbarian)
        {
            Name = "Superstitious";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Keen Senses (low-light vision)",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.DamageReduction1 },
                },
                new ArchetypeAbility
                {
                    Name = "Keen Senses (darkvision)",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.DamageReduction2 },
                },
                new ArchetypeAbility
                {
                    Name = "Keen Senses (scent)",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.DamageReduction3 },
                },
                new ArchetypeAbility
                {
                    Name = "Keen Senses (blindsense)",
                    Level = 16,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.DamageReduction4 },
                },
                new ArchetypeAbility
                {
                    Name = "Keen Senses (blindsight)",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.DamageReduction5 },
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Sixth Sense"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
