using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class FeralStriker : Archetype
    {
        public FeralStriker(Classes.Brawler brawler)
        {
            Name = "Feral Striker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Feral Aspect",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.MartialFlexibility },
                }
            };
        }
    }
}
