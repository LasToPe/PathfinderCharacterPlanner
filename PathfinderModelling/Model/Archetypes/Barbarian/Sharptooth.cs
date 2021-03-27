using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Barbarian
{
    class Sharptooth : Archetype
    {
        public Sharptooth(Classes.Barbarian barbarian)
        {
            Name = "Sharptooth";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Swim Like a Fish",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.FastMovement },
                },
                new ArchetypeAbility
                {
                    Name = "Scent of Blood",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.UncannyDodge, barbarian.ImprovedUncannyDodge },
                },
                new ArchetypeAbility
                {
                    Name = "Blood in the Water",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { barbarian.RagePower6, barbarian.RagePower12 },
                }
            };

            ArchetypeAbilities.AddRange(barbarian.ClassAbilities
                .Where(a => a.Name.Contains("Trap Sense"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Trap Sense", "Ocean Breath"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
