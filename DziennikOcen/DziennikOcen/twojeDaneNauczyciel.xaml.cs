using Dziennik;
using System.Windows.Controls;

using System.Linq;
using System.Windows;

namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy twojeDaneNauczyciel.xaml
    /// </summary>
    public partial class twojeDaneNauczyciel : Page
    {
        public twojeDaneNauczyciel()
        {
            InitializeComponent();
            wyswietlDane(DaneU.nauczycielZal);
        }
        public void wyswietlDane(Nauczyciel _nauczyciel)
        {
            using var db = new baza();
            daneZalogN.Content = _nauczyciel.IdNauczyciel;
            daneZalogN_Copy.Content = _nauczyciel.Imie;
            daneZalogN_Copy1.Content = _nauczyciel.Nazwisko;
            daneZalogN_Copy2.Content = _nauczyciel.NumerTel;
            daneZalogN_Copy3.Content = _nauczyciel.Email;
            daneZalogN_Copy4.Content = _nauczyciel.UczonyPrzedmiot;


        }

        private void ID_Checked(object sender, System.Windows.RoutedEventArgs e)
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
            string dane = this.change.Text;
            if(numTel != true && email != true)
            {
                MessageBox.Show("Zaznacz dane które chcesz zmienić");
            }
            if(numTel == true)
            {
               Nauczyciel change = db.Nauczyciels.FirstOrDefault(x => x.NumerTel == x.NumerTel);
               change.NumerTel = dane;
               db.SaveChanges();
               MessageBox.Show("Dane zostały zmienione");
            }
            if (email == true)
            {
                Nauczyciel change = db.Nauczyciels.FirstOrDefault(x => x.Email == x.Email);
                change.Email = dane;
                db.SaveChanges();
                MessageBox.Show("Dane zostały zmienione");
            }



        }
    }
}
