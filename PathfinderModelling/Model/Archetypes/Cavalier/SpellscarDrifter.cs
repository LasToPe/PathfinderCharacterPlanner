using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class SpellscarDrifter : Archetype
    {
        public SpellscarDrifter(Classes.Cavalier cavalier)
        {
            Name = "Spellscar Drifter";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Have Gun",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician },
                },
                new ArchetypeAbility
                {
                    Name = "Daring Deeds",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Worn Banner",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Notorious Deeds",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Old Reliable",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Spell Severed",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.DemandingChallenge },
                },
                new ArchetypeAbility
                {
                    Name = "Infamous Deeds",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MasterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Tough as Nails",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };

            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Bonus Feat"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
