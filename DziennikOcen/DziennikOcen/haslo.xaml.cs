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

            string uzytkownik = this.nazwaUzytkownika.Text;
            string haslo = this.hasloUzytkownika.Password;
            string noweHaslo = this.noweHasloUzytkownika.Password;
            bool? ktoU = this.jakoUczen.IsChecked;
            bool? ktoN = this.jakoNauczyciel.IsChecked;


            if (ktoU == true)
            {
                Uczen uczentoupdate = db.Uczens.FirstOrDefault(x => x.Login == uzytkownik);
                if (uczentoupdate.Login == uzytkownik)
                {
                    if (uczentoupdate.Haslo == haslo)
                    {

                        uczentoupdate.Haslo = noweHaslo;

                        db.SaveChanges();
                        MessageBox.Show("Hasło zostało zmienione");
                        MainWindow objMainWindow = new MainWindow();
                        this.Close();
                        objMainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Podałeś złe hasło");
                    }
                }
                else
                {

                    MessageBox.Show("Błędny login");
                }
                
                

            }
            if (ktoN == true)
            {
                Nauczyciel nauczycieltoupdate = db.Nauczyciels.FirstOrDefault(o => o.Login == uzytkownik);
                
               
                if (nauczycieltoupdate.Login == uzytkownik)
                {
                    if (nauczycieltoupdate.Haslo == haslo)
                    {
                        nauczycieltoupdate.Haslo = noweHaslo;

                        db.SaveChanges();
                        MessageBox.Show("Hasło zostało zmienione");
                        MainWindow objMainWindow = new MainWindow();
                        this.Close();
                        objMainWindow.Show();
                    }
                    else
                    {
                        MessageBox.Show("Podałeś złe hasło");
                    }

                }
                else
                {
                    MessageBox.Show("Błędny login");
                }

            }
            

        }

        private void nazwaUzytkownika_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
