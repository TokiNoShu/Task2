using System;
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

namespace Task2_10
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
            double U, e10, y, k, x;
            e10 = Convert.ToDouble(Tbm.Text);
            y = Convert.ToInt32(Tbm1.Text);
            k = Convert.ToInt32(Tbm2.Text);
            x = Convert.ToInt32(Tbm3.Text);
            U = Math.Pow(e10, y) + 7.355 * Math.Pow(k, 2) + Math.Pow(Math.Sin(x), 2);
            MessageBox.Show($"U = {U}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
            Tbm1.Text = string.Empty;
            Tbm2.Text = string.Empty;
            Tbm3.Text = string.Empty;
        }
    }
}
