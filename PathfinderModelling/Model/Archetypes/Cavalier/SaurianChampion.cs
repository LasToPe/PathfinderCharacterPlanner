using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class SaurianChampion : Archetype
    {
        public SaurianChampion(Classes.Cavalier cavalier)
        {
            Name = "Saurian Champion";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Savage Combatant",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Wild Warrior",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Order, cavalier.OrderAbility2, cavalier.OrderAbility8, cavalier.OrderAbility15 },
                },
                new ArchetypeAbility
                {
                    Name = "Dinosaur Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Nimble Rider",
                    Level = 2,
                },
                new ArchetypeAbility
                {
                    Name = "Fierce Devotion",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Quick Rider",
                    Level = 8,
                },
                new ArchetypeAbility
                {
                    Name = "Titanic Mount",
                    Level = 10,
                },
                new ArchetypeAbility
                {
                    Name = "Primeval Devotion",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterBanner },
                }
            };

            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Challenge"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Titanic " + a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
