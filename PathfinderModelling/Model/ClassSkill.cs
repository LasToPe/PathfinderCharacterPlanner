using System;
using System.Collections.Generic;
using System.Text;

namespace PathfinderModelling.Model
{
    public class ClassSkill
    {
        public int Id { get; set; }

        public CharacterClass CharacterClass { get; set; }
        public Skill Skill { get; set; }
    }
}
