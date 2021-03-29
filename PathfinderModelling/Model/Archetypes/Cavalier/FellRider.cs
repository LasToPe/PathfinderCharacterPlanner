using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class FellRider : Archetype
    {
        public FellRider(Classes.Cavalier cavalier)
        {
            Name = "Fell Rider";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Brute Steed",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Rampage",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Dread Rider",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Fell Presence",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Deadly Rampage",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Terror",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterBanner },
                },
                new ArchetypeAbility
                {
                    Name = "Unstoppable Rampage",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };
        }
    }
}
