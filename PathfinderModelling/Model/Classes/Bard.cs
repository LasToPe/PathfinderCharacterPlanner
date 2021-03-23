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
                _bardicKnowledge,
                _bardicPerformance,
                _cantrips,
                _countersong,
                _distraction,
                _fascinate,
                _inspireCourage1,
                _inspireCourage2,
                _inspireCourage3,
                _inspireCourage4,
                _spells,
                _inspireCompetence2,
                _suggestion,
                _dirgeOfDoom,
                _inspireGreatness,
                _soothingPerformance,
                _frighteningTune,
                _inspireHeroics,
                _massSuggestion,
                _deadlyPerformance,
                _versatilePerformance2,
                _versatilePerformance6,
                _versatilePerformance10,
                _versatilePerformance14,
                _versatilePerformance18,
                _loreMaster1,
                _loreMaster2,
                _loreMaster3,
                _jackOfAllTrades
            };

            Archetypes.Add(DawnflowerDervish);
        }

        #region Class Abilities
        ClassAbility _bardicKnowledge = new ClassAbility { Name = "Bardic Knowledge", Level = 1 };
        ClassAbility _bardicPerformance = new ClassAbility { Name = "Bardic Performance", Level = 1 };
        ClassAbility _cantrips = new ClassAbility { Name = "Cantrips", Level = 1 };
        ClassAbility _countersong = new ClassAbility { Name = "Countersong", Level = 1 };
        ClassAbility _distraction = new ClassAbility { Name = "Distraction", Level = 1 };
        ClassAbility _fascinate = new ClassAbility { Name = "Fascinate", Level = 1 };
        ClassAbility _inspireCourage1 = new ClassAbility { Name = "Inspire Courage +1", Level = 1 };
        ClassAbility _inspireCourage2 = new ClassAbility { Name = "Inspire Courage +2", Level = 5 };
        ClassAbility _inspireCourage3 = new ClassAbility { Name = "Inspire Courage +3", Level = 11 };
        ClassAbility _inspireCourage4 = new ClassAbility { Name = "Inspire Courage +4", Level = 17 };
        ClassAbility _spells = new ClassAbility { Name = "Spells", Level = 1 };
        ClassAbility _inspireCompetence2 = new ClassAbility { Name = "Inspire Competence +2", Level = 3 };
        ClassAbility _inspireCompetence3 = new ClassAbility { Name = "Inspire Competence +3", Level = 7 };
        ClassAbility _inspireCompetence4 = new ClassAbility { Name = "Inspire Competence +4", Level = 11 };
        ClassAbility _inspireCompetence5 = new ClassAbility { Name = "Inspire Competence +5", Level = 15 };
        ClassAbility _inspireCompetence6 = new ClassAbility { Name = "Inspire Competence +6", Level = 19 };
        ClassAbility _suggestion = new ClassAbility { Name = "Suggestion", Level = 6 };
        ClassAbility _dirgeOfDoom = new ClassAbility { Name = "Dirge of Doom", Level = 8 };
        ClassAbility _inspireGreatness = new ClassAbility { Name = "Inspire Greatness", Level = 9 };
        ClassAbility _soothingPerformance = new ClassAbility { Name = "Soothing Performance", Level = 12 };
        ClassAbility _frighteningTune = new ClassAbility { Name = "Frightening Tune", Level = 14 };
        ClassAbility _inspireHeroics = new ClassAbility { Name = "Inspire Heroics", Level = 15 };
        ClassAbility _massSuggestion = new ClassAbility { Name = "Mass Suggestion", Level = 18 };
        ClassAbility _deadlyPerformance = new ClassAbility { Name = "Deadly Performance", Level = 20 };
        ClassAbility _versatilePerformance2 = new ClassAbility { Name = "Veratile Performance", Level = 2 };
        ClassAbility _versatilePerformance6 = new ClassAbility { Name = "Veratile Performance", Level = 6 };
        ClassAbility _versatilePerformance10 = new ClassAbility { Name = "Veratile Performance", Level = 10 };
        ClassAbility _versatilePerformance14 = new ClassAbility { Name = "Veratile Performance", Level = 14 };
        ClassAbility _versatilePerformance18 = new ClassAbility { Name = "Veratile Performance", Level = 18 };
        ClassAbility _loreMaster1 = new ClassAbility { Name = "Lore Master 1/day", Level = 5 };
        ClassAbility _loreMaster2 = new ClassAbility { Name = "Lore Master 2/day", Level = 11 };
        ClassAbility _loreMaster3 = new ClassAbility { Name = "Lore Master 3/day", Level = 17 };
        ClassAbility _jackOfAllTrades = new ClassAbility { Name = "Jack-of-All-Trades", Level = 10 };
        #endregion

        Archetype DawnflowerDervish
        {
            get
            {
                return new Archetype
                {
                    Name = "Dawnflower Dervish",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Deity",
                            Level = 1,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Battle Dance",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _bardicPerformance }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Dervish Dance",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _bardicKnowledge }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spinning Spellcaster",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _loreMaster1, _loreMaster2, _loreMaster3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Meditative Whirl",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { _dirgeOfDoom }
                        },
                    }
                };
            }
        }
    }
}
