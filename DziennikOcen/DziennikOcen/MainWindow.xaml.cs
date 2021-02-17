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


namespace DziennikOcen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    
    public partial class MainWindow : Window
    {
        private Uczen uczen = new Uczen();
        


        public MainWindow()
        {
            InitializeComponent();
        }

        private void zalogujBtn_Click(object sender, RoutedEventArgs e)
        {
            using var db = new baza();

            string uzytkownik = this.nazwaUzytkownika.Text;
            string haslo = this.hasloUzytkownika.Password;

            IQueryable<Uczen> uczens = db.Uczens.Where(c => c.Login == uzytkownik);

            int licz = uczens.ToArray().Length;

            if(licz != 0)
            {
                foreach(var c in uczens)
                {
                    if(c.Haslo == haslo)
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

        
        private void nazwaUzytkownika_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
