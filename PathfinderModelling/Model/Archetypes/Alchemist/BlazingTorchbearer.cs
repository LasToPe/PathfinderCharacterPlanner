using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class BlazingTorchbearer : Archetype
    {
        public BlazingTorchbearer(Classes.Alchemist alchemist)
        {
            Name = "Blazing Torchbearer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Everburning Flame",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion }
                },
                new ArchetypeAbility
                {
                    Name = "Intense Light",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse },
                },
                new ArchetypeAbility
                {
                    Name = "Explosive Torch",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery4 },
                },
            };
        }
    }
}
