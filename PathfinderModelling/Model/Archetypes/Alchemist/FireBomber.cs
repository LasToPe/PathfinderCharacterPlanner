using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class FireBomber : Archetype
    {
        public FireBomber(Classes.Alchemist alchemist)
        {
            Name = "Fire Bomber";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Fire Bombardier",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb1.Name,
                    Level = alchemist.Bomb1.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb1 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb2.Name,
                    Level = alchemist.Bomb2.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb2 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb3.Name,
                    Level = alchemist.Bomb3.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb3 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb4.Name,
                    Level = alchemist.Bomb4.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb4 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb5.Name,
                    Level = alchemist.Bomb5.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb5 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb6.Name,
                    Level = alchemist.Bomb6.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb6 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb7.Name,
                    Level = alchemist.Bomb7.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb7 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb8.Name,
                    Level = alchemist.Bomb8.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb8 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb9.Name,
                    Level = alchemist.Bomb9.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb9 }
                },
                new ArchetypeAbility
                {
                    Name = alchemist.Bomb10.Name,
                    Level = alchemist.Bomb10.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb10 }
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feats",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Fiery Cocktail",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery4 }
                },
                new ArchetypeAbility
                {
                    Name = "Fire Body",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6 }
                },
                new ArchetypeAbility
                {
                    Name = "Improved Fire Body",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Greater Fire Body",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PersistentMutagen }
                },
            };
        }
    }
}
