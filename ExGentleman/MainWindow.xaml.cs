﻿using System;
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
            _viewModel = new MainWindowViewModel();
            DataContext = _viewModel;

            InitializeComponent();

            this.MetroDialogOptions.ColorScheme = MetroDialogColorScheme.Accented;
        }

        private void btnFOs_Click(object sender, RoutedEventArgs e)
        {
            Fo1.IsOpen = !Fo1.IsOpen;
        }



    }
}
