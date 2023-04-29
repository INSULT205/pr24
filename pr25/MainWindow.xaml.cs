using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
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

namespace pr25
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
        long result;
        long temp;
        void CheckMax()
        {
            if (Area.Text.Length > 6 || Convert.ToInt64(Area.Text) > 2147000)
            {
                Area.Text = Area.Text.Remove(Area.Text.Length);
            }
        }

        private void Number_Click(object sender, RoutedEventArgs e)
        {
            if (Area.Text.Length < 6 || Convert.ToInt64(Area.Text) < 2147000)
                Area.Text += ((Button)sender).Content;

        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            Area.Text = "";
            helper.Text = "c";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                helper.Text = "";
                helper.Text = "+";
                SecondNumber();
            }
            catch { }
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                helper.Text = "";
                helper.Text = "-";
                SecondNumber();
            }
            catch { }
        }

        private void multiple_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                helper.Text = "";
                helper.Text = "*";
                SecondNumber();
            }
            catch { }
        }

        private void divine_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                helper.Text = "";
                helper.Text = "/";
                SecondNumber();
            }
            catch { }
        }

        private void ravno_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (helper.Text.Contains("+"))
                {
                    result = Convert.ToInt64(temp) + Convert.ToInt64(Area.Text);
                }
                else if (helper.Text.Contains("-"))
                {
                    result = Convert.ToInt64(temp) - Convert.ToInt64(Area.Text);
                }
                else if (helper.Text.Contains("*"))
                {
                    result = Convert.ToInt64(temp) * Convert.ToInt64(Area.Text);
                }
                else if (helper.Text.Contains("/"))
                {
                    result = Convert.ToInt64(temp) / Convert.ToInt64(Area.Text);
                }
                Area.Text = Convert.ToString(result);
            }
            catch { }
        }
        void SecondNumber()
        {
            temp = Convert.ToInt64(Area.Text);
            Area.Text = "";
        }
    }
}