using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class ShadowPuppeteer : Archetype
    {
        public ShadowPuppeteer(Classes.Bard bard)
        {
            Name = "Shadow Puppeteer";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Shadow Servant",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Courage")))
                },
                new ArchetypeAbility
                {
                    Name = "Shadow Puppets",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence")))
                }
            };
        }
    }
}
