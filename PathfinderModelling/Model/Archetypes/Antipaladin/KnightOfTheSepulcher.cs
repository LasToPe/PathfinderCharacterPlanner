using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class KnightOfTheSepulcher : Archetype
    {
        public KnightOfTheSepulcher(Classes.Antipaladin antipaladin)
        {
            Name = "Knight of the Sepulcher";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Touch of the Crypt",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.FiendishBoon }
                },
                new ArchetypeAbility
                {
                    Name = "Fortitude of the Crypt",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin. AuraOfDespair }
                },
                new ArchetypeAbility
                {
                    Name = "Cloak of the Crypt",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.SmiteGood4 }
                },
                new ArchetypeAbility
                {
                    Name = "Will of the Crypt",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfVengeance }
                },
                new ArchetypeAbility
                {
                    Name = "Weapons of Sin",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfSin }
                },
                new ArchetypeAbility
                {
                    Name = "Crypt Lord",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility>(antipaladin.ClassAbilities.Where(a => a.Name.Contains("Cruelty")))
                },
                new ArchetypeAbility
                {
                    Name = "Soul of the Crypt",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfDepravity }
                },
                new ArchetypeAbility
                {
                    Name = "Undying Champion",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.UnholyChampion }
                }
            };

            ArchetypeAbilities.AddRange(antipaladin.ClassAbilities
                .Where(a => a.Name.Contains("Smite") && a.Level >= 10 && a.Level < 17)
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name,
                    Level = a.Level + 3,
                    ReplacedAbilities = new List<ClassAbility>(antipaladin.ClassAbilities.Where(ability => ability.Name.Contains("Smite") && ability.Level == a.Level + 3))
                }));
        }
    }
}
