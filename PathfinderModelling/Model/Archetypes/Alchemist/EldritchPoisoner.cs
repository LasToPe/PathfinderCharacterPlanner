using System;
using System.Collections.Generic;
using System.Linq;
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

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Bomb", "Arcanotoxin").Replace("d6", ""),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
