using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class ConstructRider : Archetype
    {
        public ConstructRider(Classes.Alchemist alchemist)
        {
            Name = "Construct Rider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Craft Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion, alchemist.Mutagen, alchemist.Discovery4 }
                },
                new ArchetypeAbility
                {
                    Name = "Diminished Extracts",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Extracts },
                    Add = () => alchemist.LimitedExtracts(true),
                    Remove = () => alchemist.LimitedExtracts(false)
                },
                new ArchetypeAbility
                {
                    Name = "Construct Rider Discoveries",
                    Level = 2,
                }
            };
        }
    }
}
