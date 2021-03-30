using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class LuringCavalier : Archetype
    {
        public LuringCavalier(Classes.Cavalier cavalier)
        {
            Name = "Luring Cavalier";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Careful Aim",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Infuriating Aim",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Versatile Challenge",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.DemandingChallenge },
                },
                new ArchetypeAbility
                {
                    Name = "Supreme Aim",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };

            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Challenge"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Far " + a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
