using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Repository
{
    public class BaseAttackBonus
    {
        //public static List<int> FullBab = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //public static List<int> MediumBab = new List<int> { 0, 1, 2, 3, 3, 4, 5, 6, 6, 7, 8, 9, 9, 1, 11, 12, 12, 13, 14, 15 };
        //public static List<int> HalfBab = new List<int> { 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10 };

        private static List<int> FullBab = new List<int> { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
        private static List<int> MediumBab = new List<int> { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1 };
        private static List<int> HalfBab = new List<int> { 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };

        public static List<int> GetBab(Model.BaseAttackBonus bab)
        {
            if (bab == Model.BaseAttackBonus.Full)
                return FullBab;
            if (bab == Model.BaseAttackBonus.Medium)
                return MediumBab;
            if (bab == Model.BaseAttackBonus.Half)
                return HalfBab;

            throw new Exception("Base Attack Bonus not found");
        }
    }
}
