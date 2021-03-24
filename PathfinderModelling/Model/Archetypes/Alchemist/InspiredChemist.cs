using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class InspiredChemist : Archetype
    {
        public InspiredChemist(Classes.Alchemist alchemist)
        {
            Name = "Inspired Chemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Inspiring Cognatogen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feats",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Investigator Talents",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Languages",
                    Level = 2,
                },
            };
        }
    }
}
