using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class WingedMarauder : Archetype
    {
        public WingedMarauder(Classes.Alchemist alchemist)
        {
            Name = "Winged Marauder";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Flying Beast Tamer",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen, alchemist.PersistentMutagen }
                }
            };
        }
    }
}
