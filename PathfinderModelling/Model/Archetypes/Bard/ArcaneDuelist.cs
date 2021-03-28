using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Archetypes.Bard
{
    class ArcaneDuelist : Archetype
    {
        public ArcaneDuelist(Classes.Bard bard)
        {
            Name = "Arcane Duelist";
            ArchetypeAbilities = new List<ArchetypeAbility>
            {
                new ArchetypeAbility
                {
                    Name = "Arcane Strike",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.BardicKnowledge },
                },
                new ArchetypeAbility
                {
                    Name = "Rallying Cry",
                    Level = 1,
                    ReplacedAbilities = new List<ClassAbility> { bard.Countersong },
                },
                new ArchetypeAbility
                {
                    Name = "Bladethirst",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.Suggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Mass Bladethirst",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { bard.MassSuggestion },
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat: Combat Casting",
                    Level = 2,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance2, bard.WellVersed },
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat: Disruptive",
                    Level = 6,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance6 },
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat: Spellbreaker",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance10 },
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat: Penetrating Strike",
                    Level = 14,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance14 },
                },
                new ArchetypeAbility
                {
                    Name = "Bonus Feat: Greater Penetrating Strike",
                    Level = 18,
                    ReplacedAbilities = new List<ClassAbility> { bard.VersatilePerformance18 },
                },
                new ArchetypeAbility
                {
                    Name = "Arcane Bond",
                    Level = 5,
                    ReplacedAbilities = new List<ClassAbility> { bard.LoreMaster1, bard.LoreMaster2, bard.LoreMaster3 },
                },
                new ArchetypeAbility
                {
                    Name = "Arcane Armor (medium)",
                    Level = 10,
                    ReplacedAbilities = new List<ClassAbility> { bard.JackOfAllTrades },
                },
                new ArchetypeAbility
                {
                    Name = "Arcane Armor (heavy)",
                    Level = 16,
                }
            };
        }
    }
}
