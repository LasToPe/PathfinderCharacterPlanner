using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace UI.ViewModels
{
    public class Locator
    {
        public MainWindowViewModel MainWindowViewModel => App.ServiceProvider.GetRequiredService<MainWindowViewModel>();
        public ClassSelectorDialogViewModel ClassSelectorDialogViewModel => App.ServiceProvider.GetRequiredService<ClassSelectorDialogViewModel>();
        public ArchetypeSelectorDialogViewModel ArchetypeSelectorDialogViewModel => App.ServiceProvider.GetRequiredService<ArchetypeSelectorDialogViewModel>();
    }
}
