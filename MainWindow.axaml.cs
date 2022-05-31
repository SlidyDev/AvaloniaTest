using Avalonia.Controls;
using System;

namespace AvaloniaTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            AddUserControl("This is a test UserControl.");
            AddUserControl("This is another test UserControl.");
        }

        private void AddUserControl(string text)
        {
            someStackPanel.Children.Add(UserControlTest.Create(text)); // someStackPanel is not null
        }
    }
}
