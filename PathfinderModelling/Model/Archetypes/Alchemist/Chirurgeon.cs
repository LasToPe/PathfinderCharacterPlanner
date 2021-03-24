using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Chirurgeon : Archetype
    {
        public Chirurgeon(Classes.Alchemist alchemist)
        {
            Name = "Chirurgeon";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Infused Curative",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Anaesthetic",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance4 }
                },
                new ArchetypeAbility
                {
                    Name = "Power Over Death",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                },
            };
        }
    }
}
