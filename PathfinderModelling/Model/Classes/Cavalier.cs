using PathfinderModelling.Model.Archetypes.Cavalier;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Cavalier : CharacterClass
    {
        public Cavalier()
        {
            Name = "Cavalier";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                Challenge1,
                Challenge2,
                Challenge3,
                Challenge4,
                Challenge5,
                Challenge6,
                Challenge7,
                Mount,
                Order,
                Tactician,
                OrderAbility2,
                OrderAbility8,
                OrderAbility15,
                CavaliersCharge,
                ExpertTrainer,
                Banner,
                BonusFeat6,
                BonusFeat12,
                BonusFeat18,
                GreaterTactician,
                MightyCharge,
                DemandingChallenge,
                GreaterBanner,
                MasterTactician,
                SupremeCharge,
            };

            Archetypes.Add(new BeastRider(this));
            Archetypes.Add(new Castellan(this));
            Archetypes.Add(new Charger(this));
            Archetypes.Add(new CircuitJudge(this));
            Archetypes.Add(new Constable(this));
            Archetypes.Add(new CourtlyKnight(this));
            Archetypes.Add(new DaringChampion(this));
            Archetypes.Add(new DaringGeneral(this));
            Archetypes.Add(new DiscipleOfThePike(this));
            Archetypes.Add(new Drakerider(this));
            Archetypes.Add(new Emissary(this));
            Archetypes.Add(new Esquire(this));
            Archetypes.Add(new FellRider(this));
            Archetypes.Add(new FirstMothersFang(this));
            Archetypes.Add(new Gallant(this));
            Archetypes.Add(new Gendarme(this));
            Archetypes.Add(new GhostRider(this));
            Archetypes.Add(new GreenKnight(this));
            Archetypes.Add(new HeraldSquire(this));
            Archetypes.Add(new HonorGuard(this));
            Archetypes.Add(new HoodedKnight(this));
            Archetypes.Add(new Huntmaster(this));
            Archetypes.Add(new Hussar(this));
            Archetypes.Add(new KnightOfArnisant(this));
            Archetypes.Add(new LuringCavalier(this));
            Archetypes.Add(new Musketeer(this));
            Archetypes.Add(new Oceanrider(this));
            Archetypes.Add(new QabaratOutrider(this));
            Archetypes.Add(new QadiranHorselord(this));
            Archetypes.Add(new SaurianChampion(this));
            Archetypes.Add(new SisterInArms(this));
            Archetypes.Add(new SpellscarDrifter(this));
            Archetypes.Add(new StandardBearer(this));
            Archetypes.Add(new Strategist(this));
            Archetypes.Add(new Verdivant(this));
            Archetypes.Add(new VerminTamer(this));
            Archetypes.Add(new WaveRider(this));
        }

        readonly ClassAbility _challenge1 = new ClassAbility { Name = "Challenge 1/day", Level = 1 };
        readonly ClassAbility _challenge2 = new ClassAbility { Name = "Challenge 2/day", Level = 4 };
        readonly ClassAbility _challenge3 = new ClassAbility { Name = "Challenge 3/day", Level = 7 };
        readonly ClassAbility _challenge4 = new ClassAbility { Name = "Challenge 4/day", Level = 10 };
        readonly ClassAbility _challenge5 = new ClassAbility { Name = "Challenge 5/day", Level = 13 };
        readonly ClassAbility _challenge6 = new ClassAbility { Name = "Challenge 6/day", Level = 16 };
        readonly ClassAbility _challenge7 = new ClassAbility { Name = "Challenge 7/day", Level = 19 };
        readonly ClassAbility _mount = new ClassAbility { Name = "Mount", Level = 1 };
        readonly ClassAbility _order = new ClassAbility { Name = "Order", Level = 1 };
        readonly ClassAbility _tactician = new ClassAbility { Name = "Tactician", Level = 1 };
        readonly ClassAbility _orderAbility2 = new ClassAbility { Name = "Order Ability", Level = 2 };
        readonly ClassAbility _orderAbility8 = new ClassAbility { Name = "Order Ability", Level = 8 };
        readonly ClassAbility _orderAbility15 = new ClassAbility { Name = "Order Ability", Level = 15 };
        readonly ClassAbility _cavaliersCharge = new ClassAbility { Name = "Cavalier's Charge", Level = 3 };
        readonly ClassAbility _expertTrainer = new ClassAbility { Name = "Expert Trainer", Level = 4 };
        readonly ClassAbility _banner = new ClassAbility { Name = "Banner", Level = 5 };
        readonly ClassAbility _bonusFeat6 = new ClassAbility { Name = "Bonus Feat", Level = 6 };
        readonly ClassAbility _bonusFeat12 = new ClassAbility { Name = "Bonus Feat", Level = 12 };
        readonly ClassAbility _bonusFeat18 = new ClassAbility { Name = "Bonus Feat", Level = 18 };
        readonly ClassAbility _greaterTactician = new ClassAbility { Name = "Greater Tactician", Level = 9 };
        readonly ClassAbility _mightyCharge = new ClassAbility { Name = "Mighty Charge", Level = 11 };
        readonly ClassAbility _demandingChallenge = new ClassAbility { Name = "Demanding Challenge", Level = 12 };
        readonly ClassAbility _greaterBanner = new ClassAbility { Name = "Greater Banner", Level = 14 };
        readonly ClassAbility _masterTactician = new ClassAbility { Name = "Master Tactician", Level = 17 };
        readonly ClassAbility _supremeCharge = new ClassAbility { Name = "Supreme Charge", Level = 20 };

        public ClassAbility Challenge1 => _challenge1;
        public ClassAbility Challenge2 => _challenge2;
        public ClassAbility Challenge3 => _challenge3;
        public ClassAbility Challenge4 => _challenge4;
        public ClassAbility Challenge5 => _challenge5;
        public ClassAbility Challenge6 => _challenge6;
        public ClassAbility Challenge7 => _challenge7;
        public ClassAbility Mount => _mount;
        public ClassAbility Order => _order;
        public ClassAbility Tactician => _tactician;
        public ClassAbility OrderAbility2 => _orderAbility2;
        public ClassAbility OrderAbility8 => _orderAbility8;
        public ClassAbility OrderAbility15 => _orderAbility15;
        public ClassAbility CavaliersCharge => _cavaliersCharge;
        public ClassAbility ExpertTrainer => _expertTrainer;
        public ClassAbility Banner => _banner;
        public ClassAbility BonusFeat6 => _bonusFeat6;
        public ClassAbility BonusFeat12 => _bonusFeat12;
        public ClassAbility BonusFeat18 => _bonusFeat18;
        public ClassAbility GreaterTactician => _greaterTactician;
        public ClassAbility MightyCharge => _mightyCharge;
        public ClassAbility DemandingChallenge => _demandingChallenge;
        public ClassAbility GreaterBanner => _greaterBanner;
        public ClassAbility MasterTactician => _masterTactician;
        public ClassAbility SupremeCharge => _supremeCharge;
    }
}
