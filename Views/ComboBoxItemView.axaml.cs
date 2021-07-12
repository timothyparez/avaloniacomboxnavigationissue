using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ComboBoxNavigationIssue.Views
{
    public partial class ComboBoxItemView : UserControl
    {
        public ComboBoxItemView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}