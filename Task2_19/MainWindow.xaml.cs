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

namespace Task2_19
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
            double P, y, n, g;
            n = Convert.ToDouble(Tbm.Text);
            y = Convert.ToInt32(Tbm1.Text);
            g = Convert.ToInt32(Tbm2.Text);
            P = n * Math.Sqrt(Math.Pow(y, 3) + 1.09 * g);
            MessageBox.Show($"P = {P}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
            Tbm1.Text = string.Empty;
            Tbm2.Text = string.Empty;
        }
    }
}
