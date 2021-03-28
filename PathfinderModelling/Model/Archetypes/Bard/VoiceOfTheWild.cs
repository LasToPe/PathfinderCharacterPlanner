using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class VoiceOfTheWild : Archetype
    {
        public VoiceOfTheWild(Classes.Bard bard)
        {
            Name = "Voice of the Wild";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Wild Knowledge",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Nature Magic 1",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Versatile Performance"))) { bard.Countersong, bard.JackOfAllTrades },
                },
                new ArchetypeAbility
                {
                    Name = "Song of the Wild",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence"))) { bard.DirgeOfDoom, bard.InspireHeroics },
                }
            };

            for (int i = 4; i <= 16; i += 3)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Nature Magic {Math.Round(0.33 * i + 0.667)}",
                    Level = i,
                });
        }
    }
}
