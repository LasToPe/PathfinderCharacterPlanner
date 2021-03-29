using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class WildChild : Archetype
    {
        public WildChild(Classes.Brawler brawler)
        {
            Name = "Wild Child";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Animal Companion",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BonusCombatFeat2, brawler.BonusCombatFeat8, brawler.BonusCombatFeat14, brawler.BonusCombatFeat20 },
                },
                new ArchetypeAbility
                {
                    Name = "Hunter’s Tricks",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { brawler.CloseWeaponMastery },
                },
            };

            ArchetypeAbilities.AddRange(brawler.ClassAbilities
                .Where(a => a.Name.Contains("Maneuver Training"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            for (int i = 5; i < 20; i += 6)
                ArchetypeAbilities.Add(new ArchetypeAbility
                {
                    Name = "Wild Trick",
                    Level = i,
                    ReplacedAbilities = new List<ClassAbility>(brawler.ClassAbilities.Where(a => a.Name.Contains("Bonus Combat Feat") && a.Level == i))
                });
        }
    }
}
