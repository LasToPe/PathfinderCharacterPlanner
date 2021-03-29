using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Brawler
{
    class Hinyasi : Archetype
    {
        public Hinyasi(Classes.Brawler brawler)
        {
            Name = "Hinyasi";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Humble Beginnings",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Improvisation Training",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { brawler.BonusCombatFeat2 },
                },
                new ArchetypeAbility
                {
                    Name = "Improvisation Mastery",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { brawler.CloseWeaponMastery },
                }
            };

            ArchetypeAbilities.AddRange(brawler.ClassAbilities
                .Where(a => a.Name.Contains("Knockout"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Improvised Maneuver",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
