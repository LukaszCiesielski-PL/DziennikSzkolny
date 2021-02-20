using Dziennik;
using System.Linq;
using System.Windows;
using System.Windows.Controls;


namespace DziennikOcen
{
    /// <summary>
    /// 
    /// </summary>


    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

        }

        private void zalogujBtn_Click(object sender, RoutedEventArgs e)
        {
            using var db = new baza();

            string uzytkownikU = this.nazwaUzytkownika.Text;
            string hasloU = this.hasloUzytkownika.Password;
            bool? uczenU = this.jakoUczen.IsChecked;

            string uzytkownikN = this.nazwaUzytkownika.Text;
            string hasloN = this.hasloUzytkownika.Password;
            bool? nauczycielN = this.jakoNauczyciel.IsChecked;

            IQueryable<Uczen> uczens = db.Uczens.Where(c => c.Login == uzytkownikU);



            IQueryable<Nauczyciel> nauczyciels = db.Nauczyciels.Where(n => n.Login == uzytkownikN);


            int liczU = uczens.ToArray().Length;
            int liczN = nauczyciels.ToArray().Length;

            if (uczenU == true)
            {
                if (liczU != 0)
                {
                    foreach (var c in uczens)
                    {
                        if (c.Haslo == hasloU)
                        {


                            IQueryable<Uczen> uczens2 = db.Uczens.Where(c => c.Login == uzytkownikU);
                            DaneU.uczenZal = db.Uczens.Where(c => c.Login == uzytkownikU).First();

                            DaneU.ktoZalogowany = true;
                            foreach (var c2 in uczens2)
                            {
                                włączMenuUcznia($"Jesteś zalogowany jako\n{c2.Imie} {c2.Nazwisko}\n{c2.IdUczen}");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Błędne hasło");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Błędny login");
                }
            }

            if (nauczycielN == true)
            {
                if (liczN != 0)
                {
                    foreach (var n in nauczyciels)
                    {
                        if (n.Haslo == hasloN)
                        {
                            IQueryable<Nauczyciel> nauczyciels2 = db.Nauczyciels.Where(n => n.Login == uzytkownikN);
                            DaneU.nauczycielZal = db.Nauczyciels.Where(n => n.Login == uzytkownikN).First();

                            DaneU.ktoZalogowany = false;
                            foreach (var c3 in nauczyciels2)
                            {
                                włączMenuNauczyciela($"Jesteś zalogowany jako\n{c3.Imie} {c3.Nazwisko}\n{c3.IdNauczyciel}");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Błędne hasło");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Błędny login");
                }
            }

            if (nauczycielN == false & uczenU == false)
            {
                MessageBox.Show("Musisz wybrać kim jesteś !");
            }

        }
        private void włączMenuUcznia(string dane)
        {

            Window1 objWindow1 = new Window1();
            this.Close();
            objWindow1.zalogUcz(dane);
            objWindow1.Show();

        }


        private void włączMenuNauczyciela(string dane2)
        {
            Window2 objWindow2 = new Window2();
            this.Close();
            objWindow2.zalogNau(dane2);
            objWindow2.Show();
        }

        private void nazwaUzytkownika_TextChanged(object sender, TextChangedEventArgs e)
        {

        }



        private void zmienHaslo_Click(object sender, RoutedEventArgs e)
        {
            haslo objHaslo = new haslo();
            this.Close();
            objHaslo.Show();
        }
    }
}
