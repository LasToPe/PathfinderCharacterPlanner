using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class WastelandBlightbreaker : Archetype
    {
        public WastelandBlightbreaker(Classes.Alchemist alchemist)
        {
            Name = "Wasteland Blightbreaker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Healing Infusion",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2 }
                },
                new ArchetypeAbility
                {
                    Name = "Swift Healing Infusions",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                },
                new ArchetypeAbility
                {
                    Name = "Banish Blights",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6, alchemist.Discovery8 }
                }
            };
        }
    }
}
