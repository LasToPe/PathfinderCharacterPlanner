using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model
{
    public class SpellCasting
    {
        public List<CasterLevel> CasterLevels { get; set; }
    }

    public class CasterLevel
    {
        public CasterLevel()
        {
        }

        public CasterLevel(int level, int? zerothLevelSpells, int? firstLevelSpells = null, 
            int? secondLevelSpells = null, int? thirdLevelSpells = null, int? fourthLevelSpells = null, 
            int? fifthLevelSpells = null, int? sixthLevelSpells = null, int? seventhLevelSpells = null, 
            int? eighthLevelSpells = null, int? ninthLevelSpells = null)
        {
            Level = level;
            ZerothLevelSpells = zerothLevelSpells;
            FirstLevelSpells = firstLevelSpells;
            SecondLevelSpells = secondLevelSpells;
            ThirdLevelSpells = thirdLevelSpells;
            FourthLevelSpells = fourthLevelSpells;
            FifthLevelSpells = fifthLevelSpells;
            SixthLevelSpells = sixthLevelSpells;
            SeventhLevelSpells = seventhLevelSpells;
            EighthLevelSpells = eighthLevelSpells;
            NinthLevelSpells = ninthLevelSpells;
        }

        public int Level { get; set; }
        public int? ZerothLevelSpells { get; set; }
        public int? FirstLevelSpells { get; set; }
        public int? SecondLevelSpells { get; set; }
        public int? ThirdLevelSpells { get; set; }
        public int? FourthLevelSpells { get; set; }
        public int? FifthLevelSpells { get; set; }
        public int? SixthLevelSpells { get; set; }
        public int? SeventhLevelSpells { get; set; }
        public int? EighthLevelSpells { get; set; }
        public int? NinthLevelSpells { get; set; }
    }
}
