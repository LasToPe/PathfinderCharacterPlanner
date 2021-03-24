using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class DragonbloodChymist : Archetype
    {
        public DragonbloodChymist(Classes.Alchemist alchemist)
        {
            Name = "Dragonblood Chymist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Dragonblood Mutagen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen, alchemist.Discovery2, alchemist.Discovery12, alchemist.Discovery16 }
                },
                new ArchetypeAbility
                {
                    Name = "Explosive Breath",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = "Draconic Resistances +2",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Draconic Resistances +4",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance4, alchemist.SwiftPoisoning }
                },
                new ArchetypeAbility
                {
                    Name = "Draconic Resistances +6",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6 }
                },
                new ArchetypeAbility
                {
                    Name = "Draconic Resistances Immunity",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                },
            };
        }
    }
}
