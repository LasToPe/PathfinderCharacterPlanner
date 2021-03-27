using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class TitanMauler : Archetype
    {
        public TitanMauler(Classes.Barbarian barbarian)
        {
            Name = "Titan Mauler";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Big Game Hunter",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Jotungrip",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Evade Reach",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Titanic Rage",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.IndomitableWill },
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Massive Weapons"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
