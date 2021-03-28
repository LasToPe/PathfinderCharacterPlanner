using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class DiscipleOfTheForkedTongue : Archetype
    {
        public DiscipleOfTheForkedTongue(Classes.Bard bard)
        {
            Name = "Disciple of the Forked Tongue";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Venomous Whispers",
                    Level = 9,
                    ReplacedAbilities = new List<ClassAbility> { bard.InspireGreatness },
                }
            };

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Inspire Courage"))
                .Select(a => new ArchetypeAbility
                {
                    Name = a.Name.Replace("Inspire Courage +", "Discordant Spiral -"),
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));

            ArchetypeAbilities.AddRange(bard.ClassAbilities
                .Where(a => a.Name.Contains("Versatile Performance"))
                .Select(a => new ArchetypeAbility
                {
                    Name = "Serpent of the Mind",
                    Level = a.Level,
                    ReplacedAbilities = new List<ClassAbility> { a },
                }));
        }
    }
}
