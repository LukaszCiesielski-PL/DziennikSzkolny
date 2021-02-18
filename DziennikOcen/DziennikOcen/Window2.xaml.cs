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
    /// Logika interakcji dla klasy Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        private twojeDaneNauczyciel _twojeDaneNauczyciel = new twojeDaneNauczyciel();
        private planZajecNauczyciel _planZajecNauczyciel = new planZajecNauczyciel();
        private ocenyNauczyciel _ocenaNauczyciel = new ocenyNauczyciel();
        private uczniowie _uczniowie = new uczniowie();
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _twojeDaneNauczyciel = new twojeDaneNauczyciel();
            NavigateNauczyciel.Navigate(_twojeDaneNauczyciel);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _planZajecNauczyciel = new planZajecNauczyciel();
            NavigateNauczyciel.Navigate(_planZajecNauczyciel);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _ocenaNauczyciel = new ocenyNauczyciel();
            NavigateNauczyciel.Navigate(_ocenaNauczyciel);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            _uczniowie = new uczniowie();
            NavigateNauczyciel.Navigate(_uczniowie);
        }

        private void wylogujBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Close();
            objMainWindow.Show();
        }
    }
}
