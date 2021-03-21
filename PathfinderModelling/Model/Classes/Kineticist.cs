using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model.Classes
{
    public class Kineticist : CharacterClass
    {
        public Kineticist()
        {
            Name = "Kineticist";
            Alignment = "Any";
            BaseAttackBonus = BaseAttackBonus.Medium;
            FortitudeSave = SavingThrow.Good;
            ReflexSave = SavingThrow.Good;
            WillSave = SavingThrow.Bad;
            ClassAbilities = new List<ClassAbility>
            {
                new ClassAbility { Name = "Burn", Level = 1 },
                new ClassAbility { Name = "Elemental Focus", Level = 1 },
                new ClassAbility { Name = "Gather Power", Level = 1 },
                new ClassAbility { Name = "Infusion", Level = 1 },
                new ClassAbility { Name = "Infusion", Level = 3 },
                new ClassAbility { Name = "Infusion", Level = 5 },
                new ClassAbility { Name = "Infusion", Level = 9 },
                new ClassAbility { Name = "Infusion", Level = 11 },
                new ClassAbility { Name = "Infusion", Level = 13 },
                new ClassAbility { Name = "Infusion", Level = 17 },
                new ClassAbility { Name = "Infusion", Level = 19 },
                new ClassAbility { Name = "Kinetic Blast", Level = 1 },
                new ClassAbility { Name = "Elemental Defense", Level = 2 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 2 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 4 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 6 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 8 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 10 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 12 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 14 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 16 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 18 },
                new ClassAbility { Name = "Utility Wild Talent", Level = 20 },
                new ClassAbility { Name = "Elemental Overflow +1", Level = 3 },
                new ClassAbility { Name = "Elemental Overflow +2", Level = 6 },
                new ClassAbility { Name = "Elemental Overflow +3", Level = 9 },
                new ClassAbility { Name = "Elemental Overflow +4", Level = 12 },
                new ClassAbility { Name = "Elemental Overflow +5", Level = 15 },
                new ClassAbility { Name = "Elemental Overflow +6", Level = 18 },
                new ClassAbility { Name = "Infusion Specialization", Level = 5 },
                new ClassAbility { Name = "Metakinesis", Level = 5 },
                new ClassAbility { Name = "Internal Buffer", Level = 6 },
                new ClassAbility { Name = "Expanded Element", Level = 7 },
                new ClassAbility { Name = "Expanded Element", Level = 15 },
                new ClassAbility { Name = "Supercharge", Level = 11 },
                new ClassAbility { Name = "Composite Specialization", Level = 16 },
                new ClassAbility { Name = "Metakinteic Master", Level = 19 },
                new ClassAbility { Name = "Omnikinesis", Level = 20 },
            };
        }
    }
}
