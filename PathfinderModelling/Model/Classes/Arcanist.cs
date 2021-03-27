using PathfinderModelling.Model.Archetypes.Arcanist;
using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Arcanist : CharacterClass
    {
        public Arcanist()
        {
            Name = "Arcanist";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Half;
            FortitudeSave = SavingThrow.Bad;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
            SpellCaster = true;
            SpellCasting = new SpellCasting
            {
                CasterLevels = new List<CasterLevel>
                {
                    new CasterLevel( 1, null, 2),
                    new CasterLevel( 2, null, 3),
                    new CasterLevel( 3, null, 4),
                    new CasterLevel( 4, null, 4, 2),
                    new CasterLevel( 5, null, 4, 3),
                    new CasterLevel( 6, null, 4, 4, 2),
                    new CasterLevel( 7, null, 4, 4, 3),
                    new CasterLevel( 8, null, 4, 4, 4, 2),
                    new CasterLevel( 9, null, 4, 4, 4, 3),
                    new CasterLevel(10, null, 4, 4, 4, 4, 2),
                    new CasterLevel(11, null, 4, 4, 4, 4, 3),
                    new CasterLevel(12, null, 4, 4, 4, 4, 4, 2),
                    new CasterLevel(13, null, 4, 4, 4, 4, 4, 3),
                    new CasterLevel(14, null, 4, 4, 4, 4, 4, 4, 2),
                    new CasterLevel(15, null, 4, 4, 4, 4, 4, 4, 3),
                    new CasterLevel(16, null, 4, 4, 4, 4, 4, 4, 4, 2),
                    new CasterLevel(17, null, 4, 4, 4, 4, 4, 4, 4, 3),
                    new CasterLevel(18, null, 4, 4, 4, 4, 4, 4, 4, 4, 2),
                    new CasterLevel(19, null, 4, 4, 4, 4, 4, 4, 4, 4, 3),
                    new CasterLevel(20, null, 4, 4, 4, 4, 4, 4, 4, 4, 4),
                }
            };
            ClassAbilities = new List<ClassAbility>
            {
                ArcaneResevoir,
                ArcanistExploit1,
                ArcanistExploit3,
                ArcanistExploit5,
                ArcanistExploit7,
                ArcanistExploit9,
                ArcanistExploit11,
                ArcanistExploit13,
                ArcanistExploit15,
                ArcanistExploit17,
                ArcanistExploit19,
                Cantrips,
                ConsumeSpells,
                Spells,
                GreaterExploits,
                MagicalSupremacy,
            };

            Archetypes.Add(new Aeromancer(this));
            Archetypes.Add(new ArcaneTinkerer(this));
            Archetypes.Add(new BladeAdept(this));
            Archetypes.Add(new BloodArcanist(this));
            Archetypes.Add(new BrownFurTransmuter(this));
            Archetypes.Add(new EldritchFont(this));
            Archetypes.Add(new ElementalMaster(this));
            Archetypes.Add(new HarrowedSocietyStudent(this));
            Archetypes.Add(new MagaambyanInitiate(this));
            Archetypes.Add(new Archetypes.Arcanist.Occultist(this));
            Archetypes.Add(new SchoolSavant(this));
            Archetypes.Add(new SpellSpecialist(this));
            Archetypes.Add(new TwilightSage(this));
            Archetypes.Add(new UnletteredArcanist(this));
            Archetypes.Add(new WhiteMage(this));
        }

        readonly ClassAbility _arcaneResevoir = new ClassAbility { Name = "Arcane Resevoir", Level = 1 };
        readonly ClassAbility _arcanistExploit1 = new ClassAbility { Name = "Arcanist Exploit", Level = 1 };
        readonly ClassAbility _arcanistExploit3 = new ClassAbility { Name = "Arcanist Exploit", Level = 3 };
        readonly ClassAbility _arcanistExploit5 = new ClassAbility { Name = "Arcanist Exploit", Level = 5 };
        readonly ClassAbility _arcanistExploit7 = new ClassAbility { Name = "Arcanist Exploit", Level = 7 };
        readonly ClassAbility _arcanistExploit9 = new ClassAbility { Name = "Arcanist Exploit", Level = 9 };
        readonly ClassAbility _arcanistExploit11 = new ClassAbility { Name = "Arcanist Exploit", Level = 11 };
        readonly ClassAbility _arcanistExploit13 = new ClassAbility { Name = "Arcanist Exploit", Level = 13 };
        readonly ClassAbility _arcanistExploit15 = new ClassAbility { Name = "Arcanist Exploit", Level = 15 };
        readonly ClassAbility _arcanistExploit17 = new ClassAbility { Name = "Arcanist Exploit", Level = 17 };
        readonly ClassAbility _arcanistExploit19 = new ClassAbility { Name = "Arcanist Exploit", Level = 19 };
        readonly ClassAbility _cantrips = new ClassAbility { Name = "Cantrips", Level = 1 };
        readonly ClassAbility _consumeSpells = new ClassAbility { Name = "Consume Spells", Level = 1 };
        readonly ClassAbility _spells = new ClassAbility { Name = "Spells", Level = 1 };
        readonly ClassAbility _greaterExploits = new ClassAbility { Name = "Greater Exploits", Level = 11 };
        readonly ClassAbility _magicalSupremacy = new ClassAbility { Name = "Magical Supremacy", Level = 20 };

        public ClassAbility ArcaneResevoir => _arcaneResevoir;

        public ClassAbility ArcanistExploit1 => _arcanistExploit1;

        public ClassAbility ArcanistExploit3 => _arcanistExploit3;

        public ClassAbility ArcanistExploit5 => _arcanistExploit5;

        public ClassAbility ArcanistExploit7 => _arcanistExploit7;

        public ClassAbility ArcanistExploit9 => _arcanistExploit9;

        public ClassAbility ArcanistExploit11 => _arcanistExploit11;

        public ClassAbility ArcanistExploit13 => _arcanistExploit13;

        public ClassAbility ArcanistExploit15 => _arcanistExploit15;

        public ClassAbility ArcanistExploit17 => _arcanistExploit17;

        public ClassAbility ArcanistExploit19 => _arcanistExploit19;

        public ClassAbility Cantrips => _cantrips;

        public ClassAbility ConsumeSpells => _consumeSpells;

        public ClassAbility Spells => _spells;

        public ClassAbility GreaterExploits => _greaterExploits;

        public ClassAbility MagicalSupremacy => _magicalSupremacy;
    }
}
