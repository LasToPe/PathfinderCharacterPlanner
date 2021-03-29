using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class Venomfist : Archetype
    {
        public Venomfist(Classes.Brawler brawler)
        {
            Name = "Venomfist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Venomous Strike",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Knockout") || a.Name.Contains("Unarmed Strike"))) { brawler.CloseWeaponMastery },
                }
            };
        }
    }
}
