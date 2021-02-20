using System.Windows;
using System.Windows.Controls;

namespace DziennikOcen
{
    /// <summary>
    /// Jest to okno nawigacyjne dla zalogowanego nauczyciela zawierające przyciski do nawigacji pomiędzy zakładkami z danymi, planem lekcji i ocenami
    /// </summary>
    public partial class Window2 : Window
    {
        private twojeDaneNauczyciel _twojeDaneNauczyciel = new twojeDaneNauczyciel();
        private planZajecNauczyciel _planZajecNauczyciel = new planZajecNauczyciel();
        private ocenyNauczyciel _ocenaNauczyciel = new ocenyNauczyciel();

        public Window2()
        {
            InitializeComponent();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /// <summary>
        /// Wyświetla dane zalogowanego użytkownika
        /// </summary>
        /// <param name="dane"></param>
        public void zalogNau(string dane2)
        {
            daneZalogowanegoNauczyciela.Text = dane2;
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



        private void wylogujBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Close();
            objMainWindow.Show();
        }
    }
}
