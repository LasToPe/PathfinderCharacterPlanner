using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class PrometheanAlchemist : Archetype
    {
        public PrometheanAlchemist(Classes.Alchemist alchemist)
        {
            Name = "Promethean Alchemist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Craft Construct",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.BrewPotion, alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = "Homunculus Companion",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Bomb"))) { alchemist.Mutagen }
                }
            };
        }
    }
}
