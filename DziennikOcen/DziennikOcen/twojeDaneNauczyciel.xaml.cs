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
            daneZalogN.Content = _nauczyciel.NumerTel;



        }
    }
}
