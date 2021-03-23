using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Spiritualist : CharacterClass
    {
        public Spiritualist()
        {
            Name = "Spiritualist";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Bad;
            WillSave = SavingThrow.Good;
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
                new ClassAbility { Name = "Etheric Tether", Level = 1 },
                new ClassAbility { Name = "Knacks", Level = 1 },
                new ClassAbility { Name = "Phantom", Level = 1 },
                new ClassAbility { Name = "Shared Consciousness", Level = 1 },
                new ClassAbility { Name = "Spells", Level = 1 },
                new ClassAbility { Name = "Bonded Senses", Level = 2 },
                new ClassAbility { Name = "Bonded Manifestation", Level = 3 },
                new ClassAbility { Name = "Bonded Manifestation Increase", Level = 8 },
                new ClassAbility { Name = "Bonded Manifestation Increase", Level = 13 },
                new ClassAbility { Name = "Bonded Manifestation Increase", Level = 18 },
                new ClassAbility { Name = "Spiritual Interference", Level = 4 },
                new ClassAbility { Name = "Detect Undead", Level = 5 },
                new ClassAbility { Name = "Phantom Recall 1/day", Level = 6 },
                new ClassAbility { Name = "Phantom Recall 2/day", Level = 10 },
                new ClassAbility { Name = "Phantom Recall 3/day", Level = 14 },
                new ClassAbility { Name = "Phantom Recall 4/day", Level = 18 },
                new ClassAbility { Name = "Clam Spirit 1/day", Level = 7 },
                new ClassAbility { Name = "Clam Spirit 2/day", Level = 11 },
                new ClassAbility { Name = "Clam Spirit 3/day", Level = 15 },
                new ClassAbility { Name = "Clam Spirit 4/day", Level = 19 },
                new ClassAbility { Name = "See Invisibility", Level = 9 },
                new ClassAbility { Name = "Fused Consciousness", Level = 10 },
                new ClassAbility { Name = "Greater Spiritual Interference", Level = 12 },
                new ClassAbility { Name = "Spiritual Bond", Level = 14 },
                new ClassAbility { Name = "Call Spirit", Level = 16 },
                new ClassAbility { Name = "Dual Bond", Level = 17 },
                new ClassAbility { Name = "Empowered Consciousness", Level = 20 },
            };
        }
    }
}
