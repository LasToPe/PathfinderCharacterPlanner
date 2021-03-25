using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Preservationist : Archetype
    {
        public Preservationist(Classes.Alchemist alchemist)
        {
            Name = "Preservationist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bottled Ally I",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Bottled Ally II",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance4 }
                },
                new ArchetypeAbility
                {
                    Name = "Bottled Ally III",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6 }
                },
                new ArchetypeAbility
                {
                    Name = "Bottled Ally IV",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Bottled Ally V",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PersistentMutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Bottled Ally VI",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery18 }
                },
            };
        }
    }
}
