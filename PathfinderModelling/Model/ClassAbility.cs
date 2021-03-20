using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model
{
    public class ClassAbility
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public AbilityType? Type { get; set; }
        public string Description { get; set; }

        public int Level { get; set; }

        //public List<string> Options { get; set; }
    }
}
