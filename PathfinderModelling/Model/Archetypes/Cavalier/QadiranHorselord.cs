using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class QadiranHorselord : Archetype
    {
        public QadiranHorselord(Classes.Cavalier cavalier)
        {
            Name = "Qadiran Horselord";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Desert Wind",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician },
                },
                new ArchetypeAbility
                {
                    Name = "Desert Mastery",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Sand Storm",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.BonusFeat6 },
                },
                new ArchetypeAbility
                {
                    Name = "As One",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Sand Scourge",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MasterTactician },
                }
            };
        }
    }
}
