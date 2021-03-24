using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class BloodAlchemist : Archetype
    {
        public BloodAlchemist(Classes.Alchemist alchemist)
        {
            Name = "Blood Alchemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Lifeblood",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Alchemical Circles",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> 
                    { 
                        alchemist.Bomb1, 
                        alchemist.Bomb2, 
                        alchemist.Bomb3, 
                        alchemist.Bomb4, 
                        alchemist.Bomb5, 
                        alchemist.Bomb6, 
                        alchemist.Bomb7, 
                        alchemist.Bomb8, 
                        alchemist.Bomb9, 
                        alchemist.Bomb10
                    }
                },
                new ArchetypeAbility
                {
                    Name = "Blood Knowledge",
                    Level = 4,
                },
            };
        }
    }
}
