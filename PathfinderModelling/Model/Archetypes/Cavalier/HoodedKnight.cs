using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class HoodedKnight : Archetype
    {
        public HoodedKnight(Classes.Cavalier cavalier)
        {
            Name = "Hooded Knight";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Feytouched Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Hero of the Roads",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician },
                },
                new ArchetypeAbility
                {
                    Name = "Champion of the Roads",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Paragon of the Roads",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MasterTactician },
                }
            };
        }
    }
}
