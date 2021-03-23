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
        }

        #region ClassAbilities
        private ClassAbility _alchemy = new ClassAbility { Name = "Alchemy", Level = 1 };
        private ClassAbility _bomb1 = new ClassAbility { Name = "Bomb 1d6", Level = 1 };
        private ClassAbility _bomb2 = new ClassAbility { Name = "Bomb 2d6", Level = 3 };
        private ClassAbility _bomb3 = new ClassAbility { Name = "Bomb 3d6", Level = 5 };
        private ClassAbility _bomb4 = new ClassAbility { Name = "Bomb 4d6", Level = 7 };
        private ClassAbility _bomb5 = new ClassAbility { Name = "Bomb 5d6", Level = 9 };
        private ClassAbility _bomb6 = new ClassAbility { Name = "Bomb 6d6", Level = 11 };
        private ClassAbility _bomb7 = new ClassAbility { Name = "Bomb 7d6", Level = 13 };
        private ClassAbility _bomb8 = new ClassAbility { Name = "Bomb 8d6", Level = 15 };
        private ClassAbility _bomb9 = new ClassAbility { Name = "Bomb 9d6", Level = 17 };
        private ClassAbility _bomb10 = new ClassAbility { Name = "Bomb 10d6", Level = 19 };
        private ClassAbility _brewPotion = new ClassAbility { Name = "Brew Potion", Level = 1 };
        private ClassAbility _mutagen = new ClassAbility { Name = "Mutagen", Level = 1 };
        private ClassAbility _throwAnything = new ClassAbility { Name = "Throw Anything", Level = 1 };
        private ClassAbility _discovery2 = new ClassAbility { Name = "Discovery", Level = 2 };
        private ClassAbility _discovery4 = new ClassAbility { Name = "Discovery", Level = 4 };
        private ClassAbility _discovery6 = new ClassAbility { Name = "Discovery", Level = 6 };
        private ClassAbility _discovery8 = new ClassAbility { Name = "Discovery", Level = 8 };
        private ClassAbility _discovery10 = new ClassAbility { Name = "Discovery", Level = 10 };
        private ClassAbility _discovery12 = new ClassAbility { Name = "Discovery", Level = 12 };
        private ClassAbility _discovery14 = new ClassAbility { Name = "Discovery", Level = 14 };
        private ClassAbility _discovery16 = new ClassAbility { Name = "Discovery", Level = 16 };
        private ClassAbility _discovery18 = new ClassAbility { Name = "Discovery", Level = 18 };
        private ClassAbility _poisonResistance2 = new ClassAbility { Name = "Poison Resistance +2", Level = 2 };
        private ClassAbility _poisonResistance4 = new ClassAbility { Name = "Poison Resistance +4", Level = 5 };
        private ClassAbility _poisonResistance6 = new ClassAbility { Name = "Poison Resistance +6", Level = 8 };
        private ClassAbility _poisonImmunity = new ClassAbility { Name = "Poison Immunity", Level = 10 };
        private ClassAbility _poisonUse = new ClassAbility { Name = "Poison Use", Level = 2 };
        private ClassAbility _swiftAlchemy = new ClassAbility { Name = "Swift Alchemy", Level = 3 };
        private ClassAbility _swiftPoisoning = new ClassAbility { Name = "Swift Poisoning", Level = 6 };
        private ClassAbility _persistentMutagen = new ClassAbility { Name = "Persistent Mutagen", Level = 14 };
        private ClassAbility _instantAlchemy = new ClassAbility { Name = "Instant Alchemy", Level = 18 };
        private ClassAbility _grandDiscovery = new ClassAbility { Name = "Grand Discovery", Level = 20 };
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
                            Add = () =>
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
                            },
                            Remove = () =>
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
                    Name = "Cruourchymist",
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
    }
}
