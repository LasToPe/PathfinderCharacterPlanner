using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Bard : CharacterClass
    {
        public Bard()
        {
            Name = "Bard";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Good;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Bardic Knowledge", Level = 1 },
                new ClassAbility { Name = "Bardic Performance", Level = 1 },
                new ClassAbility { Name = "Cantrips", Level = 1 },
                new ClassAbility { Name = "Countersong", Level = 1 },
                new ClassAbility { Name = "Distraction", Level = 1 },
                new ClassAbility { Name = "Fascinate", Level = 1 },
                new ClassAbility { Name = "Inspire Courage +1", Level = 1 },
                new ClassAbility { Name = "Inspire Courage +2", Level = 5 },
                new ClassAbility { Name = "Inspire Courage +3", Level = 11 },
                new ClassAbility { Name = "Inspire Courage +4", Level = 17 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Inspire Competence +2", Level = 3 },
                new ClassAbility { Name = "Inspire Competence +3", Level = 7 },
                new ClassAbility { Name = "Inspire Competence +4", Level = 11 },
                new ClassAbility { Name = "Inspire Competence +5", Level = 15 },
                new ClassAbility { Name = "Inspire Competence +6", Level = 19 },
                new ClassAbility { Name = "Suggestion", Level = 6 },
                new ClassAbility { Name = "Dirge of Doom", Level = 8 },
                new ClassAbility { Name = "Inspire Greatness", Level = 9 },
                new ClassAbility { Name = "Soothing Performance", Level = 12 },
                new ClassAbility { Name = "Frightening Tune", Level = 14 },
                new ClassAbility { Name = "Inspire Heroics", Level = 15 },
                new ClassAbility { Name = "Mass Suggestion", Level = 18 },
                new ClassAbility { Name = "Deadly Performance", Level = 20 },
                new ClassAbility { Name = "Veratile Performance", Level = 2 },
                new ClassAbility { Name = "Veratile Performance", Level = 6 },
                new ClassAbility { Name = "Veratile Performance", Level = 10 },
                new ClassAbility { Name = "Veratile Performance", Level = 14 },
                new ClassAbility { Name = "Veratile Performance", Level = 18 },
                new ClassAbility { Name = "Lore Master 1/day", Level = 5 },
                new ClassAbility { Name = "Lore Master 2/day", Level = 11 },
                new ClassAbility { Name = "Lore Master 3/day", Level = 17 },
                new ClassAbility { Name = "Jack-of-All-Trades", Level = 10 },
            };
        }
    }
}
