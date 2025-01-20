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

namespace Task2_16
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
            double y, S;
            y = Convert.ToDouble(Tbm.Text);
            S = Math.Sqrt(Math.Cos(4 * Math.Pow(y, 2)) + 7.151);
            MessageBox.Show($"S = {S}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
        }
    }
}
