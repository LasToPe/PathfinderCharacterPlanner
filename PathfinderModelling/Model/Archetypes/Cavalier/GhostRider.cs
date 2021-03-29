using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class GhostRider : Archetype
    {
        public GhostRider(Classes.Cavalier cavalier)
        {
            Name = "Ghost Rider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Ghost Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Frightful Gaze",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician, cavalier.GreaterTactician, cavalier.MasterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Fearless",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Spirited Mount",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer, cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Ghost Wind",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge, cavalier.GreaterBanner },
                }
            };
        }
    }
}
