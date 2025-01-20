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

namespace Task2_20
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
            double U, e20, k, y, x;
            e20 = Convert.ToDouble(Tbm.Text);
            k = Convert.ToInt32(Tbm1.Text);
            y = Convert.ToInt32(Tbm2.Text);
            x = Convert.ToInt32(Tbm3.Text);
            U = Math.Pow(e20, k + y) + Math.Tan(x * Math.Sqrt(y));
            MessageBox.Show($"U = {U}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
            Tbm1.Text = string.Empty;
            Tbm2.Text = string.Empty;
        }
    }
}
