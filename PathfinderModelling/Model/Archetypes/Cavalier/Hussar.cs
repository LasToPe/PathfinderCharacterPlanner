using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Hussar : Archetype
    {
        public Hussar(Classes.Cavalier cavalier)
        {
            Name = "Hussar";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fast Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician, cavalier.Banner, cavalier.GreaterBanner },
                },
                new ArchetypeAbility
                {
                    Name = "Skillful Rider",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.BonusFeat6, cavalier.BonusFeat12, cavalier.BonusFeat18 },
                },
                new ArchetypeAbility
                {
                    Name = "Maneuverable Mount",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Sudden Swerve",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MasterTactician },
                }
            };
        }
    }
}
