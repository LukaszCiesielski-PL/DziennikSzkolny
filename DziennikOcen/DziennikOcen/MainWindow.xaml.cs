using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Dziennik;
using Microsoft.EntityFrameworkCore;
using DziennikOcen;

namespace DziennikOcen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
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

            if(uczenU == true)
            {
                if (liczU != 0)
                {
                    foreach (var c in uczens)
                    {
                        if (c.Haslo == hasloU)
                        {

                            menuUcznia();

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
                            MessageBox.Show("Zalogowano");
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
            
            if(nauczycielN == false & uczenU == false)
            {
                MessageBox.Show("Musisz wybrać kim jesteś !");
            }

        }
        private void menuUcznia()
        {
            Window1 objWindow1 = new Window1();
            this.Close();
            objWindow1.Show();
        }

        private void nazwaUzytkownika_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
