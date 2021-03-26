using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class RoyalAlchemist : Archetype
    {
        public RoyalAlchemist(Classes.Alchemist alchemist)
        {
            Name = "Royal Alchemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Alchemical Antidote",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse, alchemist.SwiftPoisoning }
                }
            };
        }
    }
}
