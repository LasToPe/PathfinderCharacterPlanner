using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Repository
{
    public class SavingThrow
    {
        //public static List<int> GoodSave = new List<int> { 2, 3, 3, 4, 4, 5, 5, 6, 6, 7, 7, 8, 8, 9, 9, 10, 10, 11, 11, 12 };
        //public static List<int> BadSave = new List<int> { 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 4, 4, 4, 5, 5, 5, 6, 6, 6 };

        private static List<int> GoodSave = new List<int> { 2, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1, 0, 1 };
        private static List<int> BadSave = new List<int> { 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 0 };

        public static List<int> GetSavingThrow(Model.SavingThrow save)
        {
            if (save == Model.SavingThrow.Good)
                return GoodSave;
            if (save == Model.SavingThrow.Bad)
                return BadSave;

            throw new Exception("Saving Throw not found");
        }
    }
}
