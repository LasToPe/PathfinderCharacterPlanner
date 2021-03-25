using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Oozemaster : Archetype
    {
        public Oozemaster(Classes.Alchemist alchemist)
        {
            Name = "Oozemaster";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Ooze Toxin",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion }
                },
                new ArchetypeAbility
                {
                    Name = "Ooze Resistance +2",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Poison Resistance"))) { alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Ooze Resistance +3",
                    Level = 5
                },
                new ArchetypeAbility
                {
                    Name = "Ooze Resistance +4",
                    Level = 8
                },
                new ArchetypeAbility
                {
                    Name = "Ooze Resistance +5",
                    Level = 11
                },
                new ArchetypeAbility
                {
                    Name = "Ooze Resistance +6",
                    Level = 14
                },
                new ArchetypeAbility
                {
                    Name = "Ooze Resistance +7",
                    Level = 17
                },
                new ArchetypeAbility
                {
                    Name = "Ooze Resistance +8",
                    Level = 20
                },
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility 
                { 
                    Name = a.Name.Replace("Bomb", "Ooze Bomb"), 
                    Level = a.Level, 
                    ReplacedAbilities = new List<ClassAbility> { a } 
                }));
        }
    }
}
