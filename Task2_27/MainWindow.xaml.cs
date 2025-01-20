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

namespace Task2_27
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
            double W, v, e27, y, x;
            v = Convert.ToDouble(Tbm.Text);
            e27 = Convert.ToInt32(Tbm1.Text);
            y = Convert.ToInt32(Tbm2.Text);
            x = Convert.ToInt32(Tbm3.Text);
            W = 1.03 * v + Math.Pow(e27, 2 * y) + Math.Tan(Math.Abs(x));
            MessageBox.Show($"W = {W}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
            Tbm1.Text = string.Empty;
            Tbm2.Text = string.Empty;
            Tbm3.Text = string.Empty;
        }
    }
}
