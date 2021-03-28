using PathfinderModelling.Model.Archetypes.Bard;
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
                BardicKnowledge,
                BardicPerformance,
                Cantrips,
                Countersong,
                Distraction,
                Fascinate,
                InspireCourage1,
                InspireCourage2,
                InspireCourage3,
                InspireCourage4,
                Spells,
                WellVersed,
                InspireCompetence2,
                InspireCompetence3,
                InspireCompetence4,
                InspireCompetence5,
                InspireCompetence6,
                Suggestion,
                DirgeOfDoom,
                InspireGreatness,
                SoothingPerformance,
                FrighteningTune,
                InspireHeroics,
                MassSuggestion,
                DeadlyPerformance,
                VersatilePerformance2,
                VersatilePerformance6,
                VersatilePerformance10,
                VersatilePerformance14,
                VersatilePerformance18,
                LoreMaster1,
                LoreMaster2,
                LoreMaster3,
                JackOfAllTrades,
            };

            Archetypes.Add(new AnimalSpeaker(this));
            Archetypes.Add(new ArcaneDuelist(this));
            Archetypes.Add(new ArcaneHealer(this));
            Archetypes.Add(new Archaeologist(this));
            Archetypes.Add(new Archivist(this));
            Archetypes.Add(new ArgentVoice(this));
            Archetypes.Add(new ArrowsongMinstrel(this));
            Archetypes.Add(new AverakaArbiter(this));
        }

        readonly ClassAbility _bardicKnowledge = new ClassAbility { Name = "Bardic Knowledge", Level = 1 };
        readonly ClassAbility _bardicPerformance = new ClassAbility { Name = "Bardic Performance", Level = 1 };
        readonly ClassAbility _cantrips = new ClassAbility { Name = "Cantrips", Level = 1 };
        readonly ClassAbility _countersong = new ClassAbility { Name = "Countersong", Level = 1 };
        readonly ClassAbility _distraction = new ClassAbility { Name = "Distraction", Level = 1 };
        readonly ClassAbility _fascinate = new ClassAbility { Name = "Fascinate", Level = 1 };
        readonly ClassAbility _inspireCourage1 = new ClassAbility { Name = "Inspire Courage +1", Level = 1 };
        readonly ClassAbility _inspireCourage2 = new ClassAbility { Name = "Inspire Courage +2", Level = 5 };
        readonly ClassAbility _inspireCourage3 = new ClassAbility { Name = "Inspire Courage +3", Level = 11 };
        readonly ClassAbility _inspireCourage4 = new ClassAbility { Name = "Inspire Courage +4", Level = 17 };
        readonly ClassAbility _inspireCompetence2 = new ClassAbility { Name = "Inspire Competence +2", Level = 3 };
        readonly ClassAbility _inspireCompetence3 = new ClassAbility { Name = "Inspire Competence +3", Level = 7 };
        readonly ClassAbility _inspireCompetence4 = new ClassAbility { Name = "Inspire Competence +4", Level = 11 };
        readonly ClassAbility _inspireCompetence5 = new ClassAbility { Name = "Inspire Competence +5", Level = 15 };
        readonly ClassAbility _inspireCompetence6 = new ClassAbility { Name = "Inspire Competence +6", Level = 19 };
        readonly ClassAbility _suggestion = new ClassAbility { Name = "Suggestion", Level = 6 };
        readonly ClassAbility _dirgeOfDoom = new ClassAbility { Name = "Dirge of Doom", Level = 8 };
        readonly ClassAbility _inspireGreatness = new ClassAbility { Name = "Inspire Greatness", Level = 9 };
        readonly ClassAbility _soothingPerformance = new ClassAbility { Name = "Soothing Performance", Level = 12 };
        readonly ClassAbility _frighteningTune = new ClassAbility { Name = "Frightening Tune", Level = 14 };
        readonly ClassAbility _inspireHeroics = new ClassAbility { Name = "Inspire Heroics", Level = 15 };
        readonly ClassAbility _massSuggestion = new ClassAbility { Name = "Mass Suggestion", Level = 18 };
        readonly ClassAbility _deadlyPerformance = new ClassAbility { Name = "Deadly Performance", Level = 20 };
        readonly ClassAbility _spells = new ClassAbility { Name = "Spells", Level = 1 };
        readonly ClassAbility _wellVersed = new ClassAbility { Name = "Well-Versed", Level = 2 };
        readonly ClassAbility _versatilePerformance2 = new ClassAbility { Name = "Versatile Performance", Level = 2 };
        readonly ClassAbility _versatilePerformance6 = new ClassAbility { Name = "Versatile Performance", Level = 6 };
        readonly ClassAbility _versatilePerformance10 = new ClassAbility { Name = "Versatile Performance", Level = 10 };
        readonly ClassAbility _versatilePerformance14 = new ClassAbility { Name = "Versatile Performance", Level = 14 };
        readonly ClassAbility _versatilePerformance18 = new ClassAbility { Name = "Versatile Performance", Level = 18 };
        readonly ClassAbility _loreMaster1 = new ClassAbility { Name = "Lore Master 1/day", Level = 5 };
        readonly ClassAbility _loreMaster2 = new ClassAbility { Name = "Lore Master 2/day", Level = 11 };
        readonly ClassAbility _loreMaster3 = new ClassAbility { Name = "Lore Master 3/day", Level = 17 };
        readonly ClassAbility _jackOfAllTrades = new ClassAbility { Name = "Jack-of-All-Trades", Level = 10 };

        public ClassAbility BardicKnowledge => _bardicKnowledge;
        public ClassAbility BardicPerformance => _bardicPerformance;
        public ClassAbility Cantrips => _cantrips;
        public ClassAbility Countersong => _countersong;
        public ClassAbility Distraction => _distraction;
        public ClassAbility Fascinate => _fascinate;
        public ClassAbility InspireCourage1 => _inspireCourage1;
        public ClassAbility InspireCourage2 => _inspireCourage2;
        public ClassAbility InspireCourage3 => _inspireCourage3;
        public ClassAbility InspireCourage4 => _inspireCourage4;
        public ClassAbility InspireCompetence2 => _inspireCompetence2;
        public ClassAbility InspireCompetence3 => _inspireCompetence3;
        public ClassAbility InspireCompetence4 => _inspireCompetence4;
        public ClassAbility InspireCompetence5 => _inspireCompetence5;
        public ClassAbility InspireCompetence6 => _inspireCompetence6;
        public ClassAbility Suggestion => _suggestion;
        public ClassAbility DirgeOfDoom => _dirgeOfDoom;
        public ClassAbility InspireGreatness => _inspireGreatness;
        public ClassAbility SoothingPerformance => _soothingPerformance;
        public ClassAbility FrighteningTune => _frighteningTune;
        public ClassAbility InspireHeroics => _inspireHeroics;
        public ClassAbility MassSuggestion => _massSuggestion;
        public ClassAbility DeadlyPerformance => _deadlyPerformance;
        public ClassAbility Spells => _spells;
        public ClassAbility WellVersed => _wellVersed;
        public ClassAbility VersatilePerformance2 => _versatilePerformance2;
        public ClassAbility VersatilePerformance6 => _versatilePerformance6;
        public ClassAbility VersatilePerformance10 => _versatilePerformance10;
        public ClassAbility VersatilePerformance14 => _versatilePerformance14;
        public ClassAbility VersatilePerformance18 => _versatilePerformance18;
        public ClassAbility LoreMaster1 => _loreMaster1;
        public ClassAbility LoreMaster2 => _loreMaster2;
        public ClassAbility LoreMaster3 => _loreMaster3;
        public ClassAbility JackOfAllTrades => _jackOfAllTrades;
    }
}
