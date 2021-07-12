using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ComboBoxNavigationIssue.ViewModels;
using ReactiveUI;

namespace ComboBoxNavigationIssue.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.WhenActivated(d =>
            {
                //This also has no effect:
                this.FindControl<ComboBox>("SelectedViewModelBox").SelectedIndex = -1;
                this.FindControl<ComboBox>("SelectedViewModelBox").SelectedIndex = 0;
            });

        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public void ButtonClicked(object sender, RoutedEventArgs args)
        {
            //To test the issue, simply open a new window (instead of restarting the app)
            var w = new MainWindow() { DataContext = new MainWindowViewModel()};
            w.Show();
        }
    }
}