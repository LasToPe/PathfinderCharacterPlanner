using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class EldritchPoisoner : Archetype
    {
        public EldritchPoisoner(Classes.Alchemist alchemist)
        {
            Name = "Eldritch Poisoner";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 1",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 2",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 3",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 4",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 5",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 6",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 7",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 8",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 9",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = "Arcanotoxin 10",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Toxicologist ",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = "Sneak Attack +1d6",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen, alchemist.PersistentMutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Sneak Attack +2d6",
                    Level = 4,
                },
                new ArchetypeAbility
                {
                    Name = "Sneak Attack +3d6",
                    Level = 8,
                },
                new ArchetypeAbility
                {
                    Name = "Sneak Attack +4d6",
                    Level = 12,
                },
                new ArchetypeAbility
                {
                    Name = "Sneak Attack +5d6",
                    Level = 16,
                },
                new ArchetypeAbility
                {
                    Name = "Sneak Attack +6d6",
                    Level = 20,
                },
                new ArchetypeAbility
                {
                    Name = "Eldritch Poisoner Discoveries",
                    Level = 2,
                },
            };
        }
    }
}
