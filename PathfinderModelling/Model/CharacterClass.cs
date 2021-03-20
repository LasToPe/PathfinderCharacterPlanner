using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PathfinderModelling.Model
{
    public class CharacterClass
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }
        public string Alignment { get; set; }
        public int HitDie { get; set; }
        public IEnumerable<ClassSkill> ClassSkills { get; set; } = new List<ClassSkill>();
        public int SkillPointsPerLevel { get; set; }
        public BaseAttackBonus BaseAttackBonus { get; set; }
        public float BaseAttackBonusFraction { get; set; }
        public SavingThrow FortitudeSave { get; set; }
        public SavingThrow ReflexSave { get; set; }
        public SavingThrow WillSave { get; set; }
        public List<ClassAbility> ClassAbilities { get; set; } = new List<ClassAbility>();

        public List<Archetype> Archetypes { get; set; } = new List<Archetype>();

        public List<Archetype> AppliedArchetypes { get; } = new List<Archetype>();

        public void AddArchetype(Archetype archetype)
        {
            if (!Archetypes.Contains(archetype))
                throw new Exception($"{archetype} was not found as an archetype for {Name}"); // This should never happen..

            if (AppliedArchetypes.Contains(archetype))
                throw new Exception($"{archetype.Name} is already applied to {Name}"); // <--

            if (archetype.ArchetypeAbilities.SelectMany(a => a.ReplacedAbilities).Any(ca => !ClassAbilities.Contains(ca))) 
                throw new Exception($"{archetype.Name} could not be added, because one or more replaced abilities were already replaced."); // Can apply archetype..


            foreach (var ability in archetype.ArchetypeAbilities)
            {
                foreach (var replacedAbility in ability.ReplacedAbilities)
                {
                    ClassAbilities.Remove(replacedAbility);
                }
                ClassAbilities.Add(ability);
            }

            AppliedArchetypes.Add(archetype);
        }

        public void RemoveArchetype(Archetype archetype)
        {
            if (!AppliedArchetypes.Contains(archetype))
                throw new Exception($"{archetype} was not found among the applied archetypes");

            foreach (var ability in archetype.ArchetypeAbilities)
            {
                ClassAbilities.Remove(ability);

                foreach (var replacedAbility in ability.ReplacedAbilities)
                {
                    ClassAbilities.Add(replacedAbility);
                }
            }

            AppliedArchetypes.Remove(archetype);
        }
    }
}
