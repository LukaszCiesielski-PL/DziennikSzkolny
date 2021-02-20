using System.Windows;
using System.Windows.Controls;

namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy Window1.xaml
    /// </summary>

    public partial class Window1 : Window
    {

        private twojeDane _twojeDane = new twojeDane(DaneU.uczenZal);
        private planZajec _planZajec = new planZajec();
        private ocena _ocena = new ocena();
        
        public Window1()
        {
            InitializeComponent();


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public void zalogUcz(string dane)
        {
            daneZalogowanego.Text = dane;
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {

            _twojeDane = new twojeDane(DaneU.uczenZal);
            Navigate.Navigate(_twojeDane);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            _planZajec = new planZajec();
            Navigate.Navigate(_planZajec);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            _ocena = new ocena();
            Navigate.Navigate(_ocena);
        }



        private void wylogujBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow objMainWindow = new MainWindow();
            this.Close();
            objMainWindow.Show();
        }
    }
}
