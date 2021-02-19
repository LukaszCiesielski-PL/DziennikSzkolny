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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Dziennik;


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
    }
}
