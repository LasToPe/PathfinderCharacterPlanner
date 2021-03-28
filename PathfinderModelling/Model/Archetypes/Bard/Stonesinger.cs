using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class Stonesinger : Archetype
    {
        public Stonesinger(Classes.Bard bard)
        {
            Name = "Stonesinger";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Earth Magic",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Stone Song",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicPerformance },
                },
                new ArchetypeAbility
                {
                    Name = "Tremor",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong },
                },
                new ArchetypeAbility
                {
                    Name = "Quake",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { bard.DirgeOfDoom },
                }
            };
        }
    }
}
