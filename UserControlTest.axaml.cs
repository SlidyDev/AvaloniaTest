using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaTest
{
    public partial class UserControlTest : UserControl
    {
        public UserControlTest()
        {
            InitializeComponent();
        }

        public static UserControlTest Create(string someText)
        {
            var uc = new UserControlTest();
            uc.someLabel.Content = someText; // someLabel is null because we're in a UserControl
            return uc;
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
