using PathfinderModelling.Model.Archetypes.Antipaladin;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Antipaladin : CharacterClass
    {
        public Antipaladin()
        {
            Name = "Antipaladin";
            Alignment = "Chaotic Evil";
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
                AuraOfEvil,
                DetectGood,
                SmiteGood1,
                SmiteGood2,
                SmiteGood3,
                SmiteGood4,
                SmiteGood5,
                SmiteGood6,
                SmiteGood7,
                TouchOfCorruption,
                UnholyResilience,
                AuraOfCowardice,
                PlagueBrunger,
                Cruelty3,
                Cruelty6,
                Cruelty9,
                Cruelty12,
                Cruelty15,
                Cruelty18,
                ChannelNegativeEnergy,
                Spells,
                FiendishBoon,
                AuraOfDespair,
                AuraOfVengeance,
                AuraOfSin,
                AuraOfDepravity,
                UnholyChampion,
            };

            Archetypes.Add(new BlightedMyrmidon(this));
            Archetypes.Add(new DreadVanguard(this));
            Archetypes.Add(new Fearmonger(this));
            Archetypes.Add(new Insinuator(this));
            Archetypes.Add(new IronTyrant(this));
            Archetypes.Add(new KnightOfTheSepulcher(this));
            Archetypes.Add(new RoughRampager(this));
            Archetypes.Add(new SealBreaker(this));
            Archetypes.Add(new Tyrant(this));
        }

        readonly ClassAbility _auraOfEvil = new ClassAbility { Name = "Aura of Evil", Level = 1 };
        readonly ClassAbility _detectGood = new ClassAbility { Name = "Detect Good", Level = 1 };
        readonly ClassAbility _smiteGood1 = new ClassAbility { Name = "Smite Good 1/day", Level = 1 };
        readonly ClassAbility _smiteGood2 = new ClassAbility { Name = "Smite Good 2/day", Level = 4 };
        readonly ClassAbility _smiteGood3 = new ClassAbility { Name = "Smite Good 3/day", Level = 7 };
        readonly ClassAbility _smiteGood4 = new ClassAbility { Name = "Smite Good 4/day", Level = 10 };
        readonly ClassAbility _smiteGood5 = new ClassAbility { Name = "Smite Good 5/day", Level = 13 };
        readonly ClassAbility _smiteGood6 = new ClassAbility { Name = "Smite Good 6/day", Level = 16 };
        readonly ClassAbility _smiteGood7 = new ClassAbility { Name = "Smite Good 7/day", Level = 19 };
        readonly ClassAbility _touchOfCorruption = new ClassAbility { Name = "Touch of Corruption", Level = 2 };
        readonly ClassAbility _unholyResilience = new ClassAbility { Name = "Unholy Resilience", Level = 2 };
        readonly ClassAbility _auraOfCowardice = new ClassAbility { Name = "Aura of Cowardice", Level = 3 };
        readonly ClassAbility _plagueBrunger = new ClassAbility { Name = "Plague Bringer", Level = 3 };
        readonly ClassAbility _cruelty3 = new ClassAbility { Name = "Cruelty", Level = 3 };
        readonly ClassAbility _cruelty6 = new ClassAbility { Name = "Cruelty", Level = 6 };
        readonly ClassAbility _cruelty9 = new ClassAbility { Name = "Cruelty", Level = 9 };
        readonly ClassAbility _cruelty12 = new ClassAbility { Name = "Cruelty", Level = 12 };
        readonly ClassAbility _cruelty15 = new ClassAbility { Name = "Cruelty", Level = 15 };
        readonly ClassAbility _cruelty18 = new ClassAbility { Name = "Cruelty", Level = 18 };
        readonly ClassAbility _channelNegativeEnergy = new ClassAbility { Name = "Channel Negative Energy", Level = 4 };
        readonly ClassAbility _spells = new ClassAbility { Name = "Spells", Level = 4 };
        readonly ClassAbility _fiendishBoon = new ClassAbility { Name = "Fiendish Boon", Level = 5 };
        readonly ClassAbility _auraOfDespair = new ClassAbility { Name = "Aura of Despair", Level = 8 };
        readonly ClassAbility _auraOfVengeance = new ClassAbility { Name = "Aura of Vengeance", Level = 11 };
        readonly ClassAbility _auraOfSin = new ClassAbility { Name = "Aura of Sin", Level = 14 };
        readonly ClassAbility _auraOfDepravity = new ClassAbility { Name = "Aura of Depravity", Level = 17 };
        readonly ClassAbility _unholyChampion = new ClassAbility { Name = "Unholy Champion", Level = 20 };

        public ClassAbility AuraOfEvil => _auraOfEvil;
        public ClassAbility DetectGood => _detectGood;
        public ClassAbility SmiteGood1 => _smiteGood1;
        public ClassAbility SmiteGood2 => _smiteGood2;
        public ClassAbility SmiteGood3 => _smiteGood3;
        public ClassAbility SmiteGood4 => _smiteGood4;
        public ClassAbility SmiteGood5 => _smiteGood5;
        public ClassAbility SmiteGood6 => _smiteGood6;
        public ClassAbility SmiteGood7 => _smiteGood7;
        public ClassAbility TouchOfCorruption => _touchOfCorruption;
        public ClassAbility UnholyResilience => _unholyResilience;
        public ClassAbility AuraOfCowardice => _auraOfCowardice;
        public ClassAbility PlagueBrunger => _plagueBrunger;
        public ClassAbility Cruelty3 => _cruelty3;
        public ClassAbility Cruelty6 => _cruelty6;
        public ClassAbility Cruelty9 => _cruelty9;
        public ClassAbility Cruelty12 => _cruelty12;
        public ClassAbility Cruelty15 => _cruelty15;
        public ClassAbility Cruelty18 => _cruelty18;
        public ClassAbility ChannelNegativeEnergy => _channelNegativeEnergy;
        public ClassAbility Spells => _spells;
        public ClassAbility FiendishBoon => _fiendishBoon;
        public ClassAbility AuraOfDespair => _auraOfDespair;
        public ClassAbility AuraOfVengeance => _auraOfVengeance;
        public ClassAbility AuraOfSin => _auraOfSin;
        public ClassAbility AuraOfDepravity => _auraOfDepravity;
        public ClassAbility UnholyChampion => _unholyChampion;
    }
}
