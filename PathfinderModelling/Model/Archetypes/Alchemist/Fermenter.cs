using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Fermenter : Archetype
    {
        public Fermenter(Classes.Alchemist alchemist)
        {
            Name = "Fermenter";
                ArchetypeAbilities = new List<ArchetypeAbility>
                {
                    new ArchetypeAbility
                    {
                        Name = "Substance Tolerance +2",
                        Level = 2,
                        ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4 }
                    },
                    new ArchetypeAbility
                    {
                        Name = "Substance Tolerance +3",
                        Level = 8,
                        ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6 }
                    },
                    new ArchetypeAbility
                    {
                        Name = "Substance Tolerance +4",
                        Level = 10,
                        ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity, alchemist.Discovery10 }
                    },
                    new ArchetypeAbility
                    {
                        Name = "Volatile Bombs",
                        Level = 2,
                        ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                    },
                    new ArchetypeAbility
                    {
                        Name = "Batch Brew",
                        Level = 6,
                        ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                    }
                };
        }
    }
}
