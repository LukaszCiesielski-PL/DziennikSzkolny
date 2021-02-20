using Dziennik;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
namespace DziennikOcen
{
    /// <summary>
    /// Logika interakcji dla klasy planZajec.xaml
    /// </summary>
    public partial class planZajec : Page
    {
        public planZajec()
        {
            InitializeComponent();
            wyswietlPlan();
        }

        public void wyswietlPlan()
        {
            using var db = new baza();

            WyswietlPlanU(GetPrzedmiotU(DaneU.uczenZal));

        }

        public void WyswietlPlanU(List<AktualnyPrzedmiot> _aktualnyPrzedmiots)
        {

            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Poniedziałek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Pon.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Wtorek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Wt.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Środa"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Sr.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Czwartek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Czw.Children.Add(_label);
            }
            foreach (var x in _aktualnyPrzedmiots.Where(o => o.Dzien == "Piątek"))
            {
                Label _label = new Label { Height = 60, Content = $"{IdNaPrzedmiot((int)(x.IdPrzedmiot))}\n{IdNaNauczyciel((int)(x.IdNauczyciel))}" };
                Pt.Children.Add(_label);
            }
        }

        public List<AktualnyPrzedmiot> GetPrzedmiotU(Uczen uczen)
        {
            using var db = new baza();
            List<AktualnyPrzedmiot> przedmiots = new List<AktualnyPrzedmiot>();
            foreach (var x in db.AktualnyPrzedmiots.Where(o => o.IdKlasa == uczen.IdKlasa))
            {
                przedmiots.Add(x);
            }
            return przedmiots;
        }



        public string IdNaNauczyciel(int _naNauczyciel)
        {
            using var db = new baza();
            var naucz = db.Nauczyciels.Where(o => o.IdNauczyciel == _naNauczyciel).First();
            return $"{naucz.Imie} {naucz.Nazwisko}";
        }
        public string IdNaPrzedmiot(int _naPrzedmiot)
        {
            using var db = new baza();
            return db.Przedmiots.Where(o => o.IdPrzedmiot == _naPrzedmiot).First().Nazwa;
        }

    }
}
