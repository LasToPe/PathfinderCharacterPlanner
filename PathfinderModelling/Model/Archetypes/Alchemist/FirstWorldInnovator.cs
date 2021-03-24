using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class FirstWorldInnovator : Archetype
    {
        public FirstWorldInnovator(Classes.Alchemist alchemist)
        {
            Name = "First World Innovator";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Primal Reagents",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion, alchemist.PoisonUse, alchemist.SwiftPoisoning, alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Refined Reagents",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6 }
                }
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility 
                { 
                    Name = "Limited " + a.Name, 
                    Level = a.Level, 
                    ReplacedAbilities = new List<ClassAbility> { a } 
                }));
        }
    }
}
