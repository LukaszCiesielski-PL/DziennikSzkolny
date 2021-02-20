using Dziennik;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

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

            using var db = new baza();

            string uzytkownikU = this.nazwaUzytkownika.Text;
            string hasloU = this.hasloUzytkownika.Password;
            string noweHasloU = this.noweHasloUzytkownika.Password;
 
            Uczen uczentoupdate = db.Uczens.FirstOrDefault(x => x.Login == uzytkownikU);
            
            
            if(uczentoupdate.Haslo == hasloU)
            {
                uczentoupdate.Haslo = noweHasloU;
                
                db.SaveChanges();
                MessageBox.Show("Hasło zostało zmienione");
            }
            Nauczyciel nauczycieltoupdate = db.Nauczyciels.FirstOrDefault(o => o.Login == uzytkownikU);
            if (nauczycieltoupdate.Haslo == hasloU)
            {
                nauczycieltoupdate.Haslo = noweHasloU;

                db.SaveChanges();
                MessageBox.Show("Hasło zostało zmienione");
            }
            else
            {
                MessageBox.Show("Podałeś złe hasło");
            }
            
            
            

        }

        private void nazwaUzytkownika_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
