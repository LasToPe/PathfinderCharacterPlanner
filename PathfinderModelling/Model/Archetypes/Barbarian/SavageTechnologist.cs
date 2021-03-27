using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class SavageTechnologist : Archetype
    {
        public SavageTechnologist(Classes.Barbarian barbarian)
        {
            Name = "Savage Technologist";
            ArchetypeAbilities = new List<ArchetypeAbility>()
            {
                new ArchetypeAbility
                {
                    Name = "Rage",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.Rage }
                },
                new ArchetypeAbility
                {
                    Name = "Sword and Gun",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge }
                },
                new ArchetypeAbility
                {
                    Name = "Primal Magnetism",
                    Level = 3,
                },
                new ArchetypeAbility
                {
                    Name = "Crack Shot",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.ImprovedUncannyDodge }
                }
            };
        }
    }
}
