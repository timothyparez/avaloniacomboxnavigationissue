using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI.Fody.Helpers;

namespace ComboBoxNavigationIssue.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {        
        [Reactive]
        public ProductsViewModel ProductsViewModel {get; set;}

        [Reactive]
        public CustomersViewModel CustomersViewModel {get; set;}

        [Reactive]
        public SettingsViewModel SettingsViewModel {get; set;}

        public MainWindowViewModel()
        {
            ProductsViewModel = new ProductsViewModel();
            CustomersViewModel = new CustomersViewModel();
            SettingsViewModel = new SettingsViewModel();
        }
    }
}
