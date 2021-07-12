using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ComboBoxNavigationIssue.Views
{
    public partial class CustomersView : UserControl
    {
        public CustomersView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}