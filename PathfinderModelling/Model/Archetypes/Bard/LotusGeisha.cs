using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class LotusGeisha : Archetype
    {
        public LotusGeisha(Classes.Bard bard)
        {
            Name = "Lotus Geisha";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Enrapturing Performance",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feats",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Lore Master"))) { bard.BardicKnowledge },
                }
            };
        }
    }
}
