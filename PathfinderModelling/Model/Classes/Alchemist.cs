using PathfinderModelling.Model.Archetypes.Alchemist;
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
                Alchemy,
                Bomb1,
                Bomb2,
                Bomb3,
                Bomb4,
                Bomb5,
                Bomb6,
                Bomb7,
                Bomb8,
                Bomb9,
                Bomb10,
                BrewPotion,
                Extracts,
                Mutagen,
                ThrowAnything,
                Discovery2,
                Discovery4,
                Discovery6,
                Discovery8,
                Discovery10,
                Discovery12,
                Discovery14,
                Discovery16,
                Discovery18,
                PoisonResistance2,
                PoisonResistance4,
                PoisonResistance6,
                PoisonImmunity,
                PoisonUse,
                SwiftAlchemy,
                SwiftPoisoning,
                PersistentMutagen,
                InstantAlchemy,
                GrandDiscovery,
            };

            Archetypes.Add(new Aerochemist(this));
            Archetypes.Add(new AlchemicalSapper(this));
            Archetypes.Add(new AlchemicalTrapper(this));
            Archetypes.Add(new Aquachymist(this));
            Archetypes.Add(new Beastmorph(this));
            Archetypes.Add(new BlazingTorchbearer(this));
            Archetypes.Add(new Blightseeker(this));
            Archetypes.Add(new BloodAlchemist(this));
            Archetypes.Add(new BogbornAlchemist(this));
            Archetypes.Add(new BrambleBrewer(this));
            Archetypes.Add(new Chirurgeon(this));
            Archetypes.Add(new CloneMaster(this));
            Archetypes.Add(new Concocter(this));
            Archetypes.Add(new ConstructRider(this));
            Archetypes.Add(new CrimsonChymist(this));
            Archetypes.Add(new Cruourchymist(this));
            Archetypes.Add(new CryptBreaker(this));
            Archetypes.Add(new DeepBomber(this));
            Archetypes.Add(new DimensionalExcavator(this));
            Archetypes.Add(new DragonbloodChymist(this));
            Archetypes.Add(new Ectochymist(this));
            Archetypes.Add(new EctoplasmMaster(this));
            Archetypes.Add(new EldritchPoisoner(this));
            Archetypes.Add(new Energist(this));
            Archetypes.Add(new EnergyScientist(this));
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

        public void LimitedExtracts(bool activate)
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

        public ClassAbility Alchemy { get => _alchemy; set => _alchemy = value; }
        public ClassAbility Bomb1 { get => _bomb1; set => _bomb1 = value; }
        public ClassAbility Bomb2 { get => _bomb2; set => _bomb2 = value; }
        public ClassAbility Bomb3 { get => _bomb3; set => _bomb3 = value; }
        public ClassAbility Bomb4 { get => _bomb4; set => _bomb4 = value; }
        public ClassAbility Bomb5 { get => _bomb5; set => _bomb5 = value; }
        public ClassAbility Bomb6 { get => _bomb6; set => _bomb6 = value; }
        public ClassAbility Bomb7 { get => _bomb7; set => _bomb7 = value; }
        public ClassAbility Bomb8 { get => _bomb8; set => _bomb8 = value; }
        public ClassAbility Bomb9 { get => _bomb9; set => _bomb9 = value; }
        public ClassAbility Bomb10 { get => _bomb10; set => _bomb10 = value; }
        public ClassAbility BrewPotion { get => _brewPotion; set => _brewPotion = value; }
        public ClassAbility Extracts { get => _extracts; set => _extracts = value; }
        public ClassAbility Mutagen { get => _mutagen; set => _mutagen = value; }
        public ClassAbility ThrowAnything { get => _throwAnything; set => _throwAnything = value; }
        public ClassAbility Discovery2 { get => _discovery2; set => _discovery2 = value; }
        public ClassAbility Discovery4 { get => _discovery4; set => _discovery4 = value; }
        public ClassAbility Discovery6 { get => _discovery6; set => _discovery6 = value; }
        public ClassAbility Discovery8 { get => _discovery8; set => _discovery8 = value; }
        public ClassAbility Discovery10 { get => _discovery10; set => _discovery10 = value; }
        public ClassAbility Discovery12 { get => _discovery12; set => _discovery12 = value; }
        public ClassAbility Discovery14 { get => _discovery14; set => _discovery14 = value; }
        public ClassAbility Discovery16 { get => _discovery16; set => _discovery16 = value; }
        public ClassAbility Discovery18 { get => _discovery18; set => _discovery18 = value; }
        public ClassAbility PoisonResistance2 { get => _poisonResistance2; set => _poisonResistance2 = value; }
        public ClassAbility PoisonResistance4 { get => _poisonResistance4; set => _poisonResistance4 = value; }
        public ClassAbility PoisonResistance6 { get => _poisonResistance6; set => _poisonResistance6 = value; }
        public ClassAbility PoisonImmunity { get => _poisonImmunity; set => _poisonImmunity = value; }
        public ClassAbility PoisonUse { get => _poisonUse; set => _poisonUse = value; }
        public ClassAbility SwiftAlchemy { get => _swiftAlchemy; set => _swiftAlchemy = value; }
        public ClassAbility SwiftPoisoning { get => _swiftPoisoning; set => _swiftPoisoning = value; }
        public ClassAbility PersistentMutagen { get => _persistentMutagen; set => _persistentMutagen = value; }
        public ClassAbility InstantAlchemy { get => _instantAlchemy; set => _instantAlchemy = value; }
        public ClassAbility GrandDiscovery { get => _grandDiscovery; set => _grandDiscovery = value; }
        #endregion
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
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance2, PoisonResistance4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Substance Tolerance +3",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Substance Tolerance +4",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { PoisonImmunity, Discovery10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Volatile Bombs",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { PoisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Batch Brew",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { SwiftPoisoning }
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
                            ReplacedAbilities = new List<ClassAbility> { ThrowAnything }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb1.Name,
                            Level = Bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb2.Name,
                            Level = Bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb3.Name,
                            Level = Bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb4.Name,
                            Level = Bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb5.Name,
                            Level = Bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb6.Name,
                            Level = Bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb7.Name,
                            Level = Bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb8.Name,
                            Level = Bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb9.Name,
                            Level = Bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = Bomb10.Name,
                            Level = Bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb10 }
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
                            ReplacedAbilities = new List<ClassAbility> { Discovery4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Fire Body",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Improved Fire Body",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { PoisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Greater Fire Body",
                            Level = 14,
                            ReplacedAbilities = new List<ClassAbility> { PersistentMutagen }
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
                            ReplacedAbilities = new List<ClassAbility> { BrewPotion, PoisonUse, SwiftPoisoning, PoisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb1.Name,
                            Level = Bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb2.Name,
                            Level = Bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb3.Name,
                            Level = Bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb4.Name,
                            Level = Bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb5.Name,
                            Level = Bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb6.Name,
                            Level = Bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb7.Name,
                            Level = Bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb8.Name,
                            Level = Bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb9.Name,
                            Level = Bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Limited " + Bomb10.Name,
                            Level = Bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Refined Reagents",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance2, PoisonResistance4, PoisonResistance6 }
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
                            Level = Bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 2d6",
                            Level = Bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 3d6",
                            Level = Bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 4d6",
                            Level = Bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 5d6",
                            Level = Bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 6d6",
                            Level = Bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 7d6",
                            Level = Bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 8d6",
                            Level = Bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 9d6",
                            Level = Bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gloom 10d6",
                            Level = Bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb10 }
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
                            ReplacedAbilities = new List<ClassAbility> { BrewPotion }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Weapon",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance2, PoisonResistance4, PoisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Precise Bombs",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { PoisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Directed Blast",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { SwiftPoisoning }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Staggering Blast",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { PoisonImmunity }
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
                            ReplacedAbilities = new List<ClassAbility> { BrewPotion }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Weapon",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance2, PoisonResistance4, PoisonResistance6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Precise Bombs",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { PoisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Directed Blast",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility> { SwiftPoisoning }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Staggering Blast",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { PoisonImmunity }
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
                            Level = Bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 2d6",
                            Level = Bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 3d6",
                            Level = Bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 4d6",
                            Level = Bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 5d6",
                            Level = Bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 6d6",
                            Level = Bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 7d6",
                            Level = Bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 8d6",
                            Level = Bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 9d6",
                            Level = Bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Alchemical Ordnance 10d6",
                            Level = Bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Gunsmith",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility> { BrewPotion, ThrowAnything }
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
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance2, PoisonResistance4, PoisonResistance6, PoisonImmunity }
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
                            ReplacedAbilities = new List<ClassAbility> { SwiftPoisoning }
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
                            ReplacedAbilities = new List<ClassAbility> { ThrowAnything }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 1d6",
                            Level = Bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb1, PoisonUse, PoisonResistance2, PoisonResistance4, PoisonResistance6, PoisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 2d6",
                            Level = Bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 3d6",
                            Level = Bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 4d6",
                            Level = Bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 5d6",
                            Level = Bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 6d6",
                            Level = Bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 7d6",
                            Level = Bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 8d6",
                            Level = Bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 9d6",
                            Level = Bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Seedpods 10d6",
                            Level = Bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb10 }
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
                            ReplacedAbilities = new List<ClassAbility> { Mutagen }
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
                            ReplacedAbilities = new List<ClassAbility> { Mutagen, Discovery2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 1d6",
                            Level = Bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 2d6",
                            Level = Bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 3d6",
                            Level = Bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 4d6",
                            Level = Bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 5d6",
                            Level = Bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 6d6",
                            Level = Bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 7d6",
                            Level = Bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 8d6",
                            Level = Bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 9d6",
                            Level = Bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Herbal Bombs 10d6",
                            Level = Bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Plant Voice +2",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance2, PoisonResistance4, PoisonResistance6, PoisonUse }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Plant Voice (Speak With Plants)",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility> { PoisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Plant Familiar",
                            Level = 4,
                            ReplacedAbilities = new List<ClassAbility> { Discovery4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Fury of Nature",
                            Level = 14,
                            ReplacedAbilities = new List<ClassAbility> { PersistentMutagen }
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
                            Level = Bomb1.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb1 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 2d6",
                            Level = Bomb2.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb2 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 3d6",
                            Level = Bomb3.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb3 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 4d6",
                            Level = Bomb4.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb4 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 5d6",
                            Level = Bomb5.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb5 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 6d6",
                            Level = Bomb6.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb6 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 7d6",
                            Level = Bomb7.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb7 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 8d6",
                            Level = Bomb8.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb8 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 9d6",
                            Level = Bomb9.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb9 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Icy Bombs 10d6",
                            Level = Bomb10.Level,
                            ReplacedAbilities = new List<ClassAbility> { Bomb10 }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Cold Sweat",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { PoisonResistance2, PoisonResistance4, PoisonResistance6, PoisonImmunity }
                        },
                        new ArchetypeAbility
                        {
                            Name = "Frost Bomb",
                            Level = 2,
                            ReplacedAbilities = new List<ClassAbility> { Discovery2 }
                        }
                    }
                };
            }
        }
    }
}
