using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Cavalier
{
    class FirstMothersFang : Archetype
    {
        public FirstMothersFang(Classes.Cavalier cavalier)
        {
            Name = "First Mother's Fang";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Serpent Mount",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Mount },
                },
                new ArchetypeAbility
                {
                    Name = "Honored Warrior",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { cavalier.Order },
                }
            };

            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Order Ability"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Vigilante Social Talent",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
            ArchetypeAbilities.AddRange(cavalier.ClassAbilities
                .Where(a => a.Name.Contains("Order Ability"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Bonus Combat Feat",
                    Level = a.Level,
                }));
        }
    }
}
