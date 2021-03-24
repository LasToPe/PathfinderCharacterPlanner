using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Herbalist : Archetype
    {
        public Herbalist(Classes.Alchemist alchemist)
        {
            Name = "Herbalist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Natural Magic",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = "Seedpods 1d6",
                    Level = alchemist.Bomb1.Level,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Bomb1, alchemist.PoisonUse, alchemist.PoisonResistance2, alchemist.PoisonResistance4, alchemist.PoisonResistance6, alchemist.PoisonImmunity }
                },
            };

            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Skip(1)
                .Select(a => new ArchetypeAbility 
                { 
                    Name = a.Name.Replace("Bomb", "Seedpods"), 
                    Level = a.Level, 
                    ReplacedAbilities = new List<ClassAbility> { a } 
                }));
        }
    }
}
