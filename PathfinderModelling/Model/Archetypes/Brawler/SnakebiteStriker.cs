using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class SnakebiteStriker : Archetype
    {
        public SnakebiteStriker(Classes.Brawler brawler)
        {
            Name = "Snakebite Striker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Sneak Attack +1d6",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.MartialFlexibility },
                },
                new ArchetypeAbility
                {
                    Name = "Snake Feint",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { brawler.ManeuverTraining3, brawler.ManeuverTraining7 },
                },
                new ArchetypeAbility
                {
                    Name = "Opportunist",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { brawler.ManeuverTraining11, brawler.ManeuverTraining19 },
                },
            };

            var levels = new[] { 6, 10, 12, 20 };
            for (int i = 0; i <= 20; i++)
                if (levels.Contains(i))
                    ArchetypeAbilities.Add(new ArchetypeAbility
                    {
                        Name = $"Sneak Attack +{Array.IndexOf(levels, i) + 2}d6",
                        Level = i,
                    });
        }
    }
}
