using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Saboteur : Archetype
    {
        public Saboteur(Classes.Alchemist alchemist)
        {
            Name = "Saboteur";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Chameleon Mutagen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Saboteur Discoveries",
                    Level = 2
                },
                new ArchetypeAbility
                {
                    Name = "Grand Discoveries",
                    Level = 20
                },
            };
        }
    }
}
