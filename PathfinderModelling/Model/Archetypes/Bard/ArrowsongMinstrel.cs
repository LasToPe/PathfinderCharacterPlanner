using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class ArrowsongMinstrel : Archetype
    {
        public ArrowsongMinstrel(Classes.Bard bard)
        {
            Name = "Arrowsong Minstrel";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Diminished Spellcasting",
                    Level = 1,
                    Add = () =>
                    {
                        foreach (var level in bard.SpellCasting.CasterLevels)
                        {
                            level.FirstLevelSpells -= 1;
                            level.SecondLevelSpells -= 1;
                            level.ThirdLevelSpells -= 1;
                            level.FourthLevelSpells -= 1;
                            level.FifthLevelSpells -= 1;
                            level.SixthLevelSpells -= 1;
                        }
                    },
                    Remove = () =>
                    {
                        foreach (var level in bard.SpellCasting.CasterLevels)
                        {
                            level.FirstLevelSpells += 1;
                            level.SecondLevelSpells += 1;
                            level.ThirdLevelSpells += 1;
                            level.FourthLevelSpells += 1;
                            level.FifthLevelSpells += 1;
                            level.SixthLevelSpells += 1;
                        }
                    }
                },
                new ArchetypeAbility
                {
                    Name = "Arcane Archery",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility>(bard.ClassAbilities.Where(a => a.Name.Contains("Inspire Competence") || a.Name.Contains("Lore Master"))) 
                    { 
                        bard.BardicKnowledge, 
                        bard.DirgeOfDoom, 
                        bard.Distraction, 
                        bard.Fascinate, 
                        bard.SoothingPerformance 
                    },
                },
                new ArchetypeAbility
                {
                    Name = "Precise Minstrel",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance2, bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Arrowsong Strike",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion, bard.MassSuggestion },
                }
            };
        }
    }
}
