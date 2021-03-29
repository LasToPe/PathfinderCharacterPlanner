using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class DaringChampion : Archetype
    {
        public DaringChampion(Classes.Cavalier cavalier)
        {
            Name = "Daring Champion";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Champion's Finesse",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Nimble +1",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Panache and Deeds",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Advanced Deeds",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Champion's Weapon Mastery",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };

            for (int i = 7; i < 20; i += 4)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Nimble +{Math.Round(0.25 * i + 0.25)}",
                    Level = i,
                });
        }
    }
}
