using PathfinderModelling.Model.Archetypes.Bloodrager;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Bloodrager : CharacterClass
    {
        public Bloodrager()
        {
            Name = "Bloodrager";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Full;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Bad;
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null),
                    new CasterLevel( 2, null),
                    new CasterLevel( 3, null),
                    new CasterLevel( 4, null, 1),
                    new CasterLevel( 5, null, 1),
                    new CasterLevel( 6, null, 1),
                    new CasterLevel( 7, null, 1, 1),
                    new CasterLevel( 8, null, 1, 1),
                    new CasterLevel( 9, null, 2, 1),
                    new CasterLevel(10, null, 2, 1, 1),
                    new CasterLevel(11, null, 2, 1, 1),
                    new CasterLevel(12, null, 2, 2, 1),
                    new CasterLevel(13, null, 3, 2, 1, 1),
                    new CasterLevel(14, null, 3, 2, 1, 1),
                    new CasterLevel(15, null, 3, 2, 2, 1),
                    new CasterLevel(16, null, 3, 3, 2, 1),
                    new CasterLevel(17, null, 4, 3, 2, 1),
                    new CasterLevel(18, null, 4, 3, 2, 2),
                    new CasterLevel(19, null, 4, 3, 3, 2),
                    new CasterLevel(20, null, 4, 4, 3, 2),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                Bloodline,
                BloodlinePower1,
                BloodlinePower4,
                BloodlinePower8,
                BloodlinePower12,
                BloodlinePower16,
                BloodlinePower20,
                Bloodrage,
                FastMovement,
                UncannyDodge,
                BloodSanctuary,
                BloodCasting,
                EschewMaterials,
                Spells,
                ImprovedUncannyDodge,
                BloodlineFeat6,
                BloodlineFeat9,
                BloodlineFeat12,
                BloodlineFeat15,
                BloodlineFeat18,
                BloodlineSpell7,
                BloodlineSpell10,
                BloodlineSpell13,
                BloodlineSpell16,
                DamageReduction1,
                DamageReduction2,
                DamageReduction3,
                DamageReduction4,
                DamageReduction5,
                GreaterBloodrage,
                IndomitableWill,
                TirelessBloodrage,
                MightyBloodrage,
            };

            Archetypes.Add(new AncestralHarbinger(this));
            Archetypes.Add(new BloodConduit(this));
            Archetypes.Add(new Bloodrider(this));
            Archetypes.Add(new BloodyKnuckledRowdy(this));
            Archetypes.Add(new CrossbloodedRager(this));
            Archetypes.Add(new EnlightenedBloodrager(this));
            Archetypes.Add(new Greenrager(this));
            Archetypes.Add(new HagRiven(this));
            Archetypes.Add(new IdRager(this));
            Archetypes.Add(new MetamagicRager(this));
            Archetypes.Add(new Primalist(this));
            Archetypes.Add(new ProwlerAtWorldsEnd(this));
            Archetypes.Add(new Rageshaper(this));
            Archetypes.Add(new Spelleater(this));
            Archetypes.Add(new Steelblood(this));
            Archetypes.Add(new SymbolStriker(this));
            Archetypes.Add(new UntouchableRager(this));
            Archetypes.Add(new UrbanBloodrager(this));
        }

        readonly ClassAbility _bloodline = new ClassAbility { Name = "Bloodline", Level = 1 };
        readonly ClassAbility _bloodlinePower1 = new ClassAbility { Name = "Bloodline Power", Level = 1 };
        readonly ClassAbility _bloodlinePower4 = new ClassAbility { Name = "Bloodline Power", Level = 4 };
        readonly ClassAbility _bloodlinePower8 = new ClassAbility { Name = "Bloodline Power", Level = 8 };
        readonly ClassAbility _bloodlinePower12 = new ClassAbility { Name = "Bloodline Power", Level = 12 };
        readonly ClassAbility _bloodlinePower16 = new ClassAbility { Name = "Bloodline Power", Level = 16 };
        readonly ClassAbility _bloodlinePower20 = new ClassAbility { Name = "Bloodline Power", Level = 20 };
        readonly ClassAbility _bloodrage = new ClassAbility { Name = "Bloodrage", Level = 1 };
        readonly ClassAbility _fastMovement = new ClassAbility { Name = "Fast Movement", Level = 1 };
        readonly ClassAbility _uncannyDodge = new ClassAbility { Name = "Uncanny Dodge", Level = 2 };
        readonly ClassAbility _bloodSanctuary = new ClassAbility { Name = "Blood Sanctuary", Level = 3 };
        readonly ClassAbility _bloodCasting = new ClassAbility { Name = "Blood Casting", Level = 4 };
        readonly ClassAbility _eschewMaterials = new ClassAbility { Name = "Eschew Materials", Level = 4 };
        readonly ClassAbility _spells = new ClassAbility { Name = "Spells", Level = 4 };
        readonly ClassAbility _improvedUncannyDodge = new ClassAbility { Name = "Improved Uncanny Dodge", Level = 5 };
        readonly ClassAbility _bloodlineFeat6 = new ClassAbility { Name = "Bloodline Feat", Level = 6 };
        readonly ClassAbility _bloodlineFeat9 = new ClassAbility { Name = "Bloodline Feat", Level = 9 };
        readonly ClassAbility _bloodlineFeat12 = new ClassAbility { Name = "Bloodline Feat", Level = 12 };
        readonly ClassAbility _bloodlineFeat15 = new ClassAbility { Name = "Bloodline Feat", Level = 15 };
        readonly ClassAbility _bloodlineFeat18 = new ClassAbility { Name = "Bloodline Feat", Level = 18 };
        readonly ClassAbility _bloodlineSpell7 = new ClassAbility { Name = "Bloodline Spell", Level = 7 };
        readonly ClassAbility _bloodlineSpell10 = new ClassAbility { Name = "Bloodline Spell", Level = 10 };
        readonly ClassAbility _bloodlineSpell13 = new ClassAbility { Name = "Bloodline Spell", Level = 13 };
        readonly ClassAbility _bloodlineSpell16 = new ClassAbility { Name = "Bloodline Spell", Level = 16 };
        readonly ClassAbility _damageReduction1 = new ClassAbility { Name = "Damage Reduction 1/-", Level = 7 };
        readonly ClassAbility _damageReduction2 = new ClassAbility { Name = "Damage Reduction 2/-", Level = 10 };
        readonly ClassAbility _damageReduction3 = new ClassAbility { Name = "Damage Reduction 3/-", Level = 13 };
        readonly ClassAbility _damageReduction4 = new ClassAbility { Name = "Damage Reduction 4/-", Level = 16 };
        readonly ClassAbility _damageReduction5 = new ClassAbility { Name = "Damage Reduction 5/-", Level = 19 };
        readonly ClassAbility _greaterBloodrage = new ClassAbility { Name = "Greater Bloodrage", Level = 11 };
        readonly ClassAbility _indomitableWill = new ClassAbility { Name = "Indomitable Will", Level = 14 };
        readonly ClassAbility _tirelessBloodrage = new ClassAbility { Name = "Tireless Bloodrage", Level = 17 };
        readonly ClassAbility _mightyBloodrage = new ClassAbility { Name = "Mighty Bloodrage", Level = 20 };

        public ClassAbility Bloodline => _bloodline;
        public ClassAbility BloodlinePower1 => _bloodlinePower1;
        public ClassAbility BloodlinePower4 => _bloodlinePower4;
        public ClassAbility BloodlinePower8 => _bloodlinePower8;
        public ClassAbility BloodlinePower12 => _bloodlinePower12;
        public ClassAbility BloodlinePower16 => _bloodlinePower16;
        public ClassAbility BloodlinePower20 => _bloodlinePower20;
        public ClassAbility Bloodrage => _bloodrage;
        public ClassAbility FastMovement => _fastMovement;
        public ClassAbility UncannyDodge => _uncannyDodge;
        public ClassAbility BloodSanctuary => _bloodSanctuary;
        public ClassAbility BloodCasting => _bloodCasting;
        public ClassAbility EschewMaterials => _eschewMaterials;
        public ClassAbility Spells => _spells;
        public ClassAbility ImprovedUncannyDodge => _improvedUncannyDodge;
        public ClassAbility BloodlineFeat6 => _bloodlineFeat6;
        public ClassAbility BloodlineFeat9 => _bloodlineFeat9;
        public ClassAbility BloodlineFeat12 => _bloodlineFeat12;
        public ClassAbility BloodlineFeat15 => _bloodlineFeat15;
        public ClassAbility BloodlineFeat18 => _bloodlineFeat18;
        public ClassAbility BloodlineSpell7 => _bloodlineSpell7;
        public ClassAbility BloodlineSpell10 => _bloodlineSpell10;
        public ClassAbility BloodlineSpell13 => _bloodlineSpell13;
        public ClassAbility BloodlineSpell16 => _bloodlineSpell16;
        public ClassAbility DamageReduction1 => _damageReduction1;
        public ClassAbility DamageReduction2 => _damageReduction2;
        public ClassAbility DamageReduction3 => _damageReduction3;
        public ClassAbility DamageReduction4 => _damageReduction4;
        public ClassAbility DamageReduction5 => _damageReduction5;
        public ClassAbility GreaterBloodrage => _greaterBloodrage;
        public ClassAbility IndomitableWill => _indomitableWill;
        public ClassAbility TirelessBloodrage => _tirelessBloodrage;
        public ClassAbility MightyBloodrage => _mightyBloodrage;
    }
}
