using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class UrbanBarbarian : Archetype
    {
        public UrbanBarbarian(Classes.Barbarian barbarian)
        {
            Name = "Urban Barbarian";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Crowd Control",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Controlled Rage",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage },
                }
            };
        }
    }
}
