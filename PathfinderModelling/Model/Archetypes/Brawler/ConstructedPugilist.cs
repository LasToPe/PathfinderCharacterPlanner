using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class ConstructedPugilist : Archetype
    {
        public ConstructedPugilist(Classes.Brawler brawler)
        {
            Name = "Constructed Pugilist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Constructed Limb",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Limb Modification",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.MartialFlexibility },
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Item Creation Feats",
                    Level = 2,
                }
            };

            var levels = new[] { 6, 10, 12, 20 };
            for (int i = 0; i <= 20; i++)
                if (levels.Contains(i))
                    ArchetypeAbilities.Add(new ArchetypeAbility
                    {
                        Name = "Limb Modification",
                        Level = i,
                    });
        }
    }
}
