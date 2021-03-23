using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Mesmerist :  CharacterClass
    {
        public Mesmerist()
        {
            Name = "Mesmerist";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting()
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null, 1),
                    new CasterLevel( 2, null, 2),
                    new CasterLevel( 3, null, 3),
                    new CasterLevel( 4, null, 3, 1),
                    new CasterLevel( 5, null, 4, 2),
                    new CasterLevel( 6, null, 4, 3),
                    new CasterLevel( 7, null, 4, 3, 1),
                    new CasterLevel( 8, null, 4, 4, 2),
                    new CasterLevel( 9, null, 5, 4, 3),
                    new CasterLevel(10, null, 5, 4, 3, 1),
                    new CasterLevel(11, null, 5, 4, 4, 2),
                    new CasterLevel(12, null, 5, 5, 4, 3),
                    new CasterLevel(13, null, 5, 5, 4, 3, 1),
                    new CasterLevel(14, null, 5, 5, 4, 4, 2),
                    new CasterLevel(15, null, 5, 5, 5, 4, 3),
                    new CasterLevel(16, null, 5, 5, 5, 4, 3, 1),
                    new CasterLevel(17, null, 5, 5, 5, 4, 4, 2),
                    new CasterLevel(18, null, 5, 5, 5, 5, 4, 3),
                    new CasterLevel(19, null, 5, 5, 5, 5, 5, 4),
                    new CasterLevel(20, null, 5, 5, 5, 5, 5, 5),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Consummate Liar", Level = 1 },
                new ClassAbility { Name = "Hypnotic Stare (-2)", Level = 1 },
                new ClassAbility { Name = "Hypnotic Stare (-3)", Level = 8 },
                new ClassAbility { Name = "Knacks", Level = 1 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 1 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 2 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 4 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 6 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 8 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 10 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 12 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 14 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 16 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 18 },
                new ClassAbility { Name = "Mesmerist Trick", Level = 20 },
                new ClassAbility { Name = "Painful Stare", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Towering Ego", Level = 2 },
                new ClassAbility { Name = "Bold Stare", Level = 3 },
                new ClassAbility { Name = "Bold Stare", Level = 7 },
                new ClassAbility { Name = "Bold Stare", Level = 11 },
                new ClassAbility { Name = "Bold Stare", Level = 15 },
                new ClassAbility { Name = "Bold Stare", Level = 19 },
                new ClassAbility { Name = "Touch Treatment (minor)", Level = 3 },
                new ClassAbility { Name = "Touch Treatment (moderate)", Level = 3 },
                new ClassAbility { Name = "Touch Treatment (greater)", Level = 3 },
                new ClassAbility { Name = "Touch Treatment (break enchantment)", Level = 3 },
                new ClassAbility { Name = "Manifold Tricks (2)", Level = 5 },
                new ClassAbility { Name = "Manifold Tricks (3)", Level = 9 },
                new ClassAbility { Name = "Manifold Tricks (4)", Level = 13 },
                new ClassAbility { Name = "Manifold Tricks (5)", Level = 17 },
                new ClassAbility { Name = "Mental Potency", Level = 5 },
                new ClassAbility { Name = "Glib Lie", Level = 11 },
                new ClassAbility { Name = "Masterful Tricks", Level = 12 },
                new ClassAbility { Name = "Rule Minds", Level = 20 },
            };
        }
    }
}
