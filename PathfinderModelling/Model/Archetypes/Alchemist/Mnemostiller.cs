using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Alchemist
{
    class Mnemostiller : Archetype
    {
        public Mnemostiller(Classes.Alchemist alchemist)
        {
            Name = "Mnemostiller";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Mental Ambix",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Alchemy, alchemist.ThrowAnything }
                },
                new ArchetypeAbility
                {
                    Name = "Rasugen",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.Mutagen }
                },
                new ArchetypeAbility
                {
                    Name = "Brewed Memories 1",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance2 }
                },
                new ArchetypeAbility
                {
                    Name = "Brewed Memories 2",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance4 }
                },
                new ArchetypeAbility
                {
                    Name = "Brewed Memories 3",
                    Level = 8,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonResistance6, alchemist.PoisonImmunity }
                },
                new ArchetypeAbility
                {
                    Name = "Natural Empath",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { alchemist.PoisonUse }
                },
                new ArchetypeAbility
                {
                    Name = "Mind-Delver",
                    Level = 10,
                }
            };
            ArchetypeAbilities.AddRange(alchemist.ClassAbilities
                .Where(a => a.Name.Contains("Bomb"))
                .Select(a => new ArchetypeAbility 
                { 
                    Name = a.Name.Replace("Bomb", "Anguish Bomb"), 
                    Level = a.Level, 
                    ReplacedAbilities = new List<ClassAbility> { a } 
                }));
        }
    }
}
