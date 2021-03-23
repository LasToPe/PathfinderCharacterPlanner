using GalaSoft.MvvmLight;
using Microsoft.Extensions.DependencyInjection;
using PathfinderModelling.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UI.ViewModels
{
    public class SpellsViewDialogViewModel : ViewModelBase
    {
        public CharacterClass Class { get; set; }
        public List<CharacterLevel> CharacterLevels => App.ServiceProvider.GetRequiredService<MainWindowViewModel>().CharacterLevels.ToList();
        public List<CharacterCasterLevel> CharacterCasterLevels
        {
            get
            {
                List<CharacterCasterLevel> casterLevels = new List<CharacterCasterLevel>();
                int level = -1;
                for (int i = 0; i < CharacterLevels.Count(cl => cl.Class != null); i++)
                {
                    if (CharacterLevels[i].Class == Class)
                    {
                        level += 1;
                        casterLevels.Add(new CharacterCasterLevel { Level = i + 1, CasterLevel = Class.SpellCasting.CasterLevels[level] });
                    }
                    else if (level > -1)
                    {
                        casterLevels.Add(new CharacterCasterLevel { Level = i + 1, CasterLevel = Class.SpellCasting.CasterLevels[level] });
                    }
                    else
                    {
                        casterLevels.Add(new CharacterCasterLevel { Level = i + 1, CasterLevel = new CasterLevel() });
                    }
                }

                return casterLevels;
            }
        }
    }

    public class CharacterCasterLevel
    {
        public int Level { get; set; }
        public CasterLevel CasterLevel { get; set; }
    }
}
