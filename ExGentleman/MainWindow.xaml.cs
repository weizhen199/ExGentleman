using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System;
using System.Windows;
using System.Windows.Input;

namespace ExGentleman
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;
        }

        private void btnFOs_Click(object sender, RoutedEventArgs e)
        {
            fo1.IsOpen = !fo1.IsOpen;
        }
    }
}
