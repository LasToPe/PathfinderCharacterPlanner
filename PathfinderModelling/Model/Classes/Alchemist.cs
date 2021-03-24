using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Alchemist : CharacterClass
    {
        public Alchemist()
        {
            Name = "Alchemist";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
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
                _alchemy,
                _bomb1,
                _bomb2,
                _bomb3,
                _bomb4,
                _bomb5,
                _bomb6,
                _bomb7,
                _bomb8,
                _bomb9,
                _bomb10,
                _brewPotion,
                _extracts,
                _mutagen,
                _throwAnything,
                _discovery2,
                _discovery4,
                _discovery6,
                _discovery8,
                _discovery10,
                _discovery12,
                _discovery14,
                _discovery16,
                _discovery18,
                _poisonResistance2,
                _poisonResistance4,
                _poisonResistance6,
                _poisonImmunity,
                _poisonUse,
                _swiftAlchemy,
                _swiftPoisoning,
                _persistentMutagen,
                _instantAlchemy,
                _grandDiscovery,
            };

            Archetypes.Add(Aerochemist);
            Archetypes.Add(AlchemicalSapper);
            Archetypes.Add(AlchemicalTrapper);
            Archetypes.Add(Aquachymist);
            Archetypes.Add(Beastmorph);
            Archetypes.Add(BlazingTorchbearer);
            Archetypes.Add(Blightseeker);
            Archetypes.Add(BloodAlchemist);
            Archetypes.Add(BogbornAlchemist);
            Archetypes.Add(BrambleBrewer);
            Archetypes.Add(Chirurgeon);
            Archetypes.Add(CloneMaster);
            Archetypes.Add(Concocter);
            Archetypes.Add(ConstructRider);
            Archetypes.Add(CrimsonChymist);
            Archetypes.Add(Cruourchymist);
            Archetypes.Add(CryptBreaker);
            Archetypes.Add(DeepBomber);
            Archetypes.Add(DimensionalExcavator);
            Archetypes.Add(DragonbloodChymist);
            Archetypes.Add(Ectochymist);
            Archetypes.Add(EctoplasmMaster);
            Archetypes.Add(EldritchPoisoner);
            Archetypes.Add(Energist);
            Archetypes.Add(EnergyScientist);
            Archetypes.Add(Fermenter);
            Archetypes.Add(FireBomber);
            Archetypes.Add(FirstWorldInnovator);
            Archetypes.Add(GloomChymist);
            Archetypes.Add(Grenadier);
            Archetypes.Add(GrenadierMC);
            Archetypes.Add(GunChemist);
            Archetypes.Add(Herbalist);
            Archetypes.Add(Homunculist);
            Archetypes.Add(Horticulturist);
            Archetypes.Add(IceChemist);
        }

        private void LimitedExtracts(bool activate)
        {
            if (activate)
            {
                foreach (var level in SpellCasting.CasterLevels)
                {
                    level.FirstLevelSpells -= 1;
                    level.SecondLevelSpells -= 1;
                    level.ThirdLevelSpells -= 1;
                    level.FourthLevelSpells -= 1;
                    level.FifthLevelSpells -= 1;
                    level.SixthLevelSpells -= 1;
                }
            }

            if (!activate)
            {
                foreach (var level in SpellCasting.CasterLevels)
                {
                    level.FirstLevelSpells += 1;
                    level.SecondLevelSpells += 1;
                    level.ThirdLevelSpells += 1;
                    level.FourthLevelSpells += 1;
                    level.FifthLevelSpells += 1;
                    level.SixthLevelSpells += 1;
                }
            }
        }

        #region ClassAbilities
        ClassAbility _alchemy = new ClassAbility { Name = "Alchemy", Level = 1 };
        ClassAbility _bomb1 = new ClassAbility { Name = "Bomb 1d6", Level = 1 };
        ClassAbility _bomb2 = new ClassAbility { Name = "Bomb 2d6", Level = 3 };
        ClassAbility _bomb3 = new ClassAbility { Name = "Bomb 3d6", Level = 5 };
        ClassAbility _bomb4 = new ClassAbility { Name = "Bomb 4d6", Level = 7 };
        ClassAbility _bomb5 = new ClassAbility { Name = "Bomb 5d6", Level = 9 };
        ClassAbility _bomb6 = new ClassAbility { Name = "Bomb 6d6", Level = 11 };
        ClassAbility _bomb7 = new ClassAbility { Name = "Bomb 7d6", Level = 13 };
        ClassAbility _bomb8 = new ClassAbility { Name = "Bomb 8d6", Level = 15 };
        ClassAbility _bomb9 = new ClassAbility { Name = "Bomb 9d6", Level = 17 };
        ClassAbility _bomb10 = new ClassAbility { Name = "Bomb 10d6", Level = 19 };
        ClassAbility _brewPotion = new ClassAbility { Name = "Brew Potion", Level = 1 };
        ClassAbility _extracts = new ClassAbility { Name = "Extracts", Level = 1 };
        ClassAbility _mutagen = new ClassAbility { Name = "Mutagen", Level = 1 };
        ClassAbility _throwAnything = new ClassAbility { Name = "Throw Anything", Level = 1 };
        ClassAbility _discovery2 = new ClassAbility { Name = "Discovery", Level = 2 };
        ClassAbility _discovery4 = new ClassAbility { Name = "Discovery", Level = 4 };
        ClassAbility _discovery6 = new ClassAbility { Name = "Discovery", Level = 6 };
        ClassAbility _discovery8 = new ClassAbility { Name = "Discovery", Level = 8 };
        ClassAbility _discovery10 = new ClassAbility { Name = "Discovery", Level = 10 };
        ClassAbility _discovery12 = new ClassAbility { Name = "Discovery", Level = 12 };
        ClassAbility _discovery14 = new ClassAbility { Name = "Discovery", Level = 14 };
        ClassAbility _discovery16 = new ClassAbility { Name = "Discovery", Level = 16 };
        ClassAbility _discovery18 = new ClassAbility { Name = "Discovery", Level = 18 };
        ClassAbility _poisonResistance2 = new ClassAbility { Name = "Poison Resistance +2", Level = 2 };
        ClassAbility _poisonResistance4 = new ClassAbility { Name = "Poison Resistance +4", Level = 5 };
        ClassAbility _poisonResistance6 = new ClassAbility { Name = "Poison Resistance +6", Level = 8 };
        ClassAbility _poisonImmunity = new ClassAbility { Name = "Poison Immunity", Level = 10 };
        ClassAbility _poisonUse = new ClassAbility { Name = "Poison Use", Level = 2 };
        ClassAbility _swiftAlchemy = new ClassAbility { Name = "Swift Alchemy", Level = 3 };
        ClassAbility _swiftPoisoning = new ClassAbility { Name = "Swift Poisoning", Level = 6 };
        ClassAbility _persistentMutagen = new ClassAbility { Name = "Persistent Mutagen", Level = 14 };
        ClassAbility _instantAlchemy = new ClassAbility { Name = "Instant Alchemy", Level = 18 };
        ClassAbility _grandDiscovery = new ClassAbility { Name = "Grand Discovery", Level = 20 };
        #endregion

        Archetype Aerochemist
        {
            get
            {
                return new Archetype
                {
                    Name = "Aerochemist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Aeromantic Concoction",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen, _swiftPoisoning, _persistentMutagen }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bombs Away",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse, _swiftAlchemy }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Aerodynamic Prowess",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name.Contains("Poison Resistance")))
                        }
                    }
                };
            }
        }
        Archetype AlchemicalSapper
        {
            get
            {
                return new Archetype
                {
                    Name = "Alchemical Sapper",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Diminished Alchemy",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _alchemy }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 1d6",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 2d6",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 3d6",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 4d6",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 5d6",
                            Level = 9,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 6d6",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 7d6",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 8d6",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 9d6",
                            Level = 17,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bombs 10d6",
                            Level = 19,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bomb 1/day",
                            Level = 1,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bomb 2/day",
                            Level = 5,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bomb 3/day",
                            Level = 9,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bomb 4/day",
                            Level = 13,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Demolition Bomb 5/day",
                            Level = 17,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Delayed Bomb",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Master Engineer",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name.Contains("Poison Resistance")))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Camouflage Bomb",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _swiftAlchemy }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Trip Mine",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _discovery6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Selective Detonation",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        }
                    }
                };
            }
        }
        Archetype AlchemicalTrapper
        {
            get
            {
                return new Archetype
                {
                    Name = "Alchemical Trapper",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Bomb Trap",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _discovery2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Trapfinding",
                            Level = 4,
                            ReplacedAbilities = new List<ClassAbility> { _discovery4 }
                        }
                    }
                };
            }
        }
        Archetype Aquachymist
        {
            get
            {
                return new Archetype
                {
                    Name = "Aquachymist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Sureseal Alchemy",
                            Level = 1,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 1d6",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 2d6",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 3d6",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 4d6",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 5d6",
                            Level = 9,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 6d6",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 7d6",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 8d6",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 9d6",
                            Level = 17,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Underwater Bombs 10d6",
                            Level = 19,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Amphibious Mutagen",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _discovery2 }
                        },
                    }
                };
            }
        }
        Archetype Beastmorph
        {
            get
            {
                return new Archetype
                {
                    Name = "Beastmorph",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Beastform Mutagen",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _swiftAlchemy },
                        },
                        new ArchetypeAbility
                        {
                            Name = "Improved Beastform Mutagen",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _swiftPoisoning },
                        },
                        new ArchetypeAbility
                        {
                            Name = "Greater Beastform Mutagen",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4, _poisonResistance6, _poisonImmunity },
                        },
                        new ArchetypeAbility
                        {
                            Name = "Grand Beastform Mutagen",
                            Level = 14,
                            ReplacedAbilities = new List<ClassAbility> { _persistentMutagen },
                        },
                    }
                };
            }
        }
        Archetype BlazingTorchbearer
        {
            get
            {
                return new Archetype
                {
                    Name = "Blazing Torchbearer",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Everburning Flame",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Intense Light",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse },
                        },
                        new ArchetypeAbility
                        {
                            Name = "Explosive Torch",
                            Level = 4,
                            ReplacedAbilities = new List<ClassAbility> { _discovery4 },
                        },
                    }
                };
            }
        }
        Archetype Blightseeker
        {
            get
            {
                return new Archetype
                {
                    Name = "Blightseeker",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 1d4",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 2d4",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 3d4",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 4d4",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 5d4",
                            Level = 9,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 6d4",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 7d4",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 8d4",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 9d4",
                            Level = 17,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Spore Bomb 10d4",
                            Level = 19,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Blights",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _discovery6, _discovery12, _discovery18 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Blight Engineering",
                            Level = 14,
                            ReplacedAbilities = new List<ClassAbility> { _persistentMutagen }
                        },
                    }
                };
            }
        }
        Archetype BloodAlchemist
        {
            get
            {
                return new Archetype
                {
                    Name = "Blood Alchemist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Lifeblood",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Circles",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name.Contains("Bomb")))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Blood Knowledge",
                            Level = 4,
                        },
                    }
                };
            }
        }
        Archetype BogbornAlchemist
        {
            get
            {
                return new Archetype
                {
                    Name = "Bogborn Alchemist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Amphibious Mutagen",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _throwAnything }
                        }
                    }
                };
            }
        }
        Archetype BrambleBrewer
        {
            get
            {
                return new Archetype
                {
                    Name = "Bramble Brewer",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Briar Bombs",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _discovery2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Dendrite Mutagen",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Grand Discovery",
                            Level = 20,
                            ReplacedAbilities = new List<ClassAbility> { _grandDiscovery }
                        },
                    }
                };
            }
        }
        Archetype Chirurgeon
        {
            get
            {
                return new Archetype
                {
                    Name = "Chirurgeon",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Infused Curative",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Anaesthetic",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Power Over Death",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        },
                    }
                };
            }
        }
        Archetype CloneMaster
        {
            get
            {
                return new Archetype
                {
                    Name = "Clone Master",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Bomb 1d4",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 2d4",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 3d4",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 4d4",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 5d4",
                            Level = 9,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 6d4",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 7d4",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 8d4",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 9d4",
                            Level = 17,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bomb 10d4",
                            Level = 19,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Lesser Simulacrum",
                            Level = 7,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Rebirth",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance6, _poisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Simulacrum",
                            Level = 13,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Clone",
                            Level = 16,
                        },
                    }
                };
            }
        }
        Archetype Concocter
        {
            get
            {
                return new Archetype
                {
                    Name = "Concocter",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Mutagenic Mixology",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _discovery2, _discovery4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Extracting Mixology",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _discovery6 }
                        }
                    }
                };
            }
        }
        Archetype ConstructRider
        {
            get
            {
                return new Archetype
                {
                    Name = "Construct Rider",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Craft Mount",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion, _mutagen, _discovery4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Diminished Extracts",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _extracts },
                            Add = () => LimitedExtracts(true),
                            Remove = () => LimitedExtracts(false)
                        },
                        new ArchetypeAbility
                        {
                            Name = "Construct Rider Discoveries",
                            Level = 2,
                        }
                    }
                };
            }
        }
        Archetype CrimsonChymist
        {
            get
            {
                return new Archetype
                {
                    Name = "Crimson Chymist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Crimson Discoveries",
                            Level = 2,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Mantis Mutagen",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen }
                        }
                    }
                };
            }
        }
        Archetype Cruourchymist
        {
            get
            {
                return new Archetype
                {
                    Name = "Cruorchymist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Blood Famliliar",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Blood Treatment",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Blood Augmentation",
                            Level = 4,
                        }
                    }
                };
            }
        }
        Archetype CryptBreaker
        {
            get
            {
                return new Archetype
                {
                    Name = "Crypt Breaker",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 1d8",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 2d8",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 3d8",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 4d8",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 5d8",
                            Level = 9,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 6d8",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 7d8",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 8d8",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 9d8",
                            Level = 17,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alkahest Bombs 10d8",
                            Level = 19,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Crypt Breaker's Draught",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Trapfinding",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Rogue Talents",
                            Level = 2,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Enhanced Alkahest",
                            Level = 14,
                            ReplacedAbilities = new List<ClassAbility> { _persistentMutagen }
                        }
                    }
                };
            }
        }
        Archetype DeepBomber
        {
            get
            {
                return new Archetype
                {
                    Name = "Deep Bomber",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Silent Bomb",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Targeting Bomb",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _swiftAlchemy }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Stonekin",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _swiftPoisoning }
                        },
                        new ArchetypeAbility
                        {
                            Name = _swiftAlchemy.Name,
                            Level = 18,
                            ReplacedAbilities = new List<ClassAbility> { _instantAlchemy }
                        }
                    }
                };
            }
        }
        Archetype DimensionalExcavator
        {
            get
            {
                return new Archetype
                {
                    Name = "Dimensional Excavator",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Extradimensional Extract",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _discovery4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Precipitous Discoveries",
                            Level = 6,
                        }
                    }
                };
            }
        }
        Archetype DragonbloodChymist
        {
            get
            {
                return new Archetype
                {
                    Name = "Dragonblood Chymist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Dragonblood Mutagen",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen, _discovery2, _discovery12, _discovery16 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Explosive Breath",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _throwAnything }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Draconic Resistances +2",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Draconic Resistances +4",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance4, _swiftPoisoning }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Draconic Resistances +6",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Draconic Resistances Immunity",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        },
                    }
                };
            }
        }
        Archetype Ectochymist
        {
            get
            {
                return new Archetype
                {
                    Name = "Ectochymist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Ectoplasmic Blanche",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name.Contains("Bomb")))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cool-Headed +2",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cool-Headed +4",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cool-Headed +6",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Advanced Ectochymistry",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Swift Ectochymistry",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _swiftPoisoning }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Ghost Trap",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { _discovery8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Ectochymical Analysis",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        }
                    }
                };
            }
        }
        Archetype EctoplasmMaster
        {
            get
            {
                return new Archetype
                {
                    Name = "Ectoplasm Master",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Ectoplasmic Extracts",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Ectoplasm Master Discoveries",
                            Level = 2
                        }
                    }
                };
            }
        }
        Archetype EldritchPoisoner
        {
            get
            {
                return new Archetype
                {
                    Name = "Eldritch Poisoner",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 1",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 2",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 3",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 4",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 5",
                            Level = 9,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 6",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 7",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 8",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 9",
                            Level = 17,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Arcanotoxin 10",
                            Level = 19,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Toxicologist ",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _throwAnything }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Sneak Attack +1d6",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen, _persistentMutagen }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Sneak Attack +2d6",
                            Level = 4,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Sneak Attack +3d6",
                            Level = 8,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Sneak Attack +4d6",
                            Level = 12,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Sneak Attack +5d6",
                            Level = 16,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Sneak Attack +6d6",
                            Level = 20,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Eldritch Poisoner Discoveries",
                            Level = 2,
                        },
                    }
                };
            }
        }
        Archetype Energist
        {
            get
            {
                return new Archetype
                {
                    Name = "Energist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Energy Focus",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _extracts }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 1d6",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity, _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 2d6",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 3d6",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 4d6",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 5d6",
                            Level = 9,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 6d6",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 7d6",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 8d6",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 9d6",
                            Level = 17,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Bombs 10d6",
                            Level = 19,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Healing Ampoule",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _swiftPoisoning }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energist Resistance",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4, _poisonResistance6 }
                        }
                    }
                };
            }
        }
        Archetype EnergyScientist
        {
            get
            {
                return new Archetype
                {
                    Name = "Energy Scientist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 1d6",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion, _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 2d6",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 3d6",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 4d6",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 5d6",
                            Level = 9,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 6d6",
                            Level = 11,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 7d6",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 8d6",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 9d6",
                            Level = 17,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Energy Bombs 10d6",
                            Level = 19,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited Extracts",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _extracts },
                            Add = () => LimitedExtracts(true),
                            Remove = () => LimitedExtracts(false)
                        },
                        new ArchetypeAbility
                        {
                            Name = "Attuned Resistance +2",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Attuned Resistance +3",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Attuned Resistance +4",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Attuned Resistance (Planar Adaptation)",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Salvage Energy",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse, _swiftPoisoning }
                        },
                    }
                };
            }
        }
        Archetype Fermenter
        {
            get
            {
                return new Archetype
                {
                    Name = "Fermenter",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Substance Tolerance +2",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Substance Tolerance +3",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Substance Tolerance +4",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity, _discovery10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Volatile Bombs",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Batch Brew",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _swiftPoisoning }
                        }
                    }
                };
            }
        }
        Archetype FireBomber
        {
            get
            {
                return new Archetype
                {
                    Name = "Fire Bomber",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Fire Bombardier",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _throwAnything }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb1.Name,
                            Level = _bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb2.Name,
                            Level = _bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb3.Name,
                            Level = _bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb4.Name,
                            Level = _bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb5.Name,
                            Level = _bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb6.Name,
                            Level = _bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb7.Name,
                            Level = _bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb8.Name,
                            Level = _bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb9.Name,
                            Level = _bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = _bomb10.Name,
                            Level = _bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Bonus Feats",
                            Level = 2,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Fiery Cocktail",
                            Level = 4,
                            ReplacedAbilities = new List<ClassAbility> { _discovery4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Fire Body",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Improved Fire Body",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Greater Fire Body",
                            Level = 14,
                            ReplacedAbilities = new List<ClassAbility> { _persistentMutagen }
                        },
                    }
                };
            }
        }
        Archetype FirstWorldInnovator
        {
            get
            {
                return new Archetype
                {
                    Name = "First World Innovator",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Primal Reagents",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion, _poisonUse, _swiftPoisoning, _poisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb1.Name,
                            Level = _bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb2.Name,
                            Level = _bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb3.Name,
                            Level = _bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb4.Name,
                            Level = _bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb5.Name,
                            Level = _bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb6.Name,
                            Level = _bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb7.Name,
                            Level = _bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb8.Name,
                            Level = _bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb9.Name,
                            Level = _bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + _bomb10.Name,
                            Level = _bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Refined Reagents",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4, _poisonResistance6 }
                        }
                    }
                };
            }
        }
        Archetype GloomChymist
        {
            get
            {
                return new Archetype
                {
                    Name = "Gloom Chymist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Gloom 1d6",
                            Level = _bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 2d6",
                            Level = _bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 3d6",
                            Level = _bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 4d6",
                            Level = _bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 5d6",
                            Level = _bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 6d6",
                            Level = _bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 7d6",
                            Level = _bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 8d6",
                            Level = _bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 9d6",
                            Level = _bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 10d6",
                            Level = _bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Umbral Gloom",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name.Contains("Poison")))
                        }
                    }
                };
            }
        }
        Archetype Grenadier
        {
            get
            {
                return new Archetype
                {
                    Name = "Grenadier",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Martial Weapon Proficiency",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Weapon",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4, _poisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Precise Bombs",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Directed Blast",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _swiftPoisoning }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Staggering Blast",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        }
                    }
                };
            }
        }
        Archetype GrenadierMC
        {
            get
            {
                return new Archetype
                {
                    Name = "Grenadier [MC]",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Martial Weapon Proficiency",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Weapon",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4, _poisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Precise Bombs",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Directed Blast",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _swiftPoisoning }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Staggering Blast",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        }
                    }
                };
            }
        }
        Archetype GunChemist
        {
            get
            {
                return new Archetype
                {
                    Name = "Gun Chemist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 1d6",
                            Level = _bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 2d6",
                            Level = _bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 3d6",
                            Level = _bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 4d6",
                            Level = _bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 5d6",
                            Level = _bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 6d6",
                            Level = _bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 7d6",
                            Level = _bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 8d6",
                            Level = _bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 9d6",
                            Level = _bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 10d6",
                            Level = _bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gunsmith",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _brewPotion, _throwAnything }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gun Chemist Discoveries",
                            Level = 2
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cartridge Savant +1",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4, _poisonResistance6, _poisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cartridge Savant +2",
                            Level = 5,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cartridge Savant +3",
                            Level = 8,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cartridge Savant +4",
                            Level = 11,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cartridge Savant +5",
                            Level = 14,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cartridge Savant +6",
                            Level = 17,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cartridge Savant +7",
                            Level = 20,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Repeat Fire",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { _swiftPoisoning }
                        }
                    }
                };
            }
        }
        Archetype Herbalist
        {
            get
            {
                return new Archetype
                {
                    Name = "Herbalist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Natural Magic",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _throwAnything }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 1d6",
                            Level = _bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1, _poisonUse, _poisonResistance2, _poisonResistance4, _poisonResistance6, _poisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 2d6",
                            Level = _bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 3d6",
                            Level = _bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 4d6",
                            Level = _bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 5d6",
                            Level = _bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 6d6",
                            Level = _bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 7d6",
                            Level = _bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 8d6",
                            Level = _bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 9d6",
                            Level = _bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 10d6",
                            Level = _bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                    }
                };
            }
        }
        Archetype Homunculist
        {
            get
            {
                return new Archetype
                {
                    Name = "Homunculist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Diminished Poisoning",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name.Contains("Poison")))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Homunculus Familiar",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Experimentation 1",
                            Level = 4,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Experimentation 2",
                            Level = 8,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Experimentation 3",
                            Level = 12,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Experimentation 4",
                            Level = 16,
                        },
                        new ArchetypeAbility
                        {
                            Name = "Experimentation 5",
                            Level = 20,
                        },
                    }
                };
            }
        }
        Archetype Horticulturist
        {
            get
            {
                return new Archetype
                {
                    Name = "Horticulturist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Seed Extract",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { _mutagen, _discovery2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 1d6",
                            Level = _bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 2d6",
                            Level = _bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 3d6",
                            Level = _bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 4d6",
                            Level = _bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 5d6",
                            Level = _bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 6d6",
                            Level = _bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 7d6",
                            Level = _bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 8d6",
                            Level = _bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 9d6",
                            Level = _bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 10d6",
                            Level = _bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Plant Voice +2",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4, _poisonResistance6, _poisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Plant Voice (Speak With Plants)",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { _poisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Plant Familiar",
                            Level = 4,
                            ReplacedAbilities = new List<ClassAbility> { _discovery4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Fury of Nature",
                            Level = 14,
                            ReplacedAbilities = new List<ClassAbility> { _persistentMutagen }
                        }
                    }
                };
            }
        }
        Archetype IceChemist
        {
            get
            {
                return new Archetype
                {
                    Name = "Ice Chemist",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 1d6",
                            Level = _bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 2d6",
                            Level = _bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 3d6",
                            Level = _bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 4d6",
                            Level = _bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 5d6",
                            Level = _bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 6d6",
                            Level = _bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 7d6",
                            Level = _bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 8d6",
                            Level = _bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 9d6",
                            Level = _bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 10d6",
                            Level = _bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { _bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cold Sweat",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _poisonResistance2, _poisonResistance4, _poisonResistance6, _poisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Frost Bomb",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { _discovery2 }
                        }
                    }
                };
            }
        }
    }
}
