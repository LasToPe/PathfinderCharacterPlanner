using PathfinderModelling.Model.Archetypes.Brawler;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Brawler : CharacterClass
    {
        public Brawler()
        {
            Name = "Brawler";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                BrawlersCunning,
                MartialFlexibility,
                MartialTraining,
                UnarmedStrike1,
                UnarmedStrike4,
                UnarmedStrike8,
                UnarmedStrike12,
                UnarmedStrike16,
                UnarmedStrike20,
                BonusCombatFeat2,
                BonusCombatFeat5,
                BonusCombatFeat8,
                BonusCombatFeat11,
                BonusCombatFeat14,
                BonusCombatFeat17,
                BonusCombatFeat20,
                BrawlersFlurry2,
                BrawlersFlurry8,
                BrawlersFlurry15,
                ManeuverTraining3,
                ManeuverTraining7,
                ManeuverTraining11,
                ManeuverTraining15,
                ManeuverTraining19,
                AcBonus1,
                AcBonus2,
                AcBonus3,
                AcBonus4,
                Knockout1,
                Knockout2,
                Knockout3,
                BrawlersStrike5,
                BrawlersStrike9,
                BrawlersStrike12,
                BrawlersStrike17,
                CloseWeaponMastery,
                AwesomeBlow,
                ImprovedAwesomeBlow,
            };

            Archetypes.Add(new BattleDancer(this));
            Archetypes.Add(new Bouncer(this));
            Archetypes.Add(new ConstructedPugilist(this));
            Archetypes.Add(new Exemplar(this));
            Archetypes.Add(new FeralStriker(this));
            Archetypes.Add(new Hinyasi(this));
            Archetypes.Add(new LivingAvalanche(this));
            Archetypes.Add(new MutagenicMauler(this));
            Archetypes.Add(new ShieldChampion(this));
            Archetypes.Add(new SnakebiteStriker(this));
            Archetypes.Add(new SteelBreaker(this));
            Archetypes.Add(new Strangler(this));
            Archetypes.Add(new StrongSideBoxer(this));
            Archetypes.Add(new Turfer(this));
            Archetypes.Add(new UlfenBeastWrestler(this));
            Archetypes.Add(new Venomfist(this));
            Archetypes.Add(new VerdantGrappler(this));
            Archetypes.Add(new WildChild(this));
            Archetypes.Add(new WindingPathRenegade(this));
        }

        readonly ClassAbility _brawlersCunning = new ClassAbility { Name = "Brawler's Cunning", Level = 1 };
        readonly ClassAbility _martialFlexibility = new ClassAbility { Name = "Martial Flexibility", Level = 1 };
        readonly ClassAbility _martialTraining = new ClassAbility { Name = "Martial Training", Level = 1 };
        readonly ClassAbility _unarmedStrike1 = new ClassAbility { Name = "Unarmed Strike 1d6", Level = 1 };
        readonly ClassAbility _unarmedStrike4 = new ClassAbility { Name = "Unarmed Strike 1d8", Level = 4 };
        readonly ClassAbility _unarmedStrike8 = new ClassAbility { Name = "Unarmed Strike 1d10", Level = 8 };
        readonly ClassAbility _unarmedStrike12 = new ClassAbility { Name = "Unarmed Strike 2d6", Level = 12 };
        readonly ClassAbility _unarmedStrike16 = new ClassAbility { Name = "Unarmed Strike 2d8", Level = 16 };
        readonly ClassAbility _unarmedStrike20 = new ClassAbility { Name = "Unarmed Strike 2d10", Level = 20 };
        readonly ClassAbility _bonusCombatFeat2 = new ClassAbility { Name = "Bonus Combat Feat", Level = 2 };
        readonly ClassAbility _bonusCombatFeat5 = new ClassAbility { Name = "Bonus Combat Feat", Level = 5 };
        readonly ClassAbility _bonusCombatFeat8 = new ClassAbility { Name = "Bonus Combat Feat", Level = 8 };
        readonly ClassAbility _bonusCombatFeat11 = new ClassAbility { Name = "Bonus Combat Feat", Level = 11 };
        readonly ClassAbility _bonusCombatFeat14 = new ClassAbility { Name = "Bonus Combat Feat", Level = 14 };
        readonly ClassAbility _bonusCombatFeat17 = new ClassAbility { Name = "Bonus Combat Feat", Level = 17 };
        readonly ClassAbility _bonusCombatFeat20 = new ClassAbility { Name = "Bonus Combat Feat", Level = 20 };
        readonly ClassAbility _brawlersFlurry2 = new ClassAbility { Name = "Brawler's Flurry (Two Weapon Fighting)", Level = 2 };
        readonly ClassAbility _brawlersFlurry8 = new ClassAbility { Name = "Brawler's Flurry (Improved Two Weapon Fighting)", Level = 8 };
        readonly ClassAbility _brawlersFlurry15 = new ClassAbility { Name = "Brawler's Flurry (Greater Two Weapon Fighting)", Level = 15 };
        readonly ClassAbility _maneuverTraining3 = new ClassAbility { Name = "Maneuver Training", Level = 3 };
        readonly ClassAbility _maneuverTraining7 = new ClassAbility { Name = "Maneuver Training", Level = 7 };
        readonly ClassAbility _maneuverTraining11 = new ClassAbility { Name = "Maneuver Training", Level = 11 };
        readonly ClassAbility _maneuverTraining15 = new ClassAbility { Name = "Maneuver Training", Level = 15 };
        readonly ClassAbility _maneuverTraining19 = new ClassAbility { Name = "Maneuver Training", Level = 19 };
        readonly ClassAbility _acBonus1 = new ClassAbility { Name = "AC Bonus +1", Level = 4 };
        readonly ClassAbility _acBonus2 = new ClassAbility { Name = "AC Bonus +2", Level = 9 };
        readonly ClassAbility _acBonus3 = new ClassAbility { Name = "AC Bonus +3", Level = 13 };
        readonly ClassAbility _acBonus4 = new ClassAbility { Name = "AC Bonus +4", Level = 18 };
        readonly ClassAbility _knockout1 = new ClassAbility { Name = "Knockout 1/day", Level = 4 };
        readonly ClassAbility _knockout2 = new ClassAbility { Name = "Knockout 2/day", Level = 10 };
        readonly ClassAbility _knockout3 = new ClassAbility { Name = "Knockout 3/day", Level = 16 };
        readonly ClassAbility _brawlersStrike5 = new ClassAbility { Name = "Brawler's Strike (Magic)", Level = 5 };
        readonly ClassAbility _brawlersStrike9 = new ClassAbility { Name = "Brawler's Strike (Cold Iron and Silver)", Level = 9 };
        readonly ClassAbility _brawlersStrike12 = new ClassAbility { Name = "Brawler's Strike (Alignment)", Level = 12 };
        readonly ClassAbility _brawlersStrike17 = new ClassAbility { Name = "Brawler's Strike (Adamantine)", Level = 17 };
        readonly ClassAbility _closeWeaponMastery = new ClassAbility { Name = "Close Weapon Mastery", Level = 5 };
        readonly ClassAbility _awesomeBlow = new ClassAbility { Name = "Awesome Blow", Level = 16 };
        readonly ClassAbility _improvedAwesomeBlow = new ClassAbility { Name = "Improved Awesome Blow", Level = 20 };

        public ClassAbility BrawlersCunning => _brawlersCunning;
        public ClassAbility MartialFlexibility => _martialFlexibility;
        public ClassAbility MartialTraining => _martialTraining;
        public ClassAbility UnarmedStrike1 => _unarmedStrike1;
        public ClassAbility UnarmedStrike4 => _unarmedStrike4;
        public ClassAbility UnarmedStrike8 => _unarmedStrike8;
        public ClassAbility UnarmedStrike12 => _unarmedStrike12;
        public ClassAbility UnarmedStrike16 => _unarmedStrike16;
        public ClassAbility UnarmedStrike20 => _unarmedStrike20;
        public ClassAbility BonusCombatFeat2 => _bonusCombatFeat2;
        public ClassAbility BonusCombatFeat5 => _bonusCombatFeat5;
        public ClassAbility BonusCombatFeat8 => _bonusCombatFeat8;
        public ClassAbility BonusCombatFeat11 => _bonusCombatFeat11;
        public ClassAbility BonusCombatFeat14 => _bonusCombatFeat14;
        public ClassAbility BonusCombatFeat17 => _bonusCombatFeat17;
        public ClassAbility BonusCombatFeat20 => _bonusCombatFeat20;
        public ClassAbility BrawlersFlurry2 => _brawlersFlurry2;
        public ClassAbility BrawlersFlurry8 => _brawlersFlurry8;
        public ClassAbility BrawlersFlurry15 => _brawlersFlurry15;
        public ClassAbility ManeuverTraining3 => _maneuverTraining3;
        public ClassAbility ManeuverTraining7 => _maneuverTraining7;
        public ClassAbility ManeuverTraining11 => _maneuverTraining11;
        public ClassAbility ManeuverTraining15 => _maneuverTraining15;
        public ClassAbility ManeuverTraining19 => _maneuverTraining19;
        public ClassAbility AcBonus1 => _acBonus1;
        public ClassAbility AcBonus2 => _acBonus2;
        public ClassAbility AcBonus3 => _acBonus3;
        public ClassAbility AcBonus4 => _acBonus4;
        public ClassAbility Knockout1 => _knockout1;
        public ClassAbility Knockout2 => _knockout2;
        public ClassAbility Knockout3 => _knockout3;
        public ClassAbility BrawlersStrike5 => _brawlersStrike5;
        public ClassAbility BrawlersStrike9 => _brawlersStrike9;
        public ClassAbility BrawlersStrike12 => _brawlersStrike12;
        public ClassAbility BrawlersStrike17 => _brawlersStrike17;
        public ClassAbility CloseWeaponMastery => _closeWeaponMastery;
        public ClassAbility AwesomeBlow => _awesomeBlow;
        public ClassAbility ImprovedAwesomeBlow => _improvedAwesomeBlow;
    }
}
