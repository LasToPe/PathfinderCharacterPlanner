using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class SisterInArms : Archetype
    {
        public SisterInArms(Classes.Cavalier cavalier)
        {
            Name = "Sister-in-Arms";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Maiden's Order",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Order, cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Devoted Defender",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Maiden's Loyalty",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Dedicated Commander",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge, cavalier.SupremeCharge },
                }
            };

            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Challenge"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Halfhearted " + a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
