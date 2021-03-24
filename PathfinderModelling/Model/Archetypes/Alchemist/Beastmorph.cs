using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Beastmorph : Archetype
    {
        public Beastmorph(Classes.Alchemist alchemist)
        {
            Name = "Beastmorph";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Beastform Mutagen",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftAlchemy },
                },
                new ArchetypeAbility
                {
                    Name = "Improved Beastform Mutagen",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning },
                },
                new ArchetypeAbility
                {
                    Name = "Greater Beastform Mutagen",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6, alchemist.PoisonImmunity },
                },
                new ArchetypeAbility
                {
                    Name = "Grand Beastform Mutagen",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PersistentMutagen },
                },
            };
        }
    }
}
