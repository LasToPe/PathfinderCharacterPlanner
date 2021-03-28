using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class SoundStriker : Archetype
    {
        public SoundStriker(Classes.Bard bard)
        {
            Name = "Sound Striker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Wordstrike",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence")))
                },
                new ArchetypeAbility
                {
                    Name = "Weird Words",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                }
            };
        }
    }
}
