using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class Tyrant : Archetype
    {
        public Tyrant(Classes.Antipaladin antipaladin)
        {
            Name = "Tyrant";
            // Class Skills ?
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Tyrant's Code",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Diabolic Boon",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.FiendishBoon }
                }
            };
        }
    }
}
