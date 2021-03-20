﻿using GalaSoft.MvvmLight;
using PathfinderModelling.Model;
using PathfinderModelling.Repository;
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
                new Alchemist().Class,
                new Ranger().Class,
            };
        }

        public void UpdateCharacterLevels()
        {
            for (int i = 0; i < CharacterLevels.Count(); i++)
            {
                var characterLevel = CharacterLevels[i];
                if (characterLevel.Class == null) continue;

                characterLevel.BabFraction = i == 0 ? characterLevel.Class.BaseAttackBonusFraction : CharacterLevels[i - 1].BabFraction + characterLevel.Class.BaseAttackBonusFraction;
                characterLevel.ClassLevel = CharacterLevels.Where(l => l.Class != null && l.Level <= characterLevel.Level).Count(l => l.Class.GetType().Equals(characterLevel.Class.GetType()));
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
        public float BabFraction { get; set; }
        public int BAB => (int)Math.Floor(BabFraction);
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
        public string ClassAbilities => Class != null ? string.Join(", ", Class.ClassAbilities.Where(a => a.Level == ClassLevel).Select(a => a.Name)) : "";
    }
}