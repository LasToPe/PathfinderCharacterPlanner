using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class TwilightSage : Archetype
    {
        public TwilightSage(Classes.Arcanist arcanist)
        {
            Name = "Twilight Sage";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Consume Life",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ConsumeSpells }
                },
                new ArchetypeAbility
                {
                    Name = "Necromantic Focus",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Twilight Barrier",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit1 }
                },
                new ArchetypeAbility
                {
                    Name = "Twilight Transfer",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit11 }
                },
                new ArchetypeAbility
                {
                    Name = "Death's Release",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.MagicalSupremacy }
                },
            };
        }
    }
}
