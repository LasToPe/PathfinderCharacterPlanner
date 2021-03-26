using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class BlightedMyrmidon : Archetype
    {
        public BlightedMyrmidon(Classes.Antipaladin antipaladin)
        {
            Name = "Blighted Myrmidon";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Corrupted Companion",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.FiendishBoon }
                },
                new ArchetypeAbility
                {
                    Name = "Feed on Decay",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.SmiteGood4 }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Decay",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfVengeance }
                },
                new ArchetypeAbility
                {
                    Name = "Enervating Touch",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.Cruelty15 }
                },
                new ArchetypeAbility
                {
                    Name = "Unnatural Champion",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.UnholyChampion }
                }
            };

            ArchetypeAbilities.AddRange(antipaladin.ClassAbilities
                .Where(a => a.Name.Contains("Smite") && a.Level < 10)
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Good", "Nature"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));

            ArchetypeAbilities.AddRange(antipaladin.ClassAbilities
                .Where(a => a.Name.Contains("Smite") && a.Level >= 10 && a.Level < 17)
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Good", "Nature"),
                    Level = a.Level + 3,
                    ReplacedAbilities = new List<ClassAbility>(antipaladin.ClassAbilities.Where(ability => ability.Name.Contains("Smite") && ability.Level == a.Level + 3))
                }));
        }
    }
}
