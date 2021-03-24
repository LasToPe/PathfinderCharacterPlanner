using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class IceChemist : Archetype
    {
        public IceChemist(Classes.Alchemist alchemist)
        {
            Name = "Ice Chemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Cold Sweat",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6, alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Frost Bomb",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Discovery2 }
                }
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility 
                { 
                    Name = a.Name.Replace("Bomb", "Icy Bombs"), 
                    Level = a.Level, 
                    ReplacedAbilities = new List<ClassAbility> { a } 
                }));
        }
    }
}
