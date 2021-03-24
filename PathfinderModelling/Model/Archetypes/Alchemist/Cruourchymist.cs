using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Cruourchymist : Archetype
    {
        public Cruourchymist(Classes.Alchemist alchemist)
        {
            Name = "Cruorchymist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Blood Famliliar",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Blood Treatment",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion }
                },
                new ArchetypeAbility
                {
                    Name = "Blood Augmentation",
                    Level = 4,
                }
            };
        }
    }
}
