using System;
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Windows;
using ExGentleman.Models;
using System.Collections.Generic;

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
            DataContext = _viewModel = new MainWindowViewModel();

            InitializeComponent();

            this.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;

            LoadData();
        }

        private void btnFOs_Click(object sender, RoutedEventArgs e)
        {
            Fo1.IsOpen = !Fo1.IsOpen;
        }

        private void LoadData()
        {
            var rows = new List<People>()
            {
                new People(){EmpNo = "021867", EmpNme = "Jack", BirthDate = DateTime.Now},
                new People(){EmpNo = "024835", EmpNme = "Jack", BirthDate = DateTime.Now},
            };

            DataGridTest.ItemsSource = rows;
        }


    }
}
