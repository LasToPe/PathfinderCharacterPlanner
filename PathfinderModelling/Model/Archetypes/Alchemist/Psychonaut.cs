using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Psychonaut : Archetype
    {
        public Psychonaut(Classes.Alchemist alchemist)
        {
            Name = "Psychonaut";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Precognition",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance4 }
                },
                new ArchetypeAbility
                {
                    Name = "Psychic Senses",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6 }
                },
                new ArchetypeAbility
                {
                    Name = "Remote Consciousness",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Greater Precognition",
                    Level = 15,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Bomb") && a.Level == 15))
                },
                new ArchetypeAbility
                {
                    Name = "Master Precognition",
                    Level = 17,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Bomb") && a.Level == 17))
                },
                new ArchetypeAbility
                {
                    Name = "Bomb 8d4",
                    Level = 19,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Bomb") && a.Level == 19))
                }
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb") && a.Level < 15)
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("d6", "d4"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a }
                }));
        }
    }
}
