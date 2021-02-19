using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy haslo.xaml
    /// </summary>
    public partial class haslo : Window
    {
        public haslo()
        {
            InitializeComponent();
        }

        private void cofnijBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Close();
            objMainWindow.Show();
        }

        private void zmien_Click(object sender, RoutedEventArgs e)
        {

        }

        private void nazwaUzytkownika_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
