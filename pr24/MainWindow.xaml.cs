using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr24
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

        private void age_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(age.Text) >= 0 && Convert.ToInt32(age.Text) <= 150)
                {
                    errorText.Text = "";
                    age.Background = Brushes.White;
                }
                else
                {
                    errorText.Text = "Ошибка. Возраст должен быть >= 0 или <= 150";
                    age.Background = Brushes.Red;
                }
            }
            catch
            {
                errorText.Text = "Ошибка. Возраст должен состоять из цифр.";
                age.Background = Brushes.Red;
            }
        }

        private void mass_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(mass.Text) >= 0 && Convert.ToInt32(mass.Text) <= 300)
                {
                    errorText.Text = "";
                    mass.Background = Brushes.White;
                }
                else
                {
                    errorText.Text = "Ошибка. Вес: >= 0 и <= 300";
                    mass.Background = Brushes.Red;
                }
            }
            catch
            {
                errorText.Text = "Ошибка. Вес состоит из цифр.";
                mass.Background = Brushes.Red;
            }
        }

        private void height_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (Convert.ToInt32(height.Text) >= 100 && Convert.ToInt32(height.Text) <= 250)
                {
                    errorText.Text = "";
                    height.Background = Brushes.White;
                }
                else
                {
                    errorText.Text = "Ошибка. Рост: >= 100 и <= 250";
                    height.Background = Brushes.Red;
                }
            }
            catch
            {
                errorText.Text = "Ошибка. Рост из цифр.";
                height.Background = Brushes.Red;
            }
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {
            string tempResult = "";
            try
            {
                if (people.SelectedItem == Male)
                {
                    tempResult = Convert.ToString(Convert.ToDouble(66 + (13.7 * Convert.ToDouble(mass.Text)) + (5 * Convert.ToDouble(height.Text)) - (6.8 * Convert.ToDouble(age.Text))));
                }
                else if (people.SelectedItem == Female)
                {
                    tempResult = Convert.ToString(Convert.ToDouble(655 + (9.6 * Convert.ToDouble(mass.Text)) + (1.8 * Convert.ToDouble(height.Text)) - (4.7 * Convert.ToDouble(age.Text))));
                }
                if (activity.SelectedItem == sit)
                {
                    result.Text = Convert.ToString(Convert.ToDouble(tempResult) * 1.2);
                }
                else if (activity.SelectedItem == little)
                {
                    result.Text = "BMR = " + Convert.ToString(Convert.ToDouble(tempResult) + "   TDEE = " + Convert.ToString(Convert.ToDouble(tempResult) * 1.375));
                }
                else if (activity.SelectedItem == normal)
                {
                    result.Text = "BMR = " + Convert.ToString(Convert.ToDouble(tempResult) + "   TDEE = " + Convert.ToString(Convert.ToDouble(tempResult) * 1.55));
                }
                else if (activity.SelectedItem == big)
                {
                    result.Text = "BMR = " + Convert.ToString(Convert.ToDouble(tempResult) + "   TDEE = " + Convert.ToString(Convert.ToDouble(tempResult) * 1.725));
                }
                else if (activity.SelectedItem == extrimal)
                {
                    result.Text = "BMR = " + Convert.ToString(Convert.ToDouble(tempResult) + "   TDEE = " + Convert.ToString(Convert.ToDouble(tempResult) * 1.9));
                }
                errorText.Text = "";
                OK.Background = Brushes.White;
            }
            catch
            {
                errorText.Text = "ОТКАЗАНО! некорректные данные.";
                OK.Background = Brushes.Red;
            }
        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            people.SelectedItem = null;
            age.Text = null;
            mass.Text = null;
            height.Text = null;
            activity.SelectedItem = null;
            errorText.Text = "";
            result.Text = "";
        }
    }
}
