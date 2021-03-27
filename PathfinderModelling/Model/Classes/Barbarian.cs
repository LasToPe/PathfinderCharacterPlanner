using PathfinderModelling.Model.Archetypes.Barbarian;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Barbarian : CharacterClass
    {
        public Barbarian()
        {
            Name = "Barbarian";
            Alignment = "Any Nonlawful";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                FastMovement,
                Rage,
                RagePower2,
                RagePower4,
                RagePower6,
                RagePower8,
                RagePower10,
                RagePower12,
                RagePower14,
                RagePower16,
                RagePower18,
                RagePower20,
                UncannyDodge,
                TrapSense1,
                TrapSense2,
                TrapSense3,
                TrapSense4,
                TrapSense5,
                TrapSense6,
                ImprovedUncannyDodge,
                DamageReduction1,
                DamageReduction2,
                DamageReduction3,
                DamageReduction4,
                DamageReduction5,
                GreaterRage,
                IndomitableWill,
                TirelessRage,
                MightyRage,
            };

            Archetypes.Add(new ArmoredHulk(this));
            Archetypes.Add(new BeastkinBerserker(this));
            Archetypes.Add(new Breaker(this));
            Archetypes.Add(new BrutalPugilist(this));
            Archetypes.Add(new BrutishSwamper(this));
            Archetypes.Add(new CaveDweller(this));
            Archetypes.Add(new DeepwaterRager(this));
            Archetypes.Add(new Dreadnought(this));
            Archetypes.Add(new DrunkenBrute(this));
            Archetypes.Add(new DrunkenRager(this));
            Archetypes.Add(new ElementalKin(this));
        }

        readonly ClassAbility _fastMovement = new ClassAbility { Name = "Fast Movement", Level = 1 };
        readonly ClassAbility _rage = new ClassAbility { Name = "Rage", Level = 1 };
        readonly ClassAbility _ragePower2 = new ClassAbility { Name = "Rage Power", Level = 2 };
        readonly ClassAbility _ragePower4 = new ClassAbility { Name = "Rage Power", Level = 4 };
        readonly ClassAbility _ragePower6 = new ClassAbility { Name = "Rage Power", Level = 6 };
        readonly ClassAbility _ragePower8 = new ClassAbility { Name = "Rage Power", Level = 8 };
        readonly ClassAbility _ragePower10 = new ClassAbility { Name = "Rage Power", Level = 10 };
        readonly ClassAbility _ragePower12 = new ClassAbility { Name = "Rage Power", Level = 12 };
        readonly ClassAbility _ragePower14 = new ClassAbility { Name = "Rage Power", Level = 14 };
        readonly ClassAbility _ragePower16 = new ClassAbility { Name = "Rage Power", Level = 16 };
        readonly ClassAbility _ragePower18 = new ClassAbility { Name = "Rage Power", Level = 18 };
        readonly ClassAbility _ragePower20 = new ClassAbility { Name = "Rage Power", Level = 20 };
        readonly ClassAbility _uncannyDodge = new ClassAbility { Name = "Uncanny Dodge", Level = 2 };
        readonly ClassAbility _trapSense1 = new ClassAbility { Name = "Trap Sense +1", Level = 3 };
        readonly ClassAbility _trapSense2 = new ClassAbility { Name = "Trap Sense +2", Level = 6 };
        readonly ClassAbility _trapSense3 = new ClassAbility { Name = "Trap Sense +3", Level = 9 };
        readonly ClassAbility _trapSense4 = new ClassAbility { Name = "Trap Sense +4", Level = 12 };
        readonly ClassAbility _trapSense5 = new ClassAbility { Name = "Trap Sense +5", Level = 15 };
        readonly ClassAbility _trapSense6 = new ClassAbility { Name = "Trap Sense +6", Level = 18 };
        readonly ClassAbility _improvedUncannyDodge = new ClassAbility { Name = "Improved Uncanny Dodge", Level = 5 };
        readonly ClassAbility _damageReduction1 = new ClassAbility { Name = "Damage Reduction 1/-", Level = 7 };
        readonly ClassAbility _damageReduction2 = new ClassAbility { Name = "Damage Reduction 2/-", Level = 10 };
        readonly ClassAbility _damageReduction3 = new ClassAbility { Name = "Damage Reduction 3/-", Level = 13 };
        readonly ClassAbility _damageReduction4 = new ClassAbility { Name = "Damage Reduction 4/-", Level = 16 };
        readonly ClassAbility _damageReduction5 = new ClassAbility { Name = "Damage Reduction 5/-", Level = 19 };
        readonly ClassAbility _greaterRage = new ClassAbility { Name = "Greater Rage", Level = 11 };
        readonly ClassAbility _indomitableWill = new ClassAbility { Name = "Indomitable Will", Level = 14 };
        readonly ClassAbility _tirelessRage = new ClassAbility { Name = "Tireless Rage", Level = 17 };
        readonly ClassAbility _mightyRage = new ClassAbility { Name = "Mighty Rage", Level = 20 };

        public ClassAbility FastMovement => _fastMovement;

        public ClassAbility Rage => _rage;

        public ClassAbility RagePower2 => _ragePower2;

        public ClassAbility RagePower4 => _ragePower4;

        public ClassAbility RagePower6 => _ragePower6;

        public ClassAbility RagePower8 => _ragePower8;

        public ClassAbility RagePower10 => _ragePower10;

        public ClassAbility RagePower12 => _ragePower12;

        public ClassAbility RagePower14 => _ragePower14;

        public ClassAbility RagePower16 => _ragePower16;

        public ClassAbility RagePower18 => _ragePower18;

        public ClassAbility RagePower20 => _ragePower20;

        public ClassAbility UncannyDodge => _uncannyDodge;

        public ClassAbility TrapSense1 => _trapSense1;

        public ClassAbility TrapSense2 => _trapSense2;

        public ClassAbility TrapSense3 => _trapSense3;

        public ClassAbility TrapSense4 => _trapSense4;

        public ClassAbility TrapSense5 => _trapSense5;

        public ClassAbility TrapSense6 => _trapSense6;

        public ClassAbility ImprovedUncannyDodge => _improvedUncannyDodge;

        public ClassAbility DamageReduction1 => _damageReduction1;

        public ClassAbility DamageReduction2 => _damageReduction2;

        public ClassAbility DamageReduction3 => _damageReduction3;

        public ClassAbility DamageReduction4 => _damageReduction4;

        public ClassAbility DamageReduction5 => _damageReduction5;

        public ClassAbility GreaterRage => _greaterRage;

        public ClassAbility IndomitableWill => _indomitableWill;

        public ClassAbility TirelessRage => _tirelessRage;

        public ClassAbility MightyRage => _mightyRage;
    }
}
