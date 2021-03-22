using MaterialDesignThemes.Wpf;
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
        private MainWindowViewModel _mainModel;
        public ClassSelectorDialog(int level, MainWindowViewModel mainModel)
        {
            InitializeComponent();
            _level = level;
            _mainModel = mainModel;
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
                _mainModel.CharacterLevels[_level - 1].Class = _characterClass;
                _mainModel.UpdateCharacterLevels();
            }

            DialogHost.Close("Main");
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            DialogHost.Close("Main");
        }
    }
}
