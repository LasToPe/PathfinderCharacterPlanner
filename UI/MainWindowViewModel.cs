using GalaSoft.MvvmLight;
using PathfinderModelling;
using PathfinderModelling.Model;
using PathfinderModelling.Model.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace UI
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<CharacterLevel> CharacterLevels { get; }

        public List<CharacterClass> Classes { get; }

        public HashSet<CharacterClass> ActiveClasses => CharacterLevels.Where(cl => cl.Class != null).Select(cl => cl.Class).ToHashSet();

        public MainWindowViewModel()
        {
            var collection = new ObservableCollection<CharacterLevel>();
            for (int i = 1; i <= 20; i++)
            {
                collection.Add(new CharacterLevel { Level = i });
            }
            CharacterLevels = collection;

            Classes = new List<CharacterClass>
            {
                new Alchemist(),
                new Antipaladin(),
                new Arcanist(),
                new Barbarian(),
                new Ranger(),
            };
        }

        public void UpdateCharacterLevels()
        {
            for (int i = 0; i < CharacterLevels.Count(); i++)
            {
                var characterLevel = CharacterLevels[i];
                if (characterLevel.Class == null) continue;
                
                // Update Class Level
                characterLevel.ClassLevel = CharacterLevels.Where(l => l.Class != null && l.Level <= characterLevel.Level).Count(l => l.Class.GetType().Equals(characterLevel.Class.GetType()));

                // Update BAB
                var bab = PathfinderModelling.Repository.BaseAttackBonus.GetBab(characterLevel.Class.BaseAttackBonus)[characterLevel.ClassLevel - 1];
                characterLevel.BAB = i == 0 ? bab : CharacterLevels[i - 1].BAB + bab;

                // Update saves
                var fort = PathfinderModelling.Repository.SavingThrow.GetSavingThrow(characterLevel.Class.FortitudeSave)[characterLevel.ClassLevel - 1];
                var refl = PathfinderModelling.Repository.SavingThrow.GetSavingThrow(characterLevel.Class.ReflexSave)[characterLevel.ClassLevel - 1];
                var will = PathfinderModelling.Repository.SavingThrow.GetSavingThrow(characterLevel.Class.WillSave)[characterLevel.ClassLevel - 1];

                characterLevel.Fort = i == 0 ? fort : CharacterLevels[i - 1].Fort + fort;
                characterLevel.Ref = i == 0 ? refl : CharacterLevels[i - 1].Ref + refl;
                characterLevel.Will = i == 0 ? will : CharacterLevels[i - 1].Will + will;

                characterLevel.RaisePropertyChanged(null);
            }
            RaisePropertyChanged(null);
        }
    }

    public class CharacterLevel : ViewModelBase
    {
        public int Level { get; set; }
        public CharacterClass Class { get; set; }
        public int ClassLevel { get; set; }
        public int BAB { get; set; } = 0;
        public string BaseAttack
        {
            get
            {
                string result = $"+{BAB}";

                if (BAB > 5)  result += $"/+{BAB - 5}";
                if (BAB > 10) result += $"/+{BAB - 10}";
                if (BAB > 15) result += $"/+{BAB - 15}";

                return result;
            }
        }

        public int Fort { get; set; }
        public int Ref { get; set; }
        public int Will { get; set; }

        public string ClassAbilities => Class != null ? string.Join(", ", Class.ClassAbilities.Where(a => a.Level == ClassLevel).Select(a => a.Name)) : "";
    }
}
