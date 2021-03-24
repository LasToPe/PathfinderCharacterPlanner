using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Aerochemist : Archetype
    {
        public Aerochemist(Classes.Alchemist alchemist)
        {
            Name = "Aerochemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Aeromantic Concoction",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen, alchemist.SwiftPoisoning, alchemist.PersistentMutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Bombs Away",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>{ alchemist.PoisonUse, alchemist.SwiftAlchemy }
                },
                new ArchetypeAbility
                {
                    Name = "Aerodynamic Prowess",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6, alchemist.PoisonImmunity }
                }
            };
        }
    }
}
