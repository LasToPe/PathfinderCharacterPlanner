using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Filidh : Archetype
    {
        public Filidh(Classes.Bard bard)
        {
            Name = "Filidh";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Natural Magic",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Spells },
                },
                new ArchetypeAbility
                {
                    Name = "Nature's Song",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Divinatory Song",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Voices of Life",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                },
                new ArchetypeAbility
                {
                    Name = "Unity of Life",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireHeroics },
                },
                new ArchetypeAbility
                {
                    Name = "Song of the Cycle",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { bard.DeadlyPerformance },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Inspire Courage"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Inspire Courage", "Echoes of Nature’s Song"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
