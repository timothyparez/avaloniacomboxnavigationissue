using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI.Fody.Helpers;

namespace ComboBoxNavigationIssue.ViewModels
{

    public class MainWindowViewModel : ViewModelBase
    {             
        [Reactive]
        public ComboBoxItemViewModel? SelectedViewModel {get; set;}

        [Reactive]
        public ObservableCollection<ComboBoxItemViewModel> AvailableViewModels {get; private set;}

        public MainWindowViewModel()
        {
            AvailableViewModels = new ObservableCollection<ComboBoxItemViewModel>()
            {                
                new ComboBoxItemViewModel("Products", new ProductsViewModel()),
                new ComboBoxItemViewModel("Customers", new CustomersViewModel()),
                new ComboBoxItemViewModel("Settings", new SettingsViewModel())
            };                   
        }
    }
}
