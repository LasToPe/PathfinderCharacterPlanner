using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class GreenKnight : Archetype
    {
        public GreenKnight(Classes.Cavalier cavalier)
        {
            Name = "Green Knight";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Beast Tongue",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Tactician },
                },
                new ArchetypeAbility
                {
                    Name = "Implacable Knight",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Nature’s Servant",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Order },
                },
                new ArchetypeAbility
                {
                    Name = "Ferocious",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.CavaliersCharge },
                },
                new ArchetypeAbility
                {
                    Name = "Woodland Stride",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.ExpertTrainer, cavalier.Banner },
                },
                new ArchetypeAbility
                {
                    Name = "Stalwart",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.GreaterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Oaken Vitality",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MightyCharge, cavalier.GreaterBanner },
                },
                new ArchetypeAbility
                {
                    Name = "Take Their Heads",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.MasterTactician },
                },
                new ArchetypeAbility
                {
                    Name = "Indestructible",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };
        }
    }
}
