using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class Verdivant : Archetype
    {
        public Verdivant(Classes.Cavalier cavalier)
        {
            Name = "Verdivant";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Plant Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount, cavalier.ExpertTrainer },
                },
                new ArchetypeAbility
                {
                    Name = "Effloresce 3/day",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(cavalier.ClassAbilities.Where(a => a.Name.Contains("Bonus Feat"))) { cavalier.Tactician, cavalier.Banner, cavalier.GreaterTactician, cavalier.GreaterBanner, cavalier.MasterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Sinuous Steps",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                }
            };

            for (int i = 6; i <= 20; i += 4)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = $"Effloresce {Math.Round(0.25 * i + 2.5)}/day",
                    Level = i,
                    ReplacedAbilities = new List<ClassAbility> { },
                });
        }
    }
}
