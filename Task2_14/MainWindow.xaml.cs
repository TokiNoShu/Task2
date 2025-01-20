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

namespace Task2_14
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
            double R, y, e14, x;
            y = Convert.ToDouble(Tbm.Text);
            e14 = Convert.ToInt32(Tbm1.Text);
            x = Convert.ToInt32(Tbm2.Text);
            R = Math.Abs(Math.Sqrt(Math.Pow(Math.Sin(y), 2) + 6.835 + Math.Pow(e14, x)));
            MessageBox.Show($"R = {R}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
            Tbm1.Text = string.Empty;
            Tbm2.Text = string.Empty;
        }
    }
}
