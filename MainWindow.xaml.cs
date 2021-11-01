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

namespace Practicheskaya18
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

        private void mon_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Рабочий день");
        }

        private void tur_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Рабочий день");
        }

        private void wed_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Рабочий день");
        }

        private void tue_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Рабочий день");
        }

        private void fri_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Рабочий день");
        }

        private void sat_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выходной день");
        }

        private void sun_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выходной день");
        }


        private void b1_Checked(object sender, RoutedEventArgs e)
        {
           if (b1.IsChecked.Value == true) gb1.IsEnabled = true;
            else gb1.IsEnabled = false;
        }

        private void b2_Checked(object sender, RoutedEventArgs e)
        {
            if (b2.IsChecked.Value == true) gb2.IsEnabled = true;
            else gb2.IsEnabled = false;
        }

        private void raschet_Click(object sender, RoutedEventArgs e)
        {
            if (mon1.IsChecked.Value == true) MessageBox.Show("Рабочий день");
            if (tue1.IsChecked.Value == true) MessageBox.Show("Рабочий день");
            if (wed1.IsChecked.Value == true) MessageBox.Show("Рабочий день");
            if (thu1.IsChecked.Value == true) MessageBox.Show("Рабочий день");
            if (fri1.IsChecked.Value == true) MessageBox.Show("Рабочий день");
            if (sat1.IsChecked.Value == true) MessageBox.Show("Выходной день");
            if (sun1.IsChecked.Value == true) MessageBox.Show("Выходной день");
        }

        private void RadioButton1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void mon1_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void tue1_Checked2(object sender, RoutedEventArgs e)
        {

        }

        private void wed1_Checked2(object sender, RoutedEventArgs e)
        {

        }
    }
}
