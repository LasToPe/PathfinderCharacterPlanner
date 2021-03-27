using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class InvulnerableRager : Archetype
    {
        public InvulnerableRager(Classes.Barbarian barbarian)
        {
            Name = "Invulnerable Rager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Invulnerability",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge, barbarian.ImprovedUncannyDodge, barbarian.DamageReduction1, barbarian.DamageReduction2, barbarian.DamageReduction3, barbarian.DamageReduction4, barbarian.DamageReduction5 }
                },
                new ArchetypeAbility
                {
                    Name = "Extreme Endurance (endure elements)",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TrapSense1 }
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense") && a.Level > 3)
                .Select(a => new ArchetypeAbility
                {
                    Name = $"Extreme Endurance +{(a.Level - 3) / 3}",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
