using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class Bouncer : Archetype
    {
        public Bouncer(Classes.Brawler brawler)
        {
            Name = "Bouncer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Crowd Control",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Lesser Flexibility",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.MartialFlexibility },
                },
                new ArchetypeAbility
                {
                    Name = "Drunk Handler",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BonusCombatFeat2 },
                },
                new ArchetypeAbility
                {
                    Name = "Drunk Knockout",
                    Level = 4,
                },
                new ArchetypeAbility
                {
                    Name = "Bar Fight Mastery",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.CloseWeaponMastery },
                }
            };
        }
    }
}
