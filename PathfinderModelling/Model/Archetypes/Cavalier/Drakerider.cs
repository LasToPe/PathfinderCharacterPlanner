using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Drakerider : Archetype
    {
        public Drakerider(Classes.Cavalier cavalier)
        {
            Name = "Drakerider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Drake Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount, cavalier.Tactician, cavalier.ExpertTrainer, cavalier.Banner, cavalier.GreaterTactician, cavalier.GreaterBanner, cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = cavalier.CavaliersCharge.Name,
                    Level = 9,
                }
            };
        }
    }
}
