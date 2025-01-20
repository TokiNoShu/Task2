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

namespace Task2_4
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
            double t, a, D;
            a = Convert.ToDouble(Tbm.Text);
            t = Convert.ToInt32(Tbm1.Text);
            D = 9.8 * Math.Pow(a, 2) + 5.52 * Math.Cos(Math.Pow(t, 5));
            MessageBox.Show($"D = {D}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
            Tbm1.Text = string.Empty;
        }
    }
}
