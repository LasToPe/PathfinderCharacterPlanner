using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class SacramentAlchemist : Archetype
    {
        public SacramentAlchemist(Classes.Alchemist alchemist)
        {
            Name = "Sacrament Alchemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Faithful",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Sacramental Cognatogen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Divinely Inspired Alchemy",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftAlchemy }
                }
            };
        }
    }
}
