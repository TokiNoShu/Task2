﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Task2_30
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnTask_Click(object sender, RoutedEventArgs e)
        {
            double W, e30, y, r;
            e30 = Convert.ToDouble(Tbm.Text);
            y = Convert.ToInt32(Tbm1.Text);
            r = Convert.ToInt32(Tbm2.Text);
            W = Math.Pow(e30, y + r) + 7.2 * Math.Sin(r);
            MessageBox.Show($"W = {W}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
            Tbm1.Text = string.Empty;
            Tbm2.Text = string.Empty;
        }
    }
}
