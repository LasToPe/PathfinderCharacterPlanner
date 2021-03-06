using MaterialDesignThemes.Wpf;
using Microsoft.Extensions.DependencyInjection;
using PathfinderModelling.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using UI.ViewModels;

namespace UI.Dialogs
{
    /// <summary>
    /// Interaction logic for ClassSelectorDialog.xaml
    /// </summary>
    public partial class ClassSelectorDialog : UserControl
    {
        private int _level;
        public ClassSelectorDialog(int level)
        {
            InitializeComponent();
            _level = level;
        }

        private CharacterClass _characterClass = null;

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _characterClass = (sender as ListView).SelectedValue as CharacterClass;
        }

        private void SetClass_Click(object sender, RoutedEventArgs e)
        {
            if (_characterClass != null)
            {
                var mainModel = App.ServiceProvider.GetRequiredService<MainWindowViewModel>();
                mainModel.CharacterLevels[_level - 1].Class = _characterClass;
                mainModel.UpdateCharacterLevels();
            }

            DialogHost.Close("Main");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogHost.Close("Main");
        }
    }
}
