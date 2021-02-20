using Dziennik;
using System.Linq;
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


    }
}
