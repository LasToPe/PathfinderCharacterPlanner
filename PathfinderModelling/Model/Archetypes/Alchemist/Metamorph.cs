using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Metamorph : Archetype
    {
        public Metamorph(Classes.Alchemist alchemist)
        {
            Name = "Metamorph";
            // Class skills
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Shapechanger 1/day",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(alchemist.ClassAbilities.Where(a => a.Name.Contains("Bomb"))) { alchemist.Alchemy, alchemist.Extracts, alchemist.Mutagen, alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger 2/day",
                    Level = 4
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger 3/day",
                    Level = 6
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger 4/day",
                    Level = 8
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger 5/day",
                    Level = 10
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger 6/day",
                    Level = 12
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger 7/day",
                    Level = 14
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger 8/day",
                    Level = 16
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger 9/day",
                    Level = 18
                },
                new ArchetypeAbility
                {
                    Name = "Shapechanger At Will",
                    Level = 20
                },
                new ArchetypeAbility
                {
                    Name = "Mutagen",
                    Level = 1
                },
                new ArchetypeAbility
                {
                    Name = "Adaptive Physiology 25%",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftAlchemy }
                },
                new ArchetypeAbility
                {
                    Name = "Adaptive Physiology 50%",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.SwiftPoisoning }
                },
                new ArchetypeAbility
                {
                    Name = "Adaptive Physiology 75%",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.InstantAlchemy }
                },
            };
        }
    }
}
