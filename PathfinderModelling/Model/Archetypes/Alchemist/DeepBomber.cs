using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class DeepBomber : Archetype
    {
        public DeepBomber(Classes.Alchemist alchemist)
        {
            Name = "Deep Bomber";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Silent Bomb",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Targeting Bomb",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftAlchemy }
                },
                new ArchetypeAbility
                {
                    Name = "Stonekin",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.SwiftAlchemy.Name,
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.InstantAlchemy }
                }
            };
        }
    }
}
