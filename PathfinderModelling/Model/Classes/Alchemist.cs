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
            Archetypes.Add(new Fermenter(this));
            Archetypes.Add(new FireBomber(this));
            Archetypes.Add(new FirstWorldInnovator(this));
            Archetypes.Add(new GloomChymist(this));
            Archetypes.Add(new Grenadier(this));
            Archetypes.Add(new GrenadierMC(this));
            Archetypes.Add(new GunChemist(this));
            Archetypes.Add(new Herbalist(this));
            Archetypes.Add(new Homunculist(this));
            Archetypes.Add(new Horticulturist(this));
            Archetypes.Add(new IceChemist(this));
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
        readonly ClassAbility _alchemy = new ClassAbility { Name = "Alchemy", Level = 1 };
        readonly ClassAbility _bomb1 = new ClassAbility { Name = "Bomb 1d6", Level = 1 };
        readonly ClassAbility _bomb2 = new ClassAbility { Name = "Bomb 2d6", Level = 3 };
        readonly ClassAbility _bomb3 = new ClassAbility { Name = "Bomb 3d6", Level = 5 };
        readonly ClassAbility _bomb4 = new ClassAbility { Name = "Bomb 4d6", Level = 7 };
        readonly ClassAbility _bomb5 = new ClassAbility { Name = "Bomb 5d6", Level = 9 };
        readonly ClassAbility _bomb6 = new ClassAbility { Name = "Bomb 6d6", Level = 11 };
        readonly ClassAbility _bomb7 = new ClassAbility { Name = "Bomb 7d6", Level = 13 };
        readonly ClassAbility _bomb8 = new ClassAbility { Name = "Bomb 8d6", Level = 15 };
        readonly ClassAbility _bomb9 = new ClassAbility { Name = "Bomb 9d6", Level = 17 };
        readonly ClassAbility _bomb10 = new ClassAbility { Name = "Bomb 10d6", Level = 19 };
        readonly ClassAbility _brewPotion = new ClassAbility { Name = "Brew Potion", Level = 1 };
        readonly ClassAbility _extracts = new ClassAbility { Name = "Extracts", Level = 1 };
        readonly ClassAbility _mutagen = new ClassAbility { Name = "Mutagen", Level = 1 };
        readonly ClassAbility _throwAnything = new ClassAbility { Name = "Throw Anything", Level = 1 };
        readonly ClassAbility _discovery2 = new ClassAbility { Name = "Discovery", Level = 2 };
        readonly ClassAbility _discovery4 = new ClassAbility { Name = "Discovery", Level = 4 };
        readonly ClassAbility _discovery6 = new ClassAbility { Name = "Discovery", Level = 6 };
        readonly ClassAbility _discovery8 = new ClassAbility { Name = "Discovery", Level = 8 };
        readonly ClassAbility _discovery10 = new ClassAbility { Name = "Discovery", Level = 10 };
        readonly ClassAbility _discovery12 = new ClassAbility { Name = "Discovery", Level = 12 };
        readonly ClassAbility _discovery14 = new ClassAbility { Name = "Discovery", Level = 14 };
        readonly ClassAbility _discovery16 = new ClassAbility { Name = "Discovery", Level = 16 };
        readonly ClassAbility _discovery18 = new ClassAbility { Name = "Discovery", Level = 18 };
        readonly ClassAbility _poisonResistance2 = new ClassAbility { Name = "Poison Resistance +2", Level = 2 };
        readonly ClassAbility _poisonResistance4 = new ClassAbility { Name = "Poison Resistance +4", Level = 5 };
        readonly ClassAbility _poisonResistance6 = new ClassAbility { Name = "Poison Resistance +6", Level = 8 };
        readonly ClassAbility _poisonImmunity = new ClassAbility { Name = "Poison Immunity", Level = 10 };
        readonly ClassAbility _poisonUse = new ClassAbility { Name = "Poison Use", Level = 2 };
        readonly ClassAbility _swiftAlchemy = new ClassAbility { Name = "Swift Alchemy", Level = 3 };
        readonly ClassAbility _swiftPoisoning = new ClassAbility { Name = "Swift Poisoning", Level = 6 };
        readonly ClassAbility _persistentMutagen = new ClassAbility { Name = "Persistent Mutagen", Level = 14 };
        readonly ClassAbility _instantAlchemy = new ClassAbility { Name = "Instant Alchemy", Level = 18 };
        readonly ClassAbility _grandDiscovery = new ClassAbility { Name = "Grand Discovery", Level = 20 };

        public ClassAbility Alchemy => _alchemy;
        public ClassAbility Bomb1 => _bomb1;
        public ClassAbility Bomb2 => _bomb2;
        public ClassAbility Bomb3 => _bomb3;
        public ClassAbility Bomb4 => _bomb4;
        public ClassAbility Bomb5 => _bomb5;
        public ClassAbility Bomb6 => _bomb6;
        public ClassAbility Bomb7 => _bomb7;
        public ClassAbility Bomb8 => _bomb8;
        public ClassAbility Bomb9 => _bomb9;
        public ClassAbility Bomb10 => _bomb10;
        public ClassAbility BrewPotion => _brewPotion;
        public ClassAbility Extracts => _extracts;
        public ClassAbility Mutagen => _mutagen;
        public ClassAbility ThrowAnything => _throwAnything;
        public ClassAbility Discovery2 => _discovery2;
        public ClassAbility Discovery4 => _discovery4;
        public ClassAbility Discovery6 => _discovery6;
        public ClassAbility Discovery8 => _discovery8;
        public ClassAbility Discovery10 => _discovery10;
        public ClassAbility Discovery12 => _discovery12;
        public ClassAbility Discovery14 => _discovery14;
        public ClassAbility Discovery16 => _discovery16;
        public ClassAbility Discovery18 => _discovery18;
        public ClassAbility PoisonResistance2 => _poisonResistance2;
        public ClassAbility PoisonResistance4 => _poisonResistance4;
        public ClassAbility PoisonResistance6 => _poisonResistance6;
        public ClassAbility PoisonImmunity => _poisonImmunity;
        public ClassAbility PoisonUse => _poisonUse;
        public ClassAbility SwiftAlchemy => _swiftAlchemy;
        public ClassAbility SwiftPoisoning => _swiftPoisoning;
        public ClassAbility PersistentMutagen => _persistentMutagen;
        public ClassAbility InstantAlchemy => _instantAlchemy;
        public ClassAbility GrandDiscovery => _grandDiscovery;
        #endregion
    }
}
