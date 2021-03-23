using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Paladin : CharacterClass
    {
        public Paladin()
        {
            Name = "Paladin";
            Alignment = "Lawful Good";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null),
                    new CasterLevel( 2, null),
                    new CasterLevel( 3, null),
                    new CasterLevel( 4, null, 0),
                    new CasterLevel( 5, null, 1),
                    new CasterLevel( 6, null, 1),
                    new CasterLevel( 7, null, 1, 0),
                    new CasterLevel( 8, null, 1, 1),
                    new CasterLevel( 9, null, 2, 1),
                    new CasterLevel(10, null, 2, 1, 0),
                    new CasterLevel(11, null, 2, 1, 1),
                    new CasterLevel(12, null, 2, 2, 1),
                    new CasterLevel(13, null, 3, 2, 1, 0),
                    new CasterLevel(14, null, 3, 2, 1, 1),
                    new CasterLevel(15, null, 3, 2, 2, 1),
                    new CasterLevel(16, null, 3, 3, 2, 1),
                    new CasterLevel(17, null, 4, 3, 2, 1),
                    new CasterLevel(18, null, 4, 3, 2, 2),
                    new CasterLevel(19, null, 4, 3, 3, 2),
                    new CasterLevel(20, null, 4, 4, 3, 3),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                _auraOfGood,
                _detectEvil,
                _smiteEvil1,
                _smiteEvil2,
                _smiteEvil3,
                _smiteEvil4,
                _smiteEvil5,
                _smiteEvil6,
                _smiteEvil7,
                _layOnHands,
                _divineGrace,
                _auraOfCourage,
                _divineHealth,
                _mercy3,
                _mercy6,
                _mercy9,
                _mercy12,
                _mercy15,
                _mercy18,
                _channelPositiveEnergy,
                _spells,
                _divineBond,
                _auraOfResolve,
                _auraOfJustice,
                _auraOfFaith,
                _auraOfRighteousness,
                _holyChampion,
            };

            Archetypes.Add(VirtuousBravo);
        }

        #region Class Abilities
        ClassAbility _auraOfGood = new ClassAbility { Name = "Aura of Good", Level = 1 };
        ClassAbility _detectEvil = new ClassAbility { Name = "Detect Evil", Level = 1 };
        ClassAbility _smiteEvil1 = new ClassAbility { Name = "Smite Evil 1/day", Level = 1 };
        ClassAbility _smiteEvil2 = new ClassAbility { Name = "Smite Evil 2/day", Level = 4 };
        ClassAbility _smiteEvil3 = new ClassAbility { Name = "Smite Evil 3/day", Level = 7 };
        ClassAbility _smiteEvil4 = new ClassAbility { Name = "Smite Evil 4/day", Level = 10 };
        ClassAbility _smiteEvil5 = new ClassAbility { Name = "Smite Evil 5/day", Level = 13 };
        ClassAbility _smiteEvil6 = new ClassAbility { Name = "Smite Evil 6/day", Level = 16 };
        ClassAbility _smiteEvil7 = new ClassAbility { Name = "Smite Evil 7/day", Level = 19 };
        ClassAbility _layOnHands = new ClassAbility { Name = "Lay on Hands", Level = 2 };
        ClassAbility _divineGrace = new ClassAbility { Name = "Divine Grace", Level = 2 };
        ClassAbility _auraOfCourage = new ClassAbility { Name = "Aura of Courage", Level = 3 };
        ClassAbility _divineHealth = new ClassAbility { Name = "Divine Health", Level = 3 };
        ClassAbility _mercy3 = new ClassAbility { Name = "Mercy", Level = 3 };
        ClassAbility _mercy6 = new ClassAbility { Name = "Mercy", Level = 6 };
        ClassAbility _mercy9 = new ClassAbility { Name = "Mercy", Level = 9 };
        ClassAbility _mercy12 = new ClassAbility { Name = "Mercy", Level = 12 };
        ClassAbility _mercy15 = new ClassAbility { Name = "Mercy", Level = 15 };
        ClassAbility _mercy18 = new ClassAbility { Name = "Mercy", Level = 18 };
        ClassAbility _channelPositiveEnergy = new ClassAbility { Name = "Channel Positive Energy", Level = 4 };
        ClassAbility _spells = new ClassAbility { Name = "Spells", Level = 4 };
        ClassAbility _divineBond = new ClassAbility { Name = "Divine Bond", Level = 5 };
        ClassAbility _auraOfResolve = new ClassAbility { Name = "Aura of Resolve", Level = 8 };
        ClassAbility _auraOfJustice = new ClassAbility { Name = "Aura of Justice", Level = 11 };
        ClassAbility _auraOfFaith = new ClassAbility { Name = "Aura of Faith", Level = 14 };
        ClassAbility _auraOfRighteousness = new ClassAbility { Name = "Aura of Righteousness", Level = 17 };
        ClassAbility _holyChampion = new ClassAbility { Name = "Holy Champion", Level = 20 };
        #endregion

        Archetype VirtuousBravo
        {
            get
            {
                return new Archetype
                {
                    Name = "Virtuous Bravo",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Finesse",
                            Level = 1
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Smite 1/day",
                            Level = _smiteEvil1.Level,
                            ReplacedAbilities = new List<ClassAbility> { _smiteEvil1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Smite 2/day",
                            Level = _smiteEvil2.Level,
                            ReplacedAbilities = new List<ClassAbility> { _smiteEvil2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Smite 3/day",
                            Level = _smiteEvil3.Level,
                            ReplacedAbilities = new List<ClassAbility> { _smiteEvil3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Smite 4/day",
                            Level = _smiteEvil4.Level,
                            ReplacedAbilities = new List<ClassAbility> { _smiteEvil4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Smite 5/day",
                            Level = _smiteEvil5.Level,
                            ReplacedAbilities = new List<ClassAbility> { _smiteEvil5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Smite 6/day",
                            Level = _smiteEvil6.Level,
                            ReplacedAbilities = new List<ClassAbility> { _smiteEvil6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Smite 7/day",
                            Level = _smiteEvil7.Level,
                            ReplacedAbilities = new List<ClassAbility> { _smiteEvil7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Nimble +1",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _mercy3, _mercy6, _mercy9, _mercy12, _mercy15, _mercy18 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Nimble +2",
                            Level = 7,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Nimble +3",
                            Level = 11,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Nimble +4",
                            Level = 15,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Nimble +5",
                            Level = 19,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Panache and Deeds",
                            Level = 4,
                            ReplacedAbilities = new List<ClassAbility> { _spells },
                            Add = () => SpellCaster = false,
                            Remove = () => SpellCaster = true,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Advanced Deeds",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _auraOfJustice }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bravo's Holy Strike",
                            Level = 20,
                            ReplacedAbilities = new List<ClassAbility> { _holyChampion }
                        }
                    }
                };
            }
        }
    }
}
