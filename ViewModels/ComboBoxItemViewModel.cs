using ReactiveUI.Fody.Helpers;

namespace ComboBoxNavigationIssue.ViewModels
{
    public class ComboBoxItemViewModel : ViewModelBase
    {
        [Reactive]
        public string Title {get; private set;}
        [Reactive]
        public ViewModelBase ContentViewModel {get; private set;}

        public ComboBoxItemViewModel(string title, ViewModelBase contentViewModel) 
        {
            Title = title;
            ContentViewModel = contentViewModel;
        }
    }
}
