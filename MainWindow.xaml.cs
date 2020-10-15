using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using ClassLibrary1;

namespace WpfApp2
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

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            Delenie del = new Delenie(t1.Text, t2.Text);
            if (del.checkinfo())
                t3.Content = del.Nomertwo();
        }


        private void b2_Click(object sender, RoutedEventArgs e)
        {
            t1.Clear();
            t2.Clear();
            Delenie clear = new Delenie(t1.Text, t2.Text);
            t3.Content = clear.Clear();
        }

        private void t1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(t1.Text, "[^0-9-,]"))
            {
                t1.Text = t1.Text.Substring(0, t1.Text.Length - 1);
                t1.SelectionStart = t1.Text.Length;
            }
        }

        private void t2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (Regex.IsMatch(t2.Text, "[^0-9-,]"))
            {
                t2.Text = t2.Text.Substring(0, t2.Text.Length - 1);
                t2.SelectionStart = t2.Text.Length;
            }
        }
    }
}
