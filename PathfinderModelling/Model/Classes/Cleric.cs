using PathfinderModelling.Model.Archetypes.Cleric;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Cleric : CharacterClass
    {
        public Cleric()
        {
            Name = "Cleric";
            Alignment = "Within one step of her deity";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, 3, 1),
                    new CasterLevel( 2, 4, 2),
                    new CasterLevel( 3, 4, 2, 1),
                    new CasterLevel( 4, 4, 3, 2),
                    new CasterLevel( 5, 4, 3, 2, 1),
                    new CasterLevel( 6, 4, 3, 3, 2),
                    new CasterLevel( 7, 4, 4, 3, 2, 1),
                    new CasterLevel( 8, 4, 4, 3, 3, 2),
                    new CasterLevel( 9, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(10, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(11, 4, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(12, 4, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(13, 4, 4, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(14, 4, 4, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(15, 4, 4, 4, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(16, 4, 4, 4, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(17, 4, 4, 4, 4, 4, 4, 4, 3, 2, 1),
                    new CasterLevel(18, 4, 4, 4, 4, 4, 4, 4, 3, 3, 2),
                    new CasterLevel(19, 4, 4, 4, 4, 4, 4, 4, 4, 3, 3),
                    new CasterLevel(20, 4, 4, 4, 4, 4, 4, 4, 4, 4, 4),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                Aura,
                ChannelEnergy1,
                ChannelEnergy2,
                ChannelEnergy3,
                ChannelEnergy4,
                ChannelEnergy5,
                ChannelEnergy6,
                ChannelEnergy7,
                ChannelEnergy8,
                ChannelEnergy9,
                ChannelEnergy10,
                Domains,
                Spells,
                SpontaneousCasting,
                Orisons,
            };

            Archetypes.Add(new AngelfireApostle(this));
            Archetypes.Add(new Appeaser(this));
            Archetypes.Add(new AsmodeanAdvocate(this));
            Archetypes.Add(new BlossomingLight(this));
            Archetypes.Add(new Cardinal(this));
            Archetypes.Add(new ChannelerOfTheUnknown(this));
            Archetypes.Add(new CloisteredCleric(this));
            Archetypes.Add(new CrashingWave(this));
            Archetypes.Add(new Crusader(this));
            Archetypes.Add(new DemonicApostle(this));
            Archetypes.Add(new DivineParagon(this));
            Archetypes.Add(new DivineScourge(this));
            Archetypes.Add(new DivineStrategist(this));
        }

        public void DiminishedSpellCasting(bool activate)
        {
            if (activate)
            {
                foreach (var level in SpellCasting.CasterLevels)
                {
                    level.ZerothLevelSpells -= 1;
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
            if (!activate)
            {
                foreach (var level in SpellCasting.CasterLevels)
                {
                    level.ZerothLevelSpells += 1;
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
            }
        }

        readonly ClassAbility _aura = new ClassAbility { Name = "Aura", Level = 1 };
        readonly ClassAbility _channelEnergy1 = new ClassAbility { Name = "Channel Energy 1d6", Level = 1 };
        readonly ClassAbility _channelEnergy2 = new ClassAbility { Name = "Channel Energy 2d6", Level = 3 };
        readonly ClassAbility _channelEnergy3 = new ClassAbility { Name = "Channel Energy 3d6", Level = 5 };
        readonly ClassAbility _channelEnergy4 = new ClassAbility { Name = "Channel Energy 4d6", Level = 7 };
        readonly ClassAbility _channelEnergy5 = new ClassAbility { Name = "Channel Energy 5d6", Level = 9 };
        readonly ClassAbility _channelEnergy6 = new ClassAbility { Name = "Channel Energy 6d6", Level = 11 };
        readonly ClassAbility _channelEnergy7 = new ClassAbility { Name = "Channel Energy 7d6", Level = 13 };
        readonly ClassAbility _channelEnergy8 = new ClassAbility { Name = "Channel Energy 8d6", Level = 15 };
        readonly ClassAbility _channelEnergy9 = new ClassAbility { Name = "Channel Energy 9d6", Level = 17 };
        readonly ClassAbility _channelEnergy10 = new ClassAbility { Name = "Channel Energy 10d6", Level = 19 };
        readonly ClassAbility _domains = new ClassAbility { Name = "Domains", Level = 1 };
        readonly ClassAbility _spells = new ClassAbility { Name = "Spells", Level = 1 };
        readonly ClassAbility _spontaneousCasting = new ClassAbility { Name = "Spontaneous Casting", Level = 1 };
        readonly ClassAbility _orisons = new ClassAbility { Name = "Orisons", Level = 1 };

        public ClassAbility Aura => _aura;
        public ClassAbility ChannelEnergy1 => _channelEnergy1;
        public ClassAbility ChannelEnergy2 => _channelEnergy2;
        public ClassAbility ChannelEnergy3 => _channelEnergy3;
        public ClassAbility ChannelEnergy4 => _channelEnergy4;
        public ClassAbility ChannelEnergy5 => _channelEnergy5;
        public ClassAbility ChannelEnergy6 => _channelEnergy6;
        public ClassAbility ChannelEnergy7 => _channelEnergy7;
        public ClassAbility ChannelEnergy8 => _channelEnergy8;
        public ClassAbility ChannelEnergy9 => _channelEnergy9;
        public ClassAbility ChannelEnergy10 => _channelEnergy10;
        public ClassAbility Domains => _domains;
        public ClassAbility Spells => _spells;
        public ClassAbility SpontaneousCasting => _spontaneousCasting;
        public ClassAbility Orisons => _orisons;
    }
}
