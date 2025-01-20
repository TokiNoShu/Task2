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

namespace Task2_9
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
            double y, x, V;
            y = Convert.ToDouble(Tbm.Text);
            x = Convert.ToInt32(Tbm1.Text);
            V = Math.Log(y + 0.95) + Math.Sin(Math.Pow(x, 4));
            MessageBox.Show($"V = {V}", "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Information);
            Tbm.Text = string.Empty;
            Tbm1.Text = string.Empty;
        }
    }
}
