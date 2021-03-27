using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class HarrowedSocietyStudent : Archetype
    {
        public HarrowedSocietyStudent(Classes.Arcanist arcanist)
        {
            Name = "Harrowed Society Student";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Psychic Reader",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1 }
                },
                new ArchetypeAbility
                {
                    Name = "Harrow Reservoir 1/day",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ConsumeSpells }
                },
                new ArchetypeAbility
                {
                    Name = "Harrow Reservoir 2/day",
                    Level = 8,
                },
                new ArchetypeAbility
                {
                    Name = "Harrow Reservoir 3/day",
                    Level = 16,
                },
                new ArchetypeAbility
                {
                    Name = "Trump Card",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit9 }
                }
            };

            for (int i = 5; i < 20; i += 2)
                ArchetypeAbilities.Add(new ArchetypeAbility { Name = "Divine the Mysteries", Level = i });
        }
    }
}
