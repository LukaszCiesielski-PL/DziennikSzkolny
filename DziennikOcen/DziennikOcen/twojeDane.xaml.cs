using Dziennik;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy twojeDane.xaml
    /// </summary>
    public partial class twojeDane : Page
    {
        public twojeDane(Uczen _uczen)
        {
            InitializeComponent();
            wyswietlDane(_uczen);
        }

        public void wyswietlDane(Uczen _uczen)
        {
            using var db = new baza();
            daneZalogU.Content = _uczen.Imie;
            daneZalogU_Copy.Content = _uczen.ImieDrugie;
            daneZalogU_Copy1.Content = _uczen.Nazwisko;
            daneZalogU_Copy5.Content = _uczen.DataUrodzenia;
            daneZalogU_Copy7.Content = _uczen.Pesel;
            daneZalogU_Copy8.Content = _uczen.MiastoZam;
            daneZalogU_Copy6.Content = _uczen.UlicaZam;
            daneZalogU_Copy2.Content = _uczen.NumerUl;
            daneZalogU_Copy3.Content = _uczen.NumerTel;
            daneZalogU_Copy4.Content = _uczen.Email;
            daneZalogU_Copy9.Content = db.Klasas.Where(o => o.IdKlasa == _uczen.IdKlasa).First().Nazwa;
            daneZalogU_Copy10.Content = db.Opiekuns.Where(o => o.IdOpiekun == _uczen.IdOpiekun).First().Imie;
            daneZalogU_Copy11.Content = db.Opiekuns.Where(o => o.IdOpiekun == _uczen.IdOpiekun).First().Nazwisko;
            daneZalogU_Copy12.Content = db.Opiekuns.Where(o => o.IdOpiekun == _uczen.IdOpiekun).First().NumerTel;
            daneZalogU_Copy13.Content = db.Opiekuns.Where(o => o.IdOpiekun == _uczen.IdOpiekun).First().Email;
        }

        private void changen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void changeBTNn_Click(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void IDn_Checked(object sender, System.Windows.RoutedEventArgs e)
        {

        }

        private void change_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void changeBTN_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            using var db = new baza();
            bool? numTel = this.Numer.IsChecked;
            bool? email = this.Email.IsChecked;
            bool? miasto = this.Miasto.IsChecked;
            bool? ulica = this.Ulica.IsChecked;
            bool? ulicanr = this.UlicaNr.IsChecked;
            string dane = this.changen.Text;
            bool? numTelO = this.NumerO.IsChecked;
            bool? emailO = this.EmailO.IsChecked;
            if (numTel != true && email != true && miasto != true && ulica != true && ulicanr != true && numTelO != true && emailO != true)
            {
                MessageBox.Show("Zaznacz dane które chcesz zmienić");
            }
            if (numTel == true)
            {
                Uczen change = db.Uczens.FirstOrDefault(x => x.NumerTel == x.NumerTel);
                change.NumerTel = dane;
                db.SaveChanges();
                MessageBox.Show("Dane zostały zmienione");
            }
            if (email == true)
            {
                Uczen change = db.Uczens.FirstOrDefault(x => x.Email == x.Email);
                change.Email = dane;
                db.SaveChanges();

                MessageBox.Show("Dane zostały zmienione");
            }
            if (miasto == true)
            {
                Uczen change = db.Uczens.FirstOrDefault(x => x.MiastoZam == x.MiastoZam);
                change.MiastoZam = dane;
                db.SaveChanges();
                MessageBox.Show("Dane zostały zmienione");
            }
            if (ulica == true)
            {
                Uczen change = db.Uczens.FirstOrDefault(x => x.UlicaZam == x.UlicaZam);
                change.UlicaZam = dane;
                db.SaveChanges();
                MessageBox.Show("Dane zostały zmienione");
            }
            if (ulicanr == true)
            {
                Uczen change = db.Uczens.FirstOrDefault(x => x.NumerUl == x.NumerUl);
                change.NumerUl = dane;
                db.SaveChanges();
                MessageBox.Show("Dane zostały zmienione");
            }
            if (numTelO == true)
            {
                Opiekun change = db.Opiekuns.FirstOrDefault(x => x.NumerTel == x.NumerTel);
                change.NumerTel = dane;
                db.SaveChanges();
                MessageBox.Show("Dane zostały zmienione");
            }
            if (emailO == true)
            {
                Opiekun change = db.Opiekuns.FirstOrDefault(x => x.Email == x.Email);
                change.Email = dane;
                db.SaveChanges();
                MessageBox.Show("Dane zostały zmienione");
            }

        }
    }
}
