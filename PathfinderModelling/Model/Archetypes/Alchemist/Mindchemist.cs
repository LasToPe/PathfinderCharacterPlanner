using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Mindchemist : Archetype
    {
        public Mindchemist(Classes.Alchemist alchemist)
        {
            Name = "Mindchemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Cognatogen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Perfect Recall",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feats",
                    Level = 2
                },
                new ArchetypeAbility
                {
                    Name = "Languages",
                    Level = 2
                }
            };
        }
    }
}
