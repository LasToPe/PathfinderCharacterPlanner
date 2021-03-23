using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Ranger : CharacterClass
    {
        public Ranger()
        {
            Name = "Ranger";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
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
                new ClassAbility { Name = "1st Favored Enemy", Level = 1 },
                new ClassAbility { Name = "2nd Favored Enemy", Level = 5 },
                new ClassAbility { Name = "3rd Favored Enemy", Level = 10 },
                new ClassAbility { Name = "4th Favored Enemy", Level = 15 },
                new ClassAbility { Name = "5th Favored Enemy", Level = 20 },
                new ClassAbility { Name = "Track", Level = 1 },
                new ClassAbility { Name = "Wild Empathy", Level = 1 },
                new ClassAbility { Name = "Combat Style Feat", Level = 2 },
                new ClassAbility { Name = "Combat Style Feat", Level = 6 },
                new ClassAbility { Name = "Combat Style Feat", Level = 10 },
                new ClassAbility { Name = "Combat Style Feat", Level = 14 },
                new ClassAbility { Name = "Combat Style Feat", Level = 18 },
                new ClassAbility { Name = "Endurance", Level = 3 },
                new ClassAbility { Name = "1st Favored Terrain", Level = 3 },
                new ClassAbility { Name = "2nd Favored Terrain", Level = 8 },
                new ClassAbility { Name = "3rd Favored Terrain", Level = 13 },
                new ClassAbility { Name = "4th Favored Terrain", Level = 18 },
                new ClassAbility { Name = "Hunter's Bond", Level = 4 },
                new ClassAbility { Name = "Spells", Level = 4 },
                new ClassAbility { Name = "Woodland Stride", Level = 7 },
                new ClassAbility { Name = "Swift Tracker", Level = 8 },
                new ClassAbility { Name = "Evasion", Level = 9 },
                new ClassAbility { Name = "Quarry", Level = 11 },
                new ClassAbility { Name = "Camouflage", Level = 12 },
                new ClassAbility { Name = "Improved Evasion", Level = 16 },
                new ClassAbility { Name = "Hide in Plain Sight", Level = 17 },
                new ClassAbility { Name = "Improved Quarry", Level = 19 },
                new ClassAbility { Name = "Master Hunter", Level = 20 },
            };

            Archetypes.Add(AbengedoDiver);
            Archetypes.Add(BattleScout);
            Archetypes.Add(BeastMaster);
            Archetypes.Add(Blightwarden);
        }

        private Archetype AbengedoDiver
        {
            get
            {
                return new Archetype
                {
                    Name = "Abendego Diver",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Ocean's Blessing",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Track"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Deep Diver",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Wild Empathy"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Aquatic Terrain +2",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "1st Favored Terrain"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Aquatic Terrain +4",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "2nd Favored Terrain"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Aquatic Terrain +6",
                            Level = 13,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "3rd Favored Terrain"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Aquatic Terrain +8",
                            Level = 18,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "4th Favored Terrain"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Aquatic Adaptation",
                            Level = 7,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Woodland Stride"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Shark Sense",
                            Level = 8,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Swift Tracker"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Killer of the Deep",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Master Hunter"))
                        },
                    }
                };
            }
        }
        private Archetype BattleScout
        {
            get
            {
                return new Archetype
                {
                    Name = "Battle Scout",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Hunter's Bond",
                            Level = 4,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Hunter's Bond"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Advantageous Terrain",
                            Level = 5,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "2nd Favored Enemy"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Infiltration",
                            Level = 10,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "3rd Favored Enemy"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Superior Tactics",
                            Level = 15,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "4th Favored Enemy"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Perfect Advantage",
                            Level = 20,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Master Hunter"))
                        },
                    }
                };
            }
        }
        private Archetype BeastMaster
        {
            get
            {
                return new Archetype
                {
                    Name = "Beast Master",
                    // Class Skills?
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Animal Companion",
                            Level = 4,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Hunter's Bond"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Improved Empathic Link",
                            Level = 6,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Combat Style Feat" && a.Level == 6))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Strong Bond",
                            Level = 12,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Camouflage"))
                        },
                    }
                };
            }
        }
        private Archetype Blightwarden
        {
            get
            {
                return new Archetype
                {
                    Name = "Blightwarden",
                    ArchetypeAbilities = new List<ArchetypeAbility>
                    {
                        new ArchetypeAbility
                        {
                            Name = "Hunt the Blighted",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "1st Favored Enemy"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Emulate Taint",
                            Level = 1,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Wild Empathy"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Blightwalker",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "1st Favored Terrain"))
                        },
                        new ArchetypeAbility
                        {
                            Name = "Resist Corruption",
                            Level = 3,
                            ReplacedAbilities = new List<ClassAbility>(ClassAbilities.Where(a => a.Name == "Endurance"))
                        },
                    }
                };
            }
        }
    }
}
