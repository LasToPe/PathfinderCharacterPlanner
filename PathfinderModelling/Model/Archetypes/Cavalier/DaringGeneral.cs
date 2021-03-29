using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class DaringGeneral : Archetype
    {
        public DaringGeneral(Classes.Cavalier cavalier)
        {
            Name = "Daring General";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Aides-de-Camp",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.BonusFeat6, cavalier.BonusFeat12, cavalier.BonusFeat18 },
                },
                new ArchetypeAbility
                {
                    Name = "Shared Challenge",
                    Level = 12,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.DemandingChallenge },
                },
                new ArchetypeAbility
                {
                    Name = "Supreme Tactician",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.SupremeCharge },
                }
            };
        }
    }
}
