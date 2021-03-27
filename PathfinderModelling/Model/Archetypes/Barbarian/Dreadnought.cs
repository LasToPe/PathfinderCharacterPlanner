using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class Dreadnought : Archetype
    {
        public Dreadnought(Classes.Barbarian barbarian)
        {
            Name = "Dreadnought";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Dead Calm",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage }
                },
                new ArchetypeAbility
                {
                    Name = "Stead Gait",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement }
                },
                new ArchetypeAbility
                {
                    Name = "Fearless Killer",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.IndomitableWill }
                },
                new ArchetypeAbility
                {
                    Name = "Instant Dispassion",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.TirelessRage }
                }
            };
        }
    }
}
