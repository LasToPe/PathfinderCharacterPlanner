using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Antipaladin
{
    class Insinuator : Archetype
    {
        public Insinuator(Classes.Antipaladin antipaladin)
        {
            Name = "Insinuator";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Alignment",
                    Level = 1,
                    Add = () => antipaladin.Alignment = "Any Evil",
                    Remove = () => antipaladin.Alignment = "Chaotic Evil"
                },
                new ArchetypeAbility
                {
                    Name = "Code of Conduct",
                    Level = 1,
                },
                new ArchetypeAbility
                {
                    Name = "Invocation",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfEvil }
                },
                new ArchetypeAbility
                {
                    Name = "Detect Balance",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.DetectGood }
                },
                new ArchetypeAbility
                {
                    Name = "Selfish Healing",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.TouchOfCorruption }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Ego",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfCowardice }
                },
                new ArchetypeAbility
                {
                    Name = "Stubborn Health",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.PlagueBrunger }
                },
                new ArchetypeAbility
                {
                    Name = "Channel Energy",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.ChannelNegativeEnergy }
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = 4,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.Spells },
                    Add = () => antipaladin.SpellCaster = false,
                    Remove = () => antipaladin.SpellCaster = true,
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = 7,
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = 10,
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = 13,
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = 16,
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat",
                    Level = 19,
                },
                new ArchetypeAbility
                {
                    Name = "Ambitious Bond",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.FiendishBoon }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Ambition",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfDespair }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Glory",
                    Level = 11,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfVengeance }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Belief",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfSin }
                },
                new ArchetypeAbility
                {
                    Name = "Aura of Indomitability",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.AuraOfDepravity }
                },
                new ArchetypeAbility
                {
                    Name = "Personal Champion",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { antipaladin.UnholyChampion }
                },
            };

            ArchetypeAbilities.AddRange(antipaladin.ClassAbilities
                .Where(a => a.Name.Contains("Smite"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Good", "Inpudence"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
            ArchetypeAbilities.AddRange(antipaladin.ClassAbilities
                .Where(a => a.Name.Contains("Cruelty"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Greed",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
