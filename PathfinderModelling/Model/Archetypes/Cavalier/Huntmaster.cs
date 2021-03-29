using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Huntmaster : Archetype
    {
        public Huntmaster(Classes.Cavalier cavalier)
        {
            Name = "Huntmaster";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Bestial Challenge",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Hunting Pack",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Animal Trainer",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Swift Tracker",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Step Up",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.BonusFeat6 },
                },
                new ArchetypeAbility
                {
                    Name = "Following Step",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.BonusFeat12 },
                },
                new ArchetypeAbility
                {
                    Name = "Step Up and Strike",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.BonusFeat18 },
                },
                new ArchetypeAbility
                {
                    Name = "Pack Attack",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Quarry",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterBanner },
                },
                new ArchetypeAbility
                {
                    Name = "Improved Quarry",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };

            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Challenge"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Tactician"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
