using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Homunculist : Archetype
    {
        public Homunculist(Classes.Alchemist alchemist)
        {
            Name = "Homunculist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Diminished Poisoning",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Poison")))
                },
                new ArchetypeAbility
                {
                    Name = "Homunculus Familiar",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Experimentation 1",
                    Level = 4,
                },
                new ArchetypeAbility
                {
                    Name = "Experimentation 2",
                    Level = 8,
                },
                new ArchetypeAbility
                {
                    Name = "Experimentation 3",
                    Level = 12,
                },
                new ArchetypeAbility
                {
                    Name = "Experimentation 4",
                    Level = 16,
                },
                new ArchetypeAbility
                {
                    Name = "Experimentation 5",
                    Level = 20,
                },
            };
        }
    }
}
