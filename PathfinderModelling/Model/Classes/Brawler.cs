using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Brawler : CharacterClass
    {
        public Brawler()
        {
            Name = "Brawler";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Brawler's Cunning", Level = 1 },
                new ClassAbility { Name = "Martial Flexibility", Level = 1 },
                new ClassAbility { Name = "Martial Training", Level = 1 },
                new ClassAbility { Name = "Unarmed Strike 1d6", Level = 1 },
                new ClassAbility { Name = "Unarmed Strike 1d8", Level = 4 },
                new ClassAbility { Name = "Unarmed Strike 1d10", Level = 8 },
                new ClassAbility { Name = "Unarmed Strike 2d6", Level = 12 },
                new ClassAbility { Name = "Unarmed Strike 2d8", Level = 16 },
                new ClassAbility { Name = "Unarmed Strike 2d10", Level = 20 },
                new ClassAbility { Name = "Bonus Combat Feat", Level = 2 },
                new ClassAbility { Name = "Bonus Combat Feat", Level = 5 },
                new ClassAbility { Name = "Bonus Combat Feat", Level = 8 },
                new ClassAbility { Name = "Bonus Combat Feat", Level = 11 },
                new ClassAbility { Name = "Bonus Combat Feat", Level = 14 },
                new ClassAbility { Name = "Bonus Combat Feat", Level = 17 },
                new ClassAbility { Name = "Bonus Combat Feat", Level = 20 },
                new ClassAbility { Name = "Brawler's Flurry (Two Weapon Fighting)", Level = 2 },
                new ClassAbility { Name = "Brawler's Flurry (Improved Two Weapon Fighting)", Level = 8 },
                new ClassAbility { Name = "Brawler's Flurry (Greater Two Weapon Fighting)", Level = 15 },
                new ClassAbility { Name = "Maneuver Training 1", Level = 3 },
                new ClassAbility { Name = "Maneuver Training 2", Level = 7 },
                new ClassAbility { Name = "Maneuver Training 3", Level = 11 },
                new ClassAbility { Name = "Maneuver Training 4", Level = 15 },
                new ClassAbility { Name = "Maneuver Training 5", Level = 19 },
                new ClassAbility { Name = "AC Bonus +1", Level = 4 },
                new ClassAbility { Name = "AC Bonus +2", Level = 9 },
                new ClassAbility { Name = "AC Bonus +3", Level = 13 },
                new ClassAbility { Name = "AC Bonus +4", Level = 18 },
                new ClassAbility { Name = "Knockout 1/day", Level = 4 },
                new ClassAbility { Name = "Knockout 2/day", Level = 10 },
                new ClassAbility { Name = "Knockout 3/day", Level = 16 },
                new ClassAbility { Name = "Brawler's Strike (Magic)", Level = 5 },
                new ClassAbility { Name = "Brawler's Strike (Cold Iron and Silver)", Level = 9 },
                new ClassAbility { Name = "Brawler's Strike (Alignment)", Level = 12 },
                new ClassAbility { Name = "Brawler's Strike (Adamantine)", Level = 17 },
                new ClassAbility { Name = "Close Weapon Mastery", Level = 5 },
                new ClassAbility { Name = "Awesome Blow", Level = 16 },
                new ClassAbility { Name = "Improved Awesome Blow", Level = 20 },
            };
        }
    }
}
