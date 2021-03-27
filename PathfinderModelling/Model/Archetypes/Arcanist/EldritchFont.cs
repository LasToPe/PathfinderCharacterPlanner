using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Arcanist
{
    class EldritchFont : Archetype
    {
        public EldritchFont(Classes.Arcanist arcanist)
        {
            Name = "Eldritch Font";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Font of Power",
                    Level = 1,
                    Add = () =>
                    {
                        foreach (var level in arcanist.SpellCasting.CasterLevels)
                        {
                            level.FirstLevelSpells += 1;
                            level.SecondLevelSpells += 1;
                            level.ThirdLevelSpells += 1;
                            level.FourthLevelSpells += 1;
                            level.FifthLevelSpells += 1;
                            level.SixthLevelSpells += 1;
                            level.SeventhLevelSpells += 1;
                            level.EighthLevelSpells += 1;
                            level.NinthLevelSpells += 1;
                        }
                    },
                    Remove = () =>
                    {
                        foreach (var level in arcanist.SpellCasting.CasterLevels)
                        {
                            level.FirstLevelSpells -= 1;
                            level.SecondLevelSpells -= 1;
                            level.ThirdLevelSpells -= 1;
                            level.FourthLevelSpells -= 1;
                            level.FifthLevelSpells -= 1;
                            level.SixthLevelSpells -= 1;
                            level.SeventhLevelSpells -= 1;
                            level.EighthLevelSpells -= 1;
                            level.NinthLevelSpells -= 1;
                        }
                    }
                },
                new ArchetypeAbility
                {
                    Name = "Eldritch Surge",
                    Level = 3,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit3 }
                },
                new ArchetypeAbility
                {
                    Name = "Improved Surge",
                    Level = 7,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit7 }
                },
                new ArchetypeAbility
                {
                    Name = "Greater Surge",
                    Level = 13,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.ArcanistExploit13 }
                },
                new ArchetypeAbility
                {
                    Name = "Bottomless Well",
                    Level = 20,
                    ReplacedAbilities = new List<ClassAbility> { arcanist.MagicalSupremacy }
                },
            };
        }
    }
}
