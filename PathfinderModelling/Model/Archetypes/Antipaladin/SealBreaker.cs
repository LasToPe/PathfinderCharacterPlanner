using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class SealBreaker : Archetype
    {
        public SealBreaker(Classes.Antipaladin antipaladin)
        {
            Name = "Seal-Breaker";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Aura of the Grave",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfCowardice }
                },
                new ArchetypeAbility
                {
                    Name = "Corpse Rider",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.FiendishBoon }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Death",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfDespair }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Rebirth",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfVengeance }
                },
            };
        }
    }
}
