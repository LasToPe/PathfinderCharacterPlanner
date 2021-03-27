using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class SpellSpecialist : Archetype
    {
        public SpellSpecialist(Classes.Arcanist arcanist)
        {
            Name = "Spell Specialist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Signature Spells",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1, arcanist.ArcanistExploit7, arcanist.ArcanistExploit13, arcanist.ArcanistExploit19 }
                }
            };
        }
    }
}
