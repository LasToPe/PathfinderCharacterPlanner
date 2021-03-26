using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class RoughRampager : Archetype
    {
        public RoughRampager(Classes.Antipaladin antipaladin)
        {
            Name = "Rough Rampager";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Aura of Blood",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfCowardice }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Putrefaction",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfDespair }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Quietus",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfSin }
                },
            };
        }
    }
}
