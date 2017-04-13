using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;

namespace ExGentleman
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly MainWindowViewModel _viewModel;

        public MainWindow()
        {
            DataContext =_viewModel = new MainWindowViewModel();

            InitializeComponent();
            this.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;
        }

        private void btnFOs_Click(object sender, RoutedEventArgs e)
        {
            fo1.IsOpen = !fo1.IsOpen;
        }


    }
}
